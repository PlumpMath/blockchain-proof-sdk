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
import com.sphereon.sdk.blockchain.proof.model.ContentRequest;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.time.OffsetDateTime;

/**
 * Verify Content response
 */
@ApiModel(description = "Verify Content response")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-11-13T14:20:54.472+01:00")
public class VerifyContentResponse {
  @SerializedName("registrationTime")
  private OffsetDateTime registrationTime = null;

  @SerializedName("contentId")
  private String contentId = null;

  @SerializedName("contentRequest")
  private ContentRequest contentRequest = null;

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

  public VerifyContentResponse contentRequest(ContentRequest contentRequest) {
    this.contentRequest = contentRequest;
    return this;
  }

   /**
   * Get contentRequest
   * @return contentRequest
  **/
  @ApiModelProperty(required = true, value = "")
  public ContentRequest getContentRequest() {
    return contentRequest;
  }

  public void setContentRequest(ContentRequest contentRequest) {
    this.contentRequest = contentRequest;
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
        Objects.equals(this.contentId, verifyContentResponse.contentId) &&
        Objects.equals(this.contentRequest, verifyContentResponse.contentRequest) &&
        Objects.equals(this.proofChain, verifyContentResponse.proofChain) &&
        Objects.equals(this.registrationState, verifyContentResponse.registrationState);
  }

  @Override
  public int hashCode() {
    return Objects.hash(registrationTime, contentId, contentRequest, proofChain, registrationState);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class VerifyContentResponse {\n");
    
    sb.append("    registrationTime: ").append(toIndentedString(registrationTime)).append("\n");
    sb.append("    contentId: ").append(toIndentedString(contentId)).append("\n");
    sb.append("    contentRequest: ").append(toIndentedString(contentRequest)).append("\n");
    sb.append("    proofChain: ").append(toIndentedString(proofChain)).append("\n");
    sb.append("    registrationState: ").append(toIndentedString(registrationState)).append("\n");
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

