/* 
 * Blockchain Proof
 *
 * With the Blockchain Proof API it is easy to prove or disprove existence of data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin), Multichain or Ethereum blockchain by means of our generic blockchain API.    The flow is generally as follows:  1. Make sure a configuration is present  2. Register content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing  3. Verify content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing. You will get back whether the content has been registered previously or not    Full API Documentation: https://docs.sphereon.com/api/blockchain-proof/0.9/html  Interactive testing: A web based test console is available in the Sphereon API Store at https://store.sphereon.com
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
    /// Location record of data stream
    /// </summary>
    [DataContract]
    public partial class StreamLocation :  IEquatable<StreamLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamLocation" /> class.
        /// </summary>
        /// <param name="FolderPath">FolderPath.</param>
        /// <param name="Filename">Filename.</param>
        /// <param name="ContainerId">ContainerId.</param>
        /// <param name="OriginalFilename">OriginalFilename.</param>
        public StreamLocation(string FolderPath = default(string), string Filename = default(string), string ContainerId = default(string), string OriginalFilename = default(string))
        {
            this.FolderPath = FolderPath;
            this.Filename = Filename;
            this.ContainerId = ContainerId;
            this.OriginalFilename = OriginalFilename;
        }
        
        /// <summary>
        /// Gets or Sets FolderPath
        /// </summary>
        [DataMember(Name="folderPath", EmitDefaultValue=false)]
        public string FolderPath { get; set; }

        /// <summary>
        /// Gets or Sets Filename
        /// </summary>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or Sets ContainerId
        /// </summary>
        [DataMember(Name="containerId", EmitDefaultValue=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// Gets or Sets OriginalFilename
        /// </summary>
        [DataMember(Name="originalFilename", EmitDefaultValue=false)]
        public string OriginalFilename { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StreamLocation {\n");
            sb.Append("  FolderPath: ").Append(FolderPath).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContainerId: ").Append(ContainerId).Append("\n");
            sb.Append("  OriginalFilename: ").Append(OriginalFilename).Append("\n");
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
            return this.Equals(obj as StreamLocation);
        }

        /// <summary>
        /// Returns true if StreamLocation instances are equal
        /// </summary>
        /// <param name="other">Instance of StreamLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StreamLocation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FolderPath == other.FolderPath ||
                    this.FolderPath != null &&
                    this.FolderPath.Equals(other.FolderPath)
                ) && 
                (
                    this.Filename == other.Filename ||
                    this.Filename != null &&
                    this.Filename.Equals(other.Filename)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.ContainerId == other.ContainerId ||
                    this.ContainerId != null &&
                    this.ContainerId.Equals(other.ContainerId)
                ) && 
                (
                    this.OriginalFilename == other.OriginalFilename ||
                    this.OriginalFilename != null &&
                    this.OriginalFilename.Equals(other.OriginalFilename)
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
                if (this.FolderPath != null)
                    hash = hash * 59 + this.FolderPath.GetHashCode();
                if (this.Filename != null)
                    hash = hash * 59 + this.Filename.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.ContainerId != null)
                    hash = hash * 59 + this.ContainerId.GetHashCode();
                if (this.OriginalFilename != null)
                    hash = hash * 59 + this.OriginalFilename.GetHashCode();
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
