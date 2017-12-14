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
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;

/**
 * Existence ChainSettings. Normally you only supply them once during chain creation or during a settings update. You can also supply them during a content request, but then it is up to you to also supply the correct setting during verify
 */
@ApiModel(description = "Existence ChainSettings. Normally you only supply them once during chain creation or during a settings update. You can also supply them during a content request, but then it is up to you to also supply the correct setting during verify")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-12-14T13:28:04.893+01:00")
public class ChainSettings {
  @SerializedName("signatureHash")
  private byte[] signatureHash = null;

  /**
   * Gets or Sets contentRegistrationChains
   */
  @JsonAdapter(ContentRegistrationChainsEnum.Adapter.class)
  public enum ContentRegistrationChainsEnum {
    FILE_CHAIN("FILE_CHAIN"),
    
    PROOF_CHAIN("PROOF_CHAIN");

    private String value;

    ContentRegistrationChainsEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static ContentRegistrationChainsEnum fromValue(String text) {
      for (ContentRegistrationChainsEnum b : ContentRegistrationChainsEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<ContentRegistrationChainsEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ContentRegistrationChainsEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ContentRegistrationChainsEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return ContentRegistrationChainsEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("contentRegistrationChains")
  private List<ContentRegistrationChainsEnum> contentRegistrationChains = null;

  @SerializedName("proofChainId")
  private String proofChainId = null;

  /**
   * Gets or Sets metadataRegistrationChains
   */
  @JsonAdapter(MetadataRegistrationChainsEnum.Adapter.class)
  public enum MetadataRegistrationChainsEnum {
    FILE_CHAIN("FILE_CHAIN"),
    
    PROOF_CHAIN("PROOF_CHAIN"),
    
    METADATA_CHAIN("METADATA_CHAIN");

    private String value;

    MetadataRegistrationChainsEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static MetadataRegistrationChainsEnum fromValue(String text) {
      for (MetadataRegistrationChainsEnum b : MetadataRegistrationChainsEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<MetadataRegistrationChainsEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final MetadataRegistrationChainsEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public MetadataRegistrationChainsEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return MetadataRegistrationChainsEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("metadataRegistrationChains")
  private List<MetadataRegistrationChainsEnum> metadataRegistrationChains = null;

  /**
   * The settings version (only 1 for now)
   */
  @JsonAdapter(VersionEnum.Adapter.class)
  public enum VersionEnum {
    NUMBER_1(1);

    private Integer value;

    VersionEnum(Integer value) {
      this.value = value;
    }

    public Integer getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static VersionEnum fromValue(String text) {
      for (VersionEnum b : VersionEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<VersionEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final VersionEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public VersionEnum read(final JsonReader jsonReader) throws IOException {
        Integer value = jsonReader.nextInt();
        return VersionEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("version")
  private VersionEnum version = null;

  /**
   * The hashing method used for the content
   */
  @JsonAdapter(HashAlgorithmEnum.Adapter.class)
  public enum HashAlgorithmEnum {
    _256("SHA_256"),
    
    _512("SHA_512");

    private String value;

    HashAlgorithmEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static HashAlgorithmEnum fromValue(String text) {
      for (HashAlgorithmEnum b : HashAlgorithmEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<HashAlgorithmEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final HashAlgorithmEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public HashAlgorithmEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return HashAlgorithmEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("hashAlgorithm")
  private HashAlgorithmEnum hashAlgorithm = null;

   /**
   * Get signatureHash
   * @return signatureHash
  **/
  @ApiModelProperty(required = true, value = "")
  public byte[] getSignatureHash() {
    return signatureHash;
  }

  public ChainSettings contentRegistrationChains(List<ContentRegistrationChainsEnum> contentRegistrationChains) {
    this.contentRegistrationChains = contentRegistrationChains;
    return this;
  }

  public ChainSettings addContentRegistrationChainsItem(ContentRegistrationChainsEnum contentRegistrationChainsItem) {
    if (this.contentRegistrationChains == null) {
      this.contentRegistrationChains = new ArrayList<ContentRegistrationChainsEnum>();
    }
    this.contentRegistrationChains.add(contentRegistrationChainsItem);
    return this;
  }

   /**
   * A set of content registration targets
   * @return contentRegistrationChains
  **/
  @ApiModelProperty(value = "A set of content registration targets")
  public List<ContentRegistrationChainsEnum> getContentRegistrationChains() {
    return contentRegistrationChains;
  }

  public void setContentRegistrationChains(List<ContentRegistrationChainsEnum> contentRegistrationChains) {
    this.contentRegistrationChains = contentRegistrationChains;
  }

  public ChainSettings proofChainId(String proofChainId) {
    this.proofChainId = proofChainId;
    return this;
  }

   /**
   * The proof chain id linked to the current configuration
   * @return proofChainId
  **/
  @ApiModelProperty(value = "The proof chain id linked to the current configuration")
  public String getProofChainId() {
    return proofChainId;
  }

  public void setProofChainId(String proofChainId) {
    this.proofChainId = proofChainId;
  }

  public ChainSettings metadataRegistrationChains(List<MetadataRegistrationChainsEnum> metadataRegistrationChains) {
    this.metadataRegistrationChains = metadataRegistrationChains;
    return this;
  }

  public ChainSettings addMetadataRegistrationChainsItem(MetadataRegistrationChainsEnum metadataRegistrationChainsItem) {
    if (this.metadataRegistrationChains == null) {
      this.metadataRegistrationChains = new ArrayList<MetadataRegistrationChainsEnum>();
    }
    this.metadataRegistrationChains.add(metadataRegistrationChainsItem);
    return this;
  }

   /**
   * A set of metadata registration targets
   * @return metadataRegistrationChains
  **/
  @ApiModelProperty(value = "A set of metadata registration targets")
  public List<MetadataRegistrationChainsEnum> getMetadataRegistrationChains() {
    return metadataRegistrationChains;
  }

  public void setMetadataRegistrationChains(List<MetadataRegistrationChainsEnum> metadataRegistrationChains) {
    this.metadataRegistrationChains = metadataRegistrationChains;
  }

  public ChainSettings version(VersionEnum version) {
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

  public ChainSettings hashAlgorithm(HashAlgorithmEnum hashAlgorithm) {
    this.hashAlgorithm = hashAlgorithm;
    return this;
  }

   /**
   * The hashing method used for the content
   * @return hashAlgorithm
  **/
  @ApiModelProperty(value = "The hashing method used for the content")
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
    ChainSettings chainSettings = (ChainSettings) o;
    return Objects.equals(this.signatureHash, chainSettings.signatureHash) &&
        Objects.equals(this.contentRegistrationChains, chainSettings.contentRegistrationChains) &&
        Objects.equals(this.proofChainId, chainSettings.proofChainId) &&
        Objects.equals(this.metadataRegistrationChains, chainSettings.metadataRegistrationChains) &&
        Objects.equals(this.version, chainSettings.version) &&
        Objects.equals(this.hashAlgorithm, chainSettings.hashAlgorithm);
  }

  @Override
  public int hashCode() {
    return Objects.hash(signatureHash, contentRegistrationChains, proofChainId, metadataRegistrationChains, version, hashAlgorithm);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ChainSettings {\n");
    
    sb.append("    signatureHash: ").append(toIndentedString(signatureHash)).append("\n");
    sb.append("    contentRegistrationChains: ").append(toIndentedString(contentRegistrationChains)).append("\n");
    sb.append("    proofChainId: ").append(toIndentedString(proofChainId)).append("\n");
    sb.append("    metadataRegistrationChains: ").append(toIndentedString(metadataRegistrationChains)).append("\n");
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

