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
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * Content existence request
 */
@ApiModel(description = "Content existence request")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-11-13T14:20:54.472+01:00")
public class ContentRequest {
  /**
   * When CLIENT is supplied the content should already have been hashed by you. When SERVER is supplied we will hash the content
   */
  @JsonAdapter(HashProviderEnum.Adapter.class)
  public enum HashProviderEnum {
    SERVER("SERVER"),
    
    CLIENT("CLIENT");

    private String value;

    HashProviderEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static HashProviderEnum fromValue(String text) {
      for (HashProviderEnum b : HashProviderEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<HashProviderEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final HashProviderEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public HashProviderEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return HashProviderEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("hashProvider")
  private HashProviderEnum hashProvider = null;

  @SerializedName("content")
  private byte[] content = null;

  public ContentRequest hashProvider(HashProviderEnum hashProvider) {
    this.hashProvider = hashProvider;
    return this;
  }

   /**
   * When CLIENT is supplied the content should already have been hashed by you. When SERVER is supplied we will hash the content
   * @return hashProvider
  **/
  @ApiModelProperty(required = true, value = "When CLIENT is supplied the content should already have been hashed by you. When SERVER is supplied we will hash the content")
  public HashProviderEnum getHashProvider() {
    return hashProvider;
  }

  public void setHashProvider(HashProviderEnum hashProvider) {
    this.hashProvider = hashProvider;
  }

  public ContentRequest content(byte[] content) {
    this.content = content;
    return this;
  }

   /**
   * The content to register.
   * @return content
  **/
  @ApiModelProperty(required = true, value = "The content to register.")
  public byte[] getContent() {
    return content;
  }

  public void setContent(byte[] content) {
    this.content = content;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ContentRequest contentRequest = (ContentRequest) o;
    return Objects.equals(this.hashProvider, contentRequest.hashProvider) &&
        Objects.equals(this.content, contentRequest.content);
  }

  @Override
  public int hashCode() {
    return Objects.hash(hashProvider, content);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ContentRequest {\n");
    
    sb.append("    hashProvider: ").append(toIndentedString(hashProvider)).append("\n");
    sb.append("    content: ").append(toIndentedString(content)).append("\n");
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

