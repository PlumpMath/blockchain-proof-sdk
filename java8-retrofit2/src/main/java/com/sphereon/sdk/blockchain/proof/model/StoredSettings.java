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
 */


package com.sphereon.sdk.blockchain.proof.model;

import java.util.Objects;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import com.sphereon.sdk.blockchain.proof.model.CommittedChain;
import com.sphereon.sdk.blockchain.proof.model.Settings;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.OffsetDateTime;

/**
 * The stored settings from the settings chain
 */
@ApiModel(description = "The stored settings from the settings chain")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-11-13T14:20:54.641+01:00")
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
  @ApiModelProperty(required = true, value = "")
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
  @ApiModelProperty(required = true, value = "")
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
  @ApiModelProperty(required = true, value = "")
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
  @ApiModelProperty(required = true, value = "")
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

