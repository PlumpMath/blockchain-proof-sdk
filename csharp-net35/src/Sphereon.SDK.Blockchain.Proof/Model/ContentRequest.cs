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
    /// Content existence request
    /// </summary>
    [DataContract]
    public partial class ContentRequest :  IEquatable<ContentRequest>
    {
        /// <summary>
        /// When CLIENT is supplied the content should already have been hashed by you. When SERVER is supplied we will hash the content
        /// </summary>
        /// <value>When CLIENT is supplied the content should already have been hashed by you. When SERVER is supplied we will hash the content</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HashProviderEnum
        {
            
            /// <summary>
            /// Enum SERVER for "SERVER"
            /// </summary>
            [EnumMember(Value = "SERVER")]
            SERVER,
            
            /// <summary>
            /// Enum CLIENT for "CLIENT"
            /// </summary>
            [EnumMember(Value = "CLIENT")]
            CLIENT
        }

        /// <summary>
        /// When CLIENT is supplied the content should already have been hashed by you. When SERVER is supplied we will hash the content
        /// </summary>
        /// <value>When CLIENT is supplied the content should already have been hashed by you. When SERVER is supplied we will hash the content</value>
        [DataMember(Name="hashProvider", EmitDefaultValue=false)]
        public HashProviderEnum? HashProvider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContentRequest" /> class.
        /// </summary>
        /// <param name="HashProvider">When CLIENT is supplied the content should already have been hashed by you. When SERVER is supplied we will hash the content (required).</param>
        /// <param name="RequestId">An id that will be returned in the response..</param>
        /// <param name="Content">The content to register. (required).</param>
        public ContentRequest(HashProviderEnum? HashProvider = default(HashProviderEnum?), string RequestId = default(string), byte[] Content = default(byte[]))
        {
            // to ensure "HashProvider" is required (not null)
            if (HashProvider == null)
            {
                throw new InvalidDataException("HashProvider is a required property for ContentRequest and cannot be null");
            }
            else
            {
                this.HashProvider = HashProvider;
            }
            // to ensure "Content" is required (not null)
            if (Content == null)
            {
                throw new InvalidDataException("Content is a required property for ContentRequest and cannot be null");
            }
            else
            {
                this.Content = Content;
            }
            this.RequestId = RequestId;
        }
        

        /// <summary>
        /// An id that will be returned in the response.
        /// </summary>
        /// <value>An id that will be returned in the response.</value>
        [DataMember(Name="requestId", EmitDefaultValue=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The content to register.
        /// </summary>
        /// <value>The content to register.</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContentRequest {\n");
            sb.Append("  HashProvider: ").Append(HashProvider).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(obj as ContentRequest);
        }

        /// <summary>
        /// Returns true if ContentRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ContentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContentRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HashProvider == other.HashProvider ||
                    this.HashProvider != null &&
                    this.HashProvider.Equals(other.HashProvider)
                ) && 
                (
                    this.RequestId == other.RequestId ||
                    this.RequestId != null &&
                    this.RequestId.Equals(other.RequestId)
                ) && 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
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
                if (this.HashProvider != null)
                    hash = hash * 59 + this.HashProvider.GetHashCode();
                if (this.RequestId != null)
                    hash = hash * 59 + this.RequestId.GetHashCode();
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                return hash;
            }
        }

    }

}
