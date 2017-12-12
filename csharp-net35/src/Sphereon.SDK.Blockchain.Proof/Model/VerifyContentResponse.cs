/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9.0-SNAPSHOT
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
    /// Verify Content response
    /// </summary>
    [DataContract]
    public partial class VerifyContentResponse :  IEquatable<VerifyContentResponse>
    {
        /// <summary>
        /// Gets or Sets RegistrationState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RegistrationStateEnum
        {
            
            /// <summary>
            /// Enum PENDING for "PENDING"
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING,
            
            /// <summary>
            /// Enum REGISTERED for "REGISTERED"
            /// </summary>
            [EnumMember(Value = "REGISTERED")]
            REGISTERED,
            
            /// <summary>
            /// Enum NOTREGISTERED for "NOT_REGISTERED"
            /// </summary>
            [EnumMember(Value = "NOT_REGISTERED")]
            NOTREGISTERED
        }

        /// <summary>
        /// Gets or Sets RegistrationState
        /// </summary>
        [DataMember(Name="registrationState", EmitDefaultValue=false)]
        public RegistrationStateEnum? RegistrationState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyContentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyContentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyContentResponse" /> class.
        /// </summary>
        /// <param name="RegistrationTime">RegistrationTime.</param>
        /// <param name="ContextName">ContextName (required).</param>
        /// <param name="RequestId">RequestId.</param>
        /// <param name="ContentId">ContentId (required).</param>
        /// <param name="ProofChain">ProofChain (required).</param>
        /// <param name="RegistrationState">RegistrationState (required).</param>
        /// <param name="FileChain">FileChain (required).</param>
        public VerifyContentResponse(DateTime? RegistrationTime = default(DateTime?), string ContextName = default(string), string RequestId = default(string), string ContentId = default(string), CommittedChain ProofChain = default(CommittedChain), RegistrationStateEnum? RegistrationState = default(RegistrationStateEnum?), CommittedChain FileChain = default(CommittedChain))
        {
            // to ensure "ContextName" is required (not null)
            if (ContextName == null)
            {
                throw new InvalidDataException("ContextName is a required property for VerifyContentResponse and cannot be null");
            }
            else
            {
                this.ContextName = ContextName;
            }
            // to ensure "ContentId" is required (not null)
            if (ContentId == null)
            {
                throw new InvalidDataException("ContentId is a required property for VerifyContentResponse and cannot be null");
            }
            else
            {
                this.ContentId = ContentId;
            }
            // to ensure "ProofChain" is required (not null)
            if (ProofChain == null)
            {
                throw new InvalidDataException("ProofChain is a required property for VerifyContentResponse and cannot be null");
            }
            else
            {
                this.ProofChain = ProofChain;
            }
            // to ensure "RegistrationState" is required (not null)
            if (RegistrationState == null)
            {
                throw new InvalidDataException("RegistrationState is a required property for VerifyContentResponse and cannot be null");
            }
            else
            {
                this.RegistrationState = RegistrationState;
            }
            // to ensure "FileChain" is required (not null)
            if (FileChain == null)
            {
                throw new InvalidDataException("FileChain is a required property for VerifyContentResponse and cannot be null");
            }
            else
            {
                this.FileChain = FileChain;
            }
            this.RegistrationTime = RegistrationTime;
            this.RequestId = RequestId;
        }
        
        /// <summary>
        /// Gets or Sets RegistrationTime
        /// </summary>
        [DataMember(Name="registrationTime", EmitDefaultValue=false)]
        public DateTime? RegistrationTime { get; set; }

        /// <summary>
        /// Gets or Sets ContextName
        /// </summary>
        [DataMember(Name="contextName", EmitDefaultValue=false)]
        public string ContextName { get; set; }

        /// <summary>
        /// Gets or Sets RequestId
        /// </summary>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Gets or Sets ContentId
        /// </summary>
        [DataMember(Name="contentId", EmitDefaultValue=false)]
        public string ContentId { get; set; }

        /// <summary>
        /// Gets or Sets ProofChain
        /// </summary>
        [DataMember(Name="proofChain", EmitDefaultValue=false)]
        public CommittedChain ProofChain { get; set; }


        /// <summary>
        /// Gets or Sets FileChain
        /// </summary>
        [DataMember(Name="fileChain", EmitDefaultValue=false)]
        public CommittedChain FileChain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyContentResponse {\n");
            sb.Append("  RegistrationTime: ").Append(RegistrationTime).Append("\n");
            sb.Append("  ContextName: ").Append(ContextName).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ContentId: ").Append(ContentId).Append("\n");
            sb.Append("  ProofChain: ").Append(ProofChain).Append("\n");
            sb.Append("  RegistrationState: ").Append(RegistrationState).Append("\n");
            sb.Append("  FileChain: ").Append(FileChain).Append("\n");
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
            return this.Equals(obj as VerifyContentResponse);
        }

        /// <summary>
        /// Returns true if VerifyContentResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of VerifyContentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyContentResponse other)
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
                    this.ContextName == other.ContextName ||
                    this.ContextName != null &&
                    this.ContextName.Equals(other.ContextName)
                ) && 
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) && 
                (
                    this.ContentId == other.ContentId ||
                    this.ContentId != null &&
                    this.ContentId.Equals(other.ContentId)
                ) && 
                (
                    this.ProofChain == other.ProofChain ||
                    this.ProofChain != null &&
                    this.ProofChain.Equals(other.ProofChain)
                ) && 
                (
                    this.RegistrationState == other.RegistrationState ||
                    this.RegistrationState != null &&
                    this.RegistrationState.Equals(other.RegistrationState)
                ) && 
                (
                    this.FileChain == other.FileChain ||
                    this.FileChain != null &&
                    this.FileChain.Equals(other.FileChain)
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
                if (this.ContextName != null)
                    hash = hash * 59 + this.ContextName.GetHashCode();
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                if (this.ContentId != null)
                    hash = hash * 59 + this.ContentId.GetHashCode();
                if (this.ProofChain != null)
                    hash = hash * 59 + this.ProofChain.GetHashCode();
                if (this.RegistrationState != null)
                    hash = hash * 59 + this.RegistrationState.GetHashCode();
                if (this.FileChain != null)
                    hash = hash * 59 + this.FileChain.GetHashCode();
                return hash;
            }
        }

    }

}
