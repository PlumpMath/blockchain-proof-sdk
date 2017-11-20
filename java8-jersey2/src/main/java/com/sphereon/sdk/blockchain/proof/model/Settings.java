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
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;

/**
 * Existence Settings. Normally you only supply them once during chain creation or during a settings update. You can also supply them during a content request, but then it is up to you to also supply the correct setting during verify
 */
@ApiModel(description = "Existence Settings. Normally you only supply them once during chain creation or during a settings update. You can also supply them during a content request, but then it is up to you to also supply the correct setting during verify")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-11-13T14:20:43.095+01:00")
public class Settings {
  /**
   * The settings version (only 1 for now)
   */
  public enum VersionEnum {
    NUMBER_1(1);

    private Integer value;

    VersionEnum(Integer value) {
      this.value = value;
    }

    @JsonValue
    public Integer getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    @JsonCreator
    public static VersionEnum fromValue(String text) {
      for (VersionEnum b : VersionEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
  }

  @JsonProperty("version")
  private VersionEnum version = null;

  /**
   * The hashing method used (CLIENT) or to use (SERVER) for the content
   */
  public enum HashAlgorithmEnum {
    PLAIN("PLAIN"),
    
    SHA_256("SHA_256"),
    
    SHA_512("SHA_512");

    private String value;

    HashAlgorithmEnum(String value) {
      this.value = value;
    }

    @JsonValue
    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    @JsonCreator
    public static HashAlgorithmEnum fromValue(String text) {
      for (HashAlgorithmEnum b : HashAlgorithmEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }
  }

  @JsonProperty("hashAlgorithm")
  private HashAlgorithmEnum hashAlgorithm = null;

  public Settings version(VersionEnum version) {
    this.version = version;
    return this;
  }

   /**
   * The settings version (only 1 for now)
   * @return version
  **/
  @ApiModelProperty(required = true, value = "The settings version (only 1 for now)")
  public VersionEnum getVersion() {
    return version;
  }

  public void setVersion(VersionEnum version) {
    this.version = version;
  }

  public Settings hashAlgorithm(HashAlgorithmEnum hashAlgorithm) {
    this.hashAlgorithm = hashAlgorithm;
    return this;
  }

   /**
   * The hashing method used (CLIENT) or to use (SERVER) for the content
   * @return hashAlgorithm
  **/
  @ApiModelProperty(value = "The hashing method used (CLIENT) or to use (SERVER) for the content")
  public HashAlgorithmEnum getHashAlgorithm() {
    return hashAlgorithm;
  }

  public void setHashAlgorithm(HashAlgorithmEnum hashAlgorithm) {
    this.hashAlgorithm = hashAlgorithm;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    Settings settings = (Settings) o;
    return Objects.equals(this.version, settings.version) &&
        Objects.equals(this.hashAlgorithm, settings.hashAlgorithm);
  }

  @Override
  public int hashCode() {
    return Objects.hash(version, hashAlgorithm);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class Settings {\n");
    
    sb.append("    version: ").append(toIndentedString(version)).append("\n");
    sb.append("    hashAlgorithm: ").append(toIndentedString(hashAlgorithm)).append("\n");
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

