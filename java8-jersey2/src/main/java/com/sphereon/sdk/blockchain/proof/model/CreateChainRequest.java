/**
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

import java.util.Objects;
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.sphereon.sdk.blockchain.proof.model.Settings;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;


/**
 * Create chain for Proof of Existence request
 */
@ApiModel(description = "Create chain for Proof of Existence request")
@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-11-13T19:35:07.820+01:00")
public class CreateChainRequest   {
  @JsonProperty("metadata")
  private byte[] metadata = null;

  @JsonProperty("settingsChainId")
  private String settingsChainId = null;

  @JsonProperty("name")
  private String name = null;

  @JsonProperty("previousChainId")
  private String previousChainId = null;

  @JsonProperty("defaultSettings")
  private Settings defaultSettings = null;

  public CreateChainRequest metadata(byte[] metadata) {
    this.metadata = metadata;
    return this;
  }

   /**
   * Metadata for this chain.
   * @return metadata
  **/
  @ApiModelProperty(example = "null", value = "Metadata for this chain.")
  public byte[] getMetadata() {
    return metadata;
  }

  public void setMetadata(byte[] metadata) {
    this.metadata = metadata;
  }

  public CreateChainRequest settingsChainId(String settingsChainId) {
    this.settingsChainId = settingsChainId;
    return this;
  }

   /**
   * Supply an existing settings chain. When not supplied a new settings chain will be created automatically.
   * @return settingsChainId
  **/
  @ApiModelProperty(example = "null", value = "Supply an existing settings chain. When not supplied a new settings chain will be created automatically.")
  public String getSettingsChainId() {
    return settingsChainId;
  }

  public void setSettingsChainId(String settingsChainId) {
    this.settingsChainId = settingsChainId;
  }

  public CreateChainRequest name(String name) {
    this.name = name;
    return this;
  }

   /**
   * Unique name for this chain.
   * @return name
  **/
  @ApiModelProperty(example = "null", required = true, value = "Unique name for this chain.")
  public String getName() {
    return name;
  }

  public void setName(String name) {
    this.name = name;
  }

  public CreateChainRequest previousChainId(String previousChainId) {
    this.previousChainId = previousChainId;
    return this;
  }

   /**
   * When this chain is a continuation of another chain you need to supply the previous chainId here.
   * @return previousChainId
  **/
  @ApiModelProperty(example = "null", value = "When this chain is a continuation of another chain you need to supply the previous chainId here.")
  public String getPreviousChainId() {
    return previousChainId;
  }

  public void setPreviousChainId(String previousChainId) {
    this.previousChainId = previousChainId;
  }

  public CreateChainRequest defaultSettings(Settings defaultSettings) {
    this.defaultSettings = defaultSettings;
    return this;
  }

   /**
   * Get defaultSettings
   * @return defaultSettings
  **/
  @ApiModelProperty(example = "null", required = true, value = "")
  public Settings getDefaultSettings() {
    return defaultSettings;
  }

  public void setDefaultSettings(Settings defaultSettings) {
    this.defaultSettings = defaultSettings;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    CreateChainRequest createChainRequest = (CreateChainRequest) o;
    return Objects.equals(this.metadata, createChainRequest.metadata) &&
        Objects.equals(this.settingsChainId, createChainRequest.settingsChainId) &&
        Objects.equals(this.name, createChainRequest.name) &&
        Objects.equals(this.previousChainId, createChainRequest.previousChainId) &&
        Objects.equals(this.defaultSettings, createChainRequest.defaultSettings);
  }

  @Override
  public int hashCode() {
    return Objects.hash(metadata, settingsChainId, name, previousChainId, defaultSettings);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class CreateChainRequest {\n");
    
    sb.append("    metadata: ").append(toIndentedString(metadata)).append("\n");
    sb.append("    settingsChainId: ").append(toIndentedString(settingsChainId)).append("\n");
    sb.append("    name: ").append(toIndentedString(name)).append("\n");
    sb.append("    previousChainId: ").append(toIndentedString(previousChainId)).append("\n");
    sb.append("    defaultSettings: ").append(toIndentedString(defaultSettings)).append("\n");
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

