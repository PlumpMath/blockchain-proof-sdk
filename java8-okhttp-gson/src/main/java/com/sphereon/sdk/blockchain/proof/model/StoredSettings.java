/*
 * Blockchain Proof
 * <b>With the Blockchain Proof API it is easy to prove or disprove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin), Multichain or Ethereum blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a configuration is present  2. Register content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing  3. Verify content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing. You will get back whether the content has been registered previously or not      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9
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
import com.sphereon.sdk.blockchain.proof.model.ChainConfiguration;
import com.sphereon.sdk.blockchain.proof.model.ChainSettings;
import com.sphereon.sdk.blockchain.proof.model.CommittedChain;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.OffsetDateTime;

/**
 * The stored chainSettings from the chainSettings chain
 */
@ApiModel(description = "The stored chainSettings from the chainSettings chain")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-12-14T13:28:04.893+01:00")
public class StoredSettings {
  @SerializedName("settingsChain")
  private CommittedChain settingsChain = null;

  @SerializedName("chainSettings")
  private ChainSettings chainSettings = null;

  @SerializedName("context")
  private String context = null;

  @SerializedName("chainConfiguration")
  private ChainConfiguration chainConfiguration = null;

  @SerializedName("validFrom")
  private OffsetDateTime validFrom = null;

  @SerializedName("metaDataChain")
  private CommittedChain metaDataChain = null;

  @SerializedName("proofChain")
  private CommittedChain proofChain = null;

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

  public StoredSettings chainSettings(ChainSettings chainSettings) {
    this.chainSettings = chainSettings;
    return this;
  }

   /**
   * Get chainSettings
   * @return chainSettings
  **/
  @ApiModelProperty(required = true, value = "")
  public ChainSettings getChainSettings() {
    return chainSettings;
  }

  public void setChainSettings(ChainSettings chainSettings) {
    this.chainSettings = chainSettings;
  }

   /**
   * Get context
   * @return context
  **/
  @ApiModelProperty(required = true, value = "")
  public String getContext() {
    return context;
  }

  public StoredSettings chainConfiguration(ChainConfiguration chainConfiguration) {
    this.chainConfiguration = chainConfiguration;
    return this;
  }

   /**
   * Get chainConfiguration
   * @return chainConfiguration
  **/
  @ApiModelProperty(required = true, value = "")
  public ChainConfiguration getChainConfiguration() {
    return chainConfiguration;
  }

  public void setChainConfiguration(ChainConfiguration chainConfiguration) {
    this.chainConfiguration = chainConfiguration;
  }

   /**
   * Get validFrom
   * @return validFrom
  **/
  @ApiModelProperty(required = true, value = "")
  public OffsetDateTime getValidFrom() {
    return validFrom;
  }

  public StoredSettings metaDataChain(CommittedChain metaDataChain) {
    this.metaDataChain = metaDataChain;
    return this;
  }

   /**
   * Get metaDataChain
   * @return metaDataChain
  **/
  @ApiModelProperty(value = "")
  public CommittedChain getMetaDataChain() {
    return metaDataChain;
  }

  public void setMetaDataChain(CommittedChain metaDataChain) {
    this.metaDataChain = metaDataChain;
  }

  public StoredSettings proofChain(CommittedChain proofChain) {
    this.proofChain = proofChain;
    return this;
  }

   /**
   * Get proofChain
   * @return proofChain
  **/
  @ApiModelProperty(value = "")
  public CommittedChain getProofChain() {
    return proofChain;
  }

  public void setProofChain(CommittedChain proofChain) {
    this.proofChain = proofChain;
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
    return Objects.equals(this.settingsChain, storedSettings.settingsChain) &&
        Objects.equals(this.chainSettings, storedSettings.chainSettings) &&
        Objects.equals(this.context, storedSettings.context) &&
        Objects.equals(this.chainConfiguration, storedSettings.chainConfiguration) &&
        Objects.equals(this.validFrom, storedSettings.validFrom) &&
        Objects.equals(this.metaDataChain, storedSettings.metaDataChain) &&
        Objects.equals(this.proofChain, storedSettings.proofChain);
  }

  @Override
  public int hashCode() {
    return Objects.hash(settingsChain, chainSettings, context, chainConfiguration, validFrom, metaDataChain, proofChain);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class StoredSettings {\n");
    
    sb.append("    settingsChain: ").append(toIndentedString(settingsChain)).append("\n");
    sb.append("    chainSettings: ").append(toIndentedString(chainSettings)).append("\n");
    sb.append("    context: ").append(toIndentedString(context)).append("\n");
    sb.append("    chainConfiguration: ").append(toIndentedString(chainConfiguration)).append("\n");
    sb.append("    validFrom: ").append(toIndentedString(validFrom)).append("\n");
    sb.append("    metaDataChain: ").append(toIndentedString(metaDataChain)).append("\n");
    sb.append("    proofChain: ").append(toIndentedString(proofChain)).append("\n");
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

