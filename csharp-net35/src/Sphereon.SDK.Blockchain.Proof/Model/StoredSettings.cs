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
    /// The stored settings from the settings chain
    /// </summary>
    [DataContract]
    public partial class StoredSettings :  IEquatable<StoredSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StoredSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StoredSettings" /> class.
        /// </summary>
        /// <param name="Settings">Settings (required).</param>
        /// <param name="SettingsChain">SettingsChain (required).</param>
        /// <param name="Signature">Signature (required).</param>
        /// <param name="ValidFrom">ValidFrom (required).</param>
        public StoredSettings(Settings Settings = default(Settings), CommittedChain SettingsChain = default(CommittedChain), byte[] Signature = default(byte[]), DateTime? ValidFrom = default(DateTime?))
        {
            // to ensure "Settings" is required (not null)
            if (Settings == null)
            {
                throw new InvalidDataException("Settings is a required property for StoredSettings and cannot be null");
            }
            else
            {
                this.Settings = Settings;
            }
            // to ensure "SettingsChain" is required (not null)
            if (SettingsChain == null)
            {
                throw new InvalidDataException("SettingsChain is a required property for StoredSettings and cannot be null");
            }
            else
            {
                this.SettingsChain = SettingsChain;
            }
            // to ensure "Signature" is required (not null)
            if (Signature == null)
            {
                throw new InvalidDataException("Signature is a required property for StoredSettings and cannot be null");
            }
            else
            {
                this.Signature = Signature;
            }
            // to ensure "ValidFrom" is required (not null)
            if (ValidFrom == null)
            {
                throw new InvalidDataException("ValidFrom is a required property for StoredSettings and cannot be null");
            }
            else
            {
                this.ValidFrom = ValidFrom;
            }
        }
        
        /// <summary>
        /// Gets or Sets Settings
        /// </summary>
        [DataMember(Name="settings", EmitDefaultValue=false)]
        public Settings Settings { get; set; }

        /// <summary>
        /// Gets or Sets SettingsChain
        /// </summary>
        [DataMember(Name="settingsChain", EmitDefaultValue=false)]
        public CommittedChain SettingsChain { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name="signature", EmitDefaultValue=false)]
        public byte[] Signature { get; set; }

        /// <summary>
        /// Gets or Sets ValidFrom
        /// </summary>
        [DataMember(Name="validFrom", EmitDefaultValue=false)]
        public DateTime? ValidFrom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StoredSettings {\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  SettingsChain: ").Append(SettingsChain).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  ValidFrom: ").Append(ValidFrom).Append("\n");
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
                    this.Settings == other.Settings ||
                    this.Settings != null &&
                    this.Settings.Equals(other.Settings)
                ) && 
                (
                    this.SettingsChain == other.SettingsChain ||
                    this.SettingsChain != null &&
                    this.SettingsChain.Equals(other.SettingsChain)
                ) && 
                (
                    this.Signature == other.Signature ||
                    this.Signature != null &&
                    this.Signature.Equals(other.Signature)
                ) && 
                (
                    this.ValidFrom == other.ValidFrom ||
                    this.ValidFrom != null &&
                    this.ValidFrom.Equals(other.ValidFrom)
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
                if (this.Settings != null)
                    hash = hash * 59 + this.Settings.GetHashCode();
                if (this.SettingsChain != null)
                    hash = hash * 59 + this.SettingsChain.GetHashCode();
                if (this.Signature != null)
                    hash = hash * 59 + this.Signature.GetHashCode();
                if (this.ValidFrom != null)
                    hash = hash * 59 + this.ValidFrom.GetHashCode();
                return hash;
            }
        }

    }

}
