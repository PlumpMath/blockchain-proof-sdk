/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove or disprove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin), Multichain or Ethereum blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a configuration is present  2. Register content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing  3. Verify content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing. You will get back whether the content has been registered previously or not      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Sphereon.SDK.Blockchain.Proof.Client.SwaggerDateConverter;

namespace Sphereon.SDK.Blockchain.Proof.Model
{
    /// <summary>
    /// Committed context and settings response
    /// </summary>
    [DataContract]
    public partial class ConfigurationResponse :  IEquatable<ConfigurationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigurationResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationResponse" /> class.
        /// </summary>
        /// <param name="StoredSettings">StoredSettings (required).</param>
        public ConfigurationResponse(StoredSettings StoredSettings = default(StoredSettings))
        {
            // to ensure "StoredSettings" is required (not null)
            if (StoredSettings == null)
            {
                throw new InvalidDataException("StoredSettings is a required property for ConfigurationResponse and cannot be null");
            }
            else
            {
                this.StoredSettings = StoredSettings;
            }
        }
        
        /// <summary>
        /// Gets or Sets StoredSettings
        /// </summary>
        [DataMember(Name="storedSettings", EmitDefaultValue=false)]
        public StoredSettings StoredSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationResponse {\n");
            sb.Append("  StoredSettings: ").Append(StoredSettings).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ConfigurationResponse);
        }

        /// <summary>
        /// Returns true if ConfigurationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of ConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConfigurationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StoredSettings == other.StoredSettings ||
                    this.StoredSettings != null &&
                    this.StoredSettings.Equals(other.StoredSettings)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.StoredSettings != null)
                    hash = hash * 59 + this.StoredSettings.GetHashCode();
                return hash;
            }
        }

    }

}