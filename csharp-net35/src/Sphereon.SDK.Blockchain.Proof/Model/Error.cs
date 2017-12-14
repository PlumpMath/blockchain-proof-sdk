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
    /// An error
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>
    {
        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LevelEnum
        {
            
            /// <summary>
            /// Enum INFO for "INFO"
            /// </summary>
            [EnumMember(Value = "INFO")]
            INFO,
            
            /// <summary>
            /// Enum WARNING for "WARNING"
            /// </summary>
            [EnumMember(Value = "WARNING")]
            WARNING,
            
            /// <summary>
            /// Enum FATAL for "FATAL"
            /// </summary>
            [EnumMember(Value = "FATAL")]
            FATAL
        }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public LevelEnum? Level { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Error() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        /// <param name="Code">Code (required).</param>
        /// <param name="Level">Level (required).</param>
        /// <param name="Cause">Cause.</param>
        /// <param name="Message">Message (required).</param>
        public Error(string Code = default(string), LevelEnum? Level = default(LevelEnum?), Error Cause = default(Error), string Message = default(string))
        {
            // to ensure "Code" is required (not null)
            if (Code == null)
            {
                throw new InvalidDataException("Code is a required property for Error and cannot be null");
            }
            else
            {
                this.Code = Code;
            }
            // to ensure "Level" is required (not null)
            if (Level == null)
            {
                throw new InvalidDataException("Level is a required property for Error and cannot be null");
            }
            else
            {
                this.Level = Level;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for Error and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            this.Cause = Cause;
        }
        
        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }


        /// <summary>
        /// Gets or Sets Cause
        /// </summary>
        [DataMember(Name="cause", EmitDefaultValue=false)]
        public Error Cause { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  Cause: ").Append(Cause).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(obj as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="other">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Code == other.Code ||
                    this.Code != null &&
                    this.Code.Equals(other.Code)
                ) && 
                (
                    this.Level == other.Level ||
                    this.Level != null &&
                    this.Level.Equals(other.Level)
                ) && 
                (
                    this.Cause == other.Cause ||
                    this.Cause != null &&
                    this.Cause.Equals(other.Cause)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
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
                if (this.Code != null)
                    hash = hash * 59 + this.Code.GetHashCode();
                if (this.Level != null)
                    hash = hash * 59 + this.Level.GetHashCode();
                if (this.Cause != null)
                    hash = hash * 59 + this.Cause.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                return hash;
            }
        }

    }

}