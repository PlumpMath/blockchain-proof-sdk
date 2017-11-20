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

/**
 * Committed Content response
 */
@ApiModel(description = "Committed Content response")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-11-13T14:20:54.641+01:00")
public class RegisterContentResponse {
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

  public RegisterContentResponse contentRequest(ContentRequest contentRequest) {
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

  public RegisterContentResponse proofChain(CommittedChain proofChain) {
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

  public RegisterContentResponse registrationState(RegistrationStateEnum registrationState) {
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
    RegisterContentResponse registerContentResponse = (RegisterContentResponse) o;
    return Objects.equals(this.contentRequest, registerContentResponse.contentRequest) &&
        Objects.equals(this.proofChain, registerContentResponse.proofChain) &&
        Objects.equals(this.registrationState, registerContentResponse.registrationState);
  }

  @Override
  public int hashCode() {
    return Objects.hash(contentRequest, proofChain, registrationState);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class RegisterContentResponse {\n");
    
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
