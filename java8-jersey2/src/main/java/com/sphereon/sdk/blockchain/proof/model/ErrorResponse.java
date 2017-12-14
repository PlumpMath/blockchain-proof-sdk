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
import com.fasterxml.jackson.annotation.JsonProperty;
import com.fasterxml.jackson.annotation.JsonCreator;
import com.fasterxml.jackson.annotation.JsonValue;
import com.sphereon.sdk.blockchain.proof.model.Error;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.util.ArrayList;
import java.util.List;

/**
 * The error response
 */
@ApiModel(description = "The error response")
@javax.annotation.Generated(value = "io.swagger.codegen.languages.JavaClientCodegen", date = "2017-12-14T12:58:01.897+01:00")
public class ErrorResponse {
  @JsonProperty("errors")
  private List<Error> errors = null;

  public ErrorResponse errors(List<Error> errors) {
    this.errors = errors;
    return this;
  }

  public ErrorResponse addErrorsItem(Error errorsItem) {
    if (this.errors == null) {
      this.errors = new ArrayList<Error>();
    }
    this.errors.add(errorsItem);
    return this;
  }

   /**
   * Get errors
   * @return errors
  **/
  @ApiModelProperty(value = "")
  public List<Error> getErrors() {
    return errors;
  }

  public void setErrors(List<Error> errors) {
    this.errors = errors;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ErrorResponse errorResponse = (ErrorResponse) o;
    return Objects.equals(this.errors, errorResponse.errors);
  }

  @Override
  public int hashCode() {
    return Objects.hash(errors);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ErrorResponse {\n");
    
    sb.append("    errors: ").append(toIndentedString(errors)).append("\n");
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

