/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
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
    /// Committed Chain response
    /// </summary>
    [DataContract]
    public partial class CreateChainResponse :  IEquatable<CreateChainResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChainResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateChainResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChainResponse" /> class.
        /// </summary>
        /// <param name="SettingsChain">SettingsChain (required).</param>
        /// <param name="ChainRequest">ChainRequest (required).</param>
        /// <param name="ProofChain">ProofChain (required).</param>
        public CreateChainResponse(CommittedChain SettingsChain = default(CommittedChain), CreateChainRequest ChainRequest = default(CreateChainRequest), CommittedChain ProofChain = default(CommittedChain))
        {
            // to ensure "SettingsChain" is required (not null)
            if (SettingsChain == null)
            {
                throw new InvalidDataException("SettingsChain is a required property for CreateChainResponse and cannot be null");
            }
            else
            {
                this.SettingsChain = SettingsChain;
            }
            // to ensure "ChainRequest" is required (not null)
            if (ChainRequest == null)
            {
                throw new InvalidDataException("ChainRequest is a required property for CreateChainResponse and cannot be null");
            }
            else
            {
                this.ChainRequest = ChainRequest;
            }
            // to ensure "ProofChain" is required (not null)
            if (ProofChain == null)
            {
                throw new InvalidDataException("ProofChain is a required property for CreateChainResponse and cannot be null");
            }
            else
            {
                this.ProofChain = ProofChain;
            }
        }
        
        /// <summary>
        /// Gets or Sets SettingsChain
        /// </summary>
        [DataMember(Name="settingsChain", EmitDefaultValue=false)]
        public CommittedChain SettingsChain { get; set; }

        /// <summary>
        /// Gets or Sets ChainRequest
        /// </summary>
        [DataMember(Name="chainRequest", EmitDefaultValue=false)]
        public CreateChainRequest ChainRequest { get; set; }

        /// <summary>
        /// Gets or Sets ProofChain
        /// </summary>
        [DataMember(Name="proofChain", EmitDefaultValue=false)]
        public CommittedChain ProofChain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateChainResponse {\n");
            sb.Append("  SettingsChain: ").Append(SettingsChain).Append("\n");
            sb.Append("  ChainRequest: ").Append(ChainRequest).Append("\n");
            sb.Append("  ProofChain: ").Append(ProofChain).Append("\n");
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
            return this.Equals(obj as CreateChainResponse);
        }

        /// <summary>
        /// Returns true if CreateChainResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of CreateChainResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateChainResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SettingsChain == other.SettingsChain ||
                    this.SettingsChain != null &&
                    this.SettingsChain.Equals(other.SettingsChain)
                ) && 
                (
                    this.ChainRequest == other.ChainRequest ||
                    this.ChainRequest != null &&
                    this.ChainRequest.Equals(other.ChainRequest)
                ) && 
                (
                    this.ProofChain == other.ProofChain ||
                    this.ProofChain != null &&
                    this.ProofChain.Equals(other.ProofChain)
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
                if (this.SettingsChain != null)
                    hash = hash * 59 + this.SettingsChain.GetHashCode();
                if (this.ChainRequest != null)
                    hash = hash * 59 + this.ChainRequest.GetHashCode();
                if (this.ProofChain != null)
                    hash = hash * 59 + this.ProofChain.GetHashCode();
                return hash;
            }
        }

    }

}