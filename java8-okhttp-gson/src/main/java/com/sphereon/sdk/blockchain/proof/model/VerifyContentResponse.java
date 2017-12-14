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
import com.sphereon.sdk.blockchain.proof.model.CommittedChain;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.OffsetDateTime;

/**
 * Verify Content response
 */
@ApiModel(description = "Verify Content response")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-12-14T13:24:28.303+01:00")
public class VerifyContentResponse {
  @SerializedName("registrationTime")
  private OffsetDateTime registrationTime = null;

  @SerializedName("contextName")
  private String contextName = null;

  @SerializedName("requestId")
  private String requestId = null;

  @SerializedName("contentId")
  private String contentId = null;

  @SerializedName("proofChain")
  private CommittedChain proofChain = null;

  /**
   * Gets or Sets registrationState
   */
  @JsonAdapter(RegistrationStateEnum.Adapter.class)
  public enum RegistrationStateEnum {
    PENDING("PENDING"),
    
    REGISTERED("REGISTERED"),
    
    NOT_REGISTERED("NOT_REGISTERED");

    private String value;

    RegistrationStateEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static RegistrationStateEnum fromValue(String text) {
      for (RegistrationStateEnum b : RegistrationStateEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<RegistrationStateEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final RegistrationStateEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public RegistrationStateEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return RegistrationStateEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("registrationState")
  private RegistrationStateEnum registrationState = null;

  @SerializedName("fileChain")
  private CommittedChain fileChain = null;

  public VerifyContentResponse registrationTime(OffsetDateTime registrationTime) {
    this.registrationTime = registrationTime;
    return this;
  }

   /**
   * Get registrationTime
   * @return registrationTime
  **/
  @ApiModelProperty(value = "")
  public OffsetDateTime getRegistrationTime() {
    return registrationTime;
  }

  public void setRegistrationTime(OffsetDateTime registrationTime) {
    this.registrationTime = registrationTime;
  }

  public VerifyContentResponse contextName(String contextName) {
    this.contextName = contextName;
    return this;
  }

   /**
   * Get contextName
   * @return contextName
  **/
  @ApiModelProperty(required = true, value = "")
  public String getContextName() {
    return contextName;
  }

  public void setContextName(String contextName) {
    this.contextName = contextName;
  }

  public VerifyContentResponse requestId(String requestId) {
    this.requestId = requestId;
    return this;
  }

   /**
   * Get requestId
   * @return requestId
  **/
  @ApiModelProperty(value = "")
  public String getRequestId() {
    return requestId;
  }

  public void setRequestId(String requestId) {
    this.requestId = requestId;
  }

  public VerifyContentResponse contentId(String contentId) {
    this.contentId = contentId;
    return this;
  }

   /**
   * Get contentId
   * @return contentId
  **/
  @ApiModelProperty(required = true, value = "")
  public String getContentId() {
    return contentId;
  }

  public void setContentId(String contentId) {
    this.contentId = contentId;
  }

  public VerifyContentResponse proofChain(CommittedChain proofChain) {
    this.proofChain = proofChain;
    return this;
  }

   /**
   * Get proofChain
   * @return proofChain
  **/
  @ApiModelProperty(required = true, value = "")
  public CommittedChain getProofChain() {
    return proofChain;
  }

  public void setProofChain(CommittedChain proofChain) {
    this.proofChain = proofChain;
  }

  public VerifyContentResponse registrationState(RegistrationStateEnum registrationState) {
    this.registrationState = registrationState;
    return this;
  }

   /**
   * Get registrationState
   * @return registrationState
  **/
  @ApiModelProperty(required = true, value = "")
  public RegistrationStateEnum getRegistrationState() {
    return registrationState;
  }

  public void setRegistrationState(RegistrationStateEnum registrationState) {
    this.registrationState = registrationState;
  }

  public VerifyContentResponse fileChain(CommittedChain fileChain) {
    this.fileChain = fileChain;
    return this;
  }

   /**
   * Get fileChain
   * @return fileChain
  **/
  @ApiModelProperty(required = true, value = "")
  public CommittedChain getFileChain() {
    return fileChain;
  }

  public void setFileChain(CommittedChain fileChain) {
    this.fileChain = fileChain;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    VerifyContentResponse verifyContentResponse = (VerifyContentResponse) o;
    return Objects.equals(this.registrationTime, verifyContentResponse.registrationTime) &&
        Objects.equals(this.contextName, verifyContentResponse.contextName) &&
        Objects.equals(this.requestId, verifyContentResponse.requestId) &&
        Objects.equals(this.contentId, verifyContentResponse.contentId) &&
        Objects.equals(this.proofChain, verifyContentResponse.proofChain) &&
        Objects.equals(this.registrationState, verifyContentResponse.registrationState) &&
        Objects.equals(this.fileChain, verifyContentResponse.fileChain);
  }

  @Override
  public int hashCode() {
    return Objects.hash(registrationTime, contextName, requestId, contentId, proofChain, registrationState, fileChain);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class VerifyContentResponse {\n");
    
    sb.append("    registrationTime: ").append(toIndentedString(registrationTime)).append("\n");
    sb.append("    contextName: ").append(toIndentedString(contextName)).append("\n");
    sb.append("    requestId: ").append(toIndentedString(requestId)).append("\n");
    sb.append("    contentId: ").append(toIndentedString(contentId)).append("\n");
    sb.append("    proofChain: ").append(toIndentedString(proofChain)).append("\n");
    sb.append("    registrationState: ").append(toIndentedString(registrationState)).append("\n");
    sb.append("    fileChain: ").append(toIndentedString(fileChain)).append("\n");
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

