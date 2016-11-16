/*
 * Blockchain Proof
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


package com.sphereon.sdk.blockchain.proof.model;

import com.google.gson.annotations.SerializedName;
import com.sphereon.sdk.blockchain.proof.model.CommittedChain;
import com.sphereon.sdk.blockchain.proof.model.Settings;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

import java.time.OffsetDateTime;
import java.util.Objects;

/**
 * The stored settings from the settings chain
 */
@ApiModel(description = "The stored settings from the settings chain")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-11-13T22:36:12.871+01:00")
public class StoredSettings {
  @SerializedName("settings")
  private Settings settings = null;

  @SerializedName("settingsChain")
  private CommittedChain settingsChain = null;

  @SerializedName("signature")
  private byte[] signature = null;

  @SerializedName("validFrom")
  private OffsetDateTime validFrom = null;

  public StoredSettings settings(Settings settings) {
    this.settings = settings;
    return this;
  }

   /**
   * Get settings
   * @return settings
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public Settings getSettings() {
    return settings;
  }

  public void setSettings(Settings settings) {
    this.settings = settings;
  }

  public StoredSettings settingsChain(CommittedChain settingsChain) {
    this.settingsChain = settingsChain;
    return this;
  }

   /**
   * Get settingsChain
   * @return settingsChain
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public CommittedChain getSettingsChain() {
    return settingsChain;
  }

  public void setSettingsChain(CommittedChain settingsChain) {
    this.settingsChain = settingsChain;
  }

  public StoredSettings signature(byte[] signature) {
    this.signature = signature;
    return this;
  }

   /**
   * Get signature
   * @return signature
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public byte[] getSignature() {
    return signature;
  }

  public void setSignature(byte[] signature) {
    this.signature = signature;
  }

  public StoredSettings validFrom(OffsetDateTime validFrom) {
    this.validFrom = validFrom;
    return this;
  }

   /**
   * Get validFrom
   * @return validFrom
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public OffsetDateTime getValidFrom() {
    return validFrom;
  }

  public void setValidFrom(OffsetDateTime validFrom) {
    this.validFrom = validFrom;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    StoredSettings storedSettings = (StoredSettings) o;
    return Objects.equals(this.settings, storedSettings.settings) &&
        Objects.equals(this.settingsChain, storedSettings.settingsChain) &&
        Objects.equals(this.signature, storedSettings.signature) &&
        Objects.equals(this.validFrom, storedSettings.validFrom);
  }

  @Override
  public int hashCode() {
    return Objects.hash(settings, settingsChain, signature, validFrom);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StoredSettings {\n");
    
    sb.append("    settings: ").append(toIndentedString(settings)).append("\n");
    sb.append("    settingsChain: ").append(toIndentedString(settingsChain)).append("\n");
    sb.append("    signature: ").append(toIndentedString(signature)).append("\n");
    sb.append("    validFrom: ").append(toIndentedString(validFrom)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }
  
}

