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
    /// Commited Entry
    /// </summary>
    [DataContract]
    public partial class CommittedEntry :  IEquatable<CommittedEntry>
    {
        /// <summary>
        /// Gets or Sets RegistrationState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RegistrationStateEnum
        {
            
            /// <summary>
            /// Enum NOTREGISTERED for "NOT_REGISTERED"
            /// </summary>
            [EnumMember(Value = "NOT_REGISTERED")]
            NOTREGISTERED,
            
            /// <summary>
            /// Enum PENDING for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING,
            
            /// <summary>
            /// Enum REGISTERED for "REGISTERED"
            /// </summary>
            [EnumMember(Value = "REGISTERED")]
            REGISTERED
        }

        /// <summary>
        /// Gets or Sets RegistrationState
        /// </summary>
        [DataMember(Name="registrationState", EmitDefaultValue=false)]
        public RegistrationStateEnum? RegistrationState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommittedEntry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommittedEntry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommittedEntry" /> class.
        /// </summary>
        /// <param name="RegistrationTime">RegistrationTime.</param>
        /// <param name="Context">Context.</param>
        /// <param name="RegistrationState">RegistrationState (required).</param>
        /// <param name="EntryId">EntryId (required).</param>
        public CommittedEntry(DateTime? RegistrationTime = default(DateTime?), string Context = default(string), RegistrationStateEnum? RegistrationState = default(RegistrationStateEnum?), string EntryId = default(string))
        {
            // to ensure "RegistrationState" is required (not null)
            if (RegistrationState == null)
            {
                throw new InvalidDataException("RegistrationState is a required property for CommittedEntry and cannot be null");
            }
            else
            {
                this.RegistrationState = RegistrationState;
            }
            // to ensure "EntryId" is required (not null)
            if (EntryId == null)
            {
                throw new InvalidDataException("EntryId is a required property for CommittedEntry and cannot be null");
            }
            else
            {
                this.EntryId = EntryId;
            }
            this.RegistrationTime = RegistrationTime;
            this.Context = Context;
        }
        
        /// <summary>
        /// Gets or Sets RegistrationTime
        /// </summary>
        [DataMember(Name="registrationTime", EmitDefaultValue=false)]
        public DateTime? RegistrationTime { get; set; }

        /// <summary>
        /// Chain ID
        /// </summary>
        /// <value>Chain ID</value>
        [DataMember(Name="chainId", EmitDefaultValue=false)]
        public string ChainId { get; private set; }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }


        /// <summary>
        /// Gets or Sets EntryId
        /// </summary>
        [DataMember(Name="entryId", EmitDefaultValue=false)]
        public string EntryId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommittedEntry {\n");
            sb.Append("  RegistrationTime: ").Append(RegistrationTime).Append("\n");
            sb.Append("  ChainId: ").Append(ChainId).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  RegistrationState: ").Append(RegistrationState).Append("\n");
            sb.Append("  EntryId: ").Append(EntryId).Append("\n");
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
            return this.Equals(obj as CommittedEntry);
        }

        /// <summary>
        /// Returns true if CommittedEntry instances are equal
        /// </summary>
        /// <param name="other">Instance of CommittedEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommittedEntry other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.RegistrationTime == other.RegistrationTime ||
                    this.RegistrationTime != null &&
                    this.RegistrationTime.Equals(other.RegistrationTime)
                ) && 
                (
                    this.ChainId == other.ChainId ||
                    this.ChainId != null &&
                    this.ChainId.Equals(other.ChainId)
                ) && 
                (
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) && 
                (
                    this.RegistrationState == other.RegistrationState ||
                    this.RegistrationState != null &&
                    this.RegistrationState.Equals(other.RegistrationState)
                ) && 
                (
                    this.EntryId == other.EntryId ||
                    this.EntryId != null &&
                    this.EntryId.Equals(other.EntryId)
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
                if (this.RegistrationTime != null)
                    hash = hash * 59 + this.RegistrationTime.GetHashCode();
                if (this.ChainId != null)
                    hash = hash * 59 + this.ChainId.GetHashCode();
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                if (this.RegistrationState != null)
                    hash = hash * 59 + this.RegistrationState.GetHashCode();
                if (this.EntryId != null)
                    hash = hash * 59 + this.EntryId.GetHashCode();
                return hash;
            }
        }

    }

}