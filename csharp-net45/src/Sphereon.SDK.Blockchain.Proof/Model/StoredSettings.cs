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
    /// The stored chainSettings from the chainSettings chain
    /// </summary>
    [DataContract]
    public partial class StoredSettings :  IEquatable<StoredSettings>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoredSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredSettings" /> class.
        /// </summary>
        /// <param name="SingleProofChain">SingleProofChain.</param>
        /// <param name="SettingsChain">SettingsChain (required).</param>
        /// <param name="ChainSettings">ChainSettings (required).</param>
        /// <param name="ChainConfiguration">ChainConfiguration (required).</param>
        /// <param name="MetaDataChain">MetaDataChain.</param>
        public StoredSettings(CommittedChain SingleProofChain = default(CommittedChain), CommittedChain SettingsChain = default(CommittedChain), ChainSettings ChainSettings = default(ChainSettings), ChainConfiguration ChainConfiguration = default(ChainConfiguration), CommittedChain MetaDataChain = default(CommittedChain))
        {
            // to ensure "SettingsChain" is required (not null)
            if (SettingsChain == null)
            {
                throw new InvalidDataException("SettingsChain is a required property for StoredSettings and cannot be null");
            }
            else
            {
                this.SettingsChain = SettingsChain;
            }
            // to ensure "ChainSettings" is required (not null)
            if (ChainSettings == null)
            {
                throw new InvalidDataException("ChainSettings is a required property for StoredSettings and cannot be null");
            }
            else
            {
                this.ChainSettings = ChainSettings;
            }
            // to ensure "ChainConfiguration" is required (not null)
            if (ChainConfiguration == null)
            {
                throw new InvalidDataException("ChainConfiguration is a required property for StoredSettings and cannot be null");
            }
            else
            {
                this.ChainConfiguration = ChainConfiguration;
            }
            this.SingleProofChain = SingleProofChain;
            this.MetaDataChain = MetaDataChain;
        }
        
        /// <summary>
        /// Gets or Sets SingleProofChain
        /// </summary>
        [DataMember(Name="singleProofChain", EmitDefaultValue=false)]
        public CommittedChain SingleProofChain { get; set; }

        /// <summary>
        /// Gets or Sets SettingsChain
        /// </summary>
        [DataMember(Name="settingsChain", EmitDefaultValue=false)]
        public CommittedChain SettingsChain { get; set; }

        /// <summary>
        /// Gets or Sets ChainSettings
        /// </summary>
        [DataMember(Name="chainSettings", EmitDefaultValue=false)]
        public ChainSettings ChainSettings { get; set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; private set; }

        /// <summary>
        /// Gets or Sets ChainConfiguration
        /// </summary>
        [DataMember(Name="chainConfiguration", EmitDefaultValue=false)]
        public ChainConfiguration ChainConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets ValidFrom
        /// </summary>
        [DataMember(Name="validFrom", EmitDefaultValue=false)]
        public DateTime? ValidFrom { get; private set; }

        /// <summary>
        /// Gets or Sets MetaDataChain
        /// </summary>
        [DataMember(Name="metaDataChain", EmitDefaultValue=false)]
        public CommittedChain MetaDataChain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredSettings {\n");
            sb.Append("  SingleProofChain: ").Append(SingleProofChain).Append("\n");
            sb.Append("  SettingsChain: ").Append(SettingsChain).Append("\n");
            sb.Append("  ChainSettings: ").Append(ChainSettings).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  ChainConfiguration: ").Append(ChainConfiguration).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
            sb.Append("  MetaDataChain: ").Append(MetaDataChain).Append("\n");
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
            return this.Equals(obj as StoredSettings);
        }

        /// <summary>
        /// Returns true if StoredSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of StoredSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StoredSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SingleProofChain == other.SingleProofChain ||
                    this.SingleProofChain != null &&
                    this.SingleProofChain.Equals(other.SingleProofChain)
                ) && 
                (
                    this.SettingsChain == other.SettingsChain ||
                    this.SettingsChain != null &&
                    this.SettingsChain.Equals(other.SettingsChain)
                ) && 
                (
                    this.ChainSettings == other.ChainSettings ||
                    this.ChainSettings != null &&
                    this.ChainSettings.Equals(other.ChainSettings)
                ) && 
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) && 
                (
                    this.ChainConfiguration == other.ChainConfiguration ||
                    this.ChainConfiguration != null &&
                    this.ChainConfiguration.Equals(other.ChainConfiguration)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ValidFrom == other.ValidFrom ||
                    this.ValidFrom != null &&
                    this.ValidFrom.Equals(other.ValidFrom)
                ) && 
                (
                    this.MetaDataChain == other.MetaDataChain ||
                    this.MetaDataChain != null &&
                    this.MetaDataChain.Equals(other.MetaDataChain)
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
                if (this.SingleProofChain != null)
                    hash = hash * 59 + this.SingleProofChain.GetHashCode();
                if (this.SettingsChain != null)
                    hash = hash * 59 + this.SettingsChain.GetHashCode();
                if (this.ChainSettings != null)
                    hash = hash * 59 + this.ChainSettings.GetHashCode();
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                if (this.ChainConfiguration != null)
                    hash = hash * 59 + this.ChainConfiguration.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ValidFrom != null)
                    hash = hash * 59 + this.ValidFrom.GetHashCode();
                if (this.MetaDataChain != null)
                    hash = hash * 59 + this.MetaDataChain.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
