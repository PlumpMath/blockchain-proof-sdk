/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Sphereon.SDK.Blockchain.Proof.Model
{
    /// <summary>
    /// Existence Settings. Normally you only supply them once during chain creation or during a settings update. You can also supply them during a content request, but then it is up to you to also supply the correct setting during verify
    /// </summary>
    [DataContract]
    public partial class Settings :  IEquatable<Settings>
    {
        /// <summary>
        /// The settings version (only 1 for now)
        /// </summary>
        /// <value>The settings version (only 1 for now)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersionEnum
        {
            
            /// <summary>
            /// Enum NUMBER_1 for 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 1
        }

        /// <summary>
        /// The hashing method used (CLIENT) or to use (SERVER) for the content
        /// </summary>
        /// <value>The hashing method used (CLIENT) or to use (SERVER) for the content</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HashAlgorithmEnum
        {
            
            /// <summary>
            /// Enum PLAIN for "PLAIN"
            /// </summary>
            [EnumMember(Value = "PLAIN")]
            PLAIN,
            
            /// <summary>
            /// Enum SHA256 for "SHA_256"
            /// </summary>
            [EnumMember(Value = "SHA_256")]
            SHA256,
            
            /// <summary>
            /// Enum SHA512 for "SHA_512"
            /// </summary>
            [EnumMember(Value = "SHA_512")]
            SHA512
        }

        /// <summary>
        /// The settings version (only 1 for now)
        /// </summary>
        /// <value>The settings version (only 1 for now)</value>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public VersionEnum? Version { get; set; }
        /// <summary>
        /// The hashing method used (CLIENT) or to use (SERVER) for the content
        /// </summary>
        /// <value>The hashing method used (CLIENT) or to use (SERVER) for the content</value>
        [DataMember(Name="hashAlgorithm", EmitDefaultValue=false)]
        public HashAlgorithmEnum? HashAlgorithm { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Settings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Settings" /> class.
        /// </summary>
        /// <param name="Version">The settings version (only 1 for now) (required).</param>
        /// <param name="HashAlgorithm">The hashing method used (CLIENT) or to use (SERVER) for the content.</param>
        public Settings(VersionEnum? Version = null, HashAlgorithmEnum? HashAlgorithm = null)
        {
            // to ensure "Version" is required (not null)
            if (Version == null)
            {
                throw new InvalidDataException("Version is a required property for Settings and cannot be null");
            }
            else
            {
                this.Version = Version;
            }
            this.HashAlgorithm = HashAlgorithm;
        }
        
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Settings {\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  HashAlgorithm: ").Append(HashAlgorithm).Append("\n");
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
            return this.Equals(obj as Settings);
        }

        /// <summary>
        /// Returns true if Settings instances are equal
        /// </summary>
        /// <param name="other">Instance of Settings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Settings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Version == other.Version ||
                    this.Version != null &&
                    this.Version.Equals(other.Version)
                ) && 
                (
                    this.HashAlgorithm == other.HashAlgorithm ||
                    this.HashAlgorithm != null &&
                    this.HashAlgorithm.Equals(other.HashAlgorithm)
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
                if (this.Version != null)
                    hash = hash * 59 + this.Version.GetHashCode();
                if (this.HashAlgorithm != null)
                    hash = hash * 59 + this.HashAlgorithm.GetHashCode();
                return hash;
            }
        }
    }

}
