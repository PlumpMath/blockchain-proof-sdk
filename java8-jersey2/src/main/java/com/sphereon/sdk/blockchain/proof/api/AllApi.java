package com.sphereon.sdk.blockchain.proof.api;

import com.sphereon.sdk.blockchain.proof.handler.ApiException;
import com.sphereon.sdk.blockchain.proof.handler.ApiClient;
import com.sphereon.sdk.blockchain.proof.handler.Configuration;
import com.sphereon.sdk.blockchain.proof.handler.Pair;

import javax.ws.rs.core.GenericType;

import com.sphereon.sdk.blockchain.proof.model.CreateChainRequest;
import com.sphereon.sdk.blockchain.proof.model.CreateChainResponse;
import com.sphereon.sdk.blockchain.proof.model.VndErrors;
import com.sphereon.sdk.blockchain.proof.model.ContentRequest;
import com.sphereon.sdk.blockchain.proof.model.RegisterContentResponse;
import java.io.File;
import com.sphereon.sdk.blockchain.proof.model.SettingsResponse;
import com.sphereon.sdk.blockchain.proof.model.VerifyContentResponse;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@javax.annotation.Generated(value = "class io.swagger.codegen.languages.JavaClientCodegen", date = "2016-11-13T19:35:07.820+01:00")
public class AllApi {
  private ApiClient apiClient;

  public AllApi() {
    this(Configuration.getDefaultApiClient());
  }

  public AllApi(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  public ApiClient getApiClient() {
    return apiClient;
  }

  public void setApiClient(ApiClient apiClient) {
    this.apiClient = apiClient;
  }

  /**
   * Create a new entity chain
   * 
   * @param request Create a new Proof of Existence chain using the provided entity settings (required)
   * @return CreateChainResponse
   * @throws ApiException if fails to make API call
   */
  public CreateChainResponse createChain(CreateChainRequest request) throws ApiException {
    Object localVarPostBody = request;
    
    // verify the required parameter 'request' is set
    if (request == null) {
      throw new ApiException(400, "Missing the required parameter 'request' when calling createChain");
    }
    
    // create path and map variables
    String localVarPath = "/blockchain/proof/0.1.0/existence".replaceAll("\\{format\\}","json");

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();


    
    
    final String[] localVarAccepts = {
      "application/json;charset=UTF-8"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json;charset=UTF-8"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] { "oauth2schema" };

    GenericType<CreateChainResponse> localVarReturnType = new GenericType<CreateChainResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
  /**
   * Register content
   * 
   * @param chainId The chain where the content will be registered (required)
   * @param existence Register content using the current entity settings (required)
   * @return RegisterContentResponse
   * @throws ApiException if fails to make API call
   */
  public RegisterContentResponse registerContent(String chainId, ContentRequest existence) throws ApiException {
    Object localVarPostBody = existence;
    
    // verify the required parameter 'chainId' is set
    if (chainId == null) {
      throw new ApiException(400, "Missing the required parameter 'chainId' when calling registerContent");
    }
    
    // verify the required parameter 'existence' is set
    if (existence == null) {
      throw new ApiException(400, "Missing the required parameter 'existence' when calling registerContent");
    }
    
    // create path and map variables
    String localVarPath = "/blockchain/proof/0.1.0/existence/{chainId}/register/content".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "chainId" + "\\}", apiClient.escapeString(chainId.toString()));

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();


    
    
    final String[] localVarAccepts = {
      "application/json;charset=UTF-8"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json;charset=UTF-8"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] { "oauth2schema" };

    GenericType<RegisterContentResponse> localVarReturnType = new GenericType<RegisterContentResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
  /**
   * Register content using a bytestream/file
   * Register content by supplying a file or some other binary data. Hashing will be done on the server side
   * @param chainId The chain where the content will be registered (required)
   * @param stream The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored (required)
   * @return RegisterContentResponse
   * @throws ApiException if fails to make API call
   */
  public RegisterContentResponse registerStream(String chainId, File stream) throws ApiException {
    Object localVarPostBody = null;
    
    // verify the required parameter 'chainId' is set
    if (chainId == null) {
      throw new ApiException(400, "Missing the required parameter 'chainId' when calling registerStream");
    }
    
    // verify the required parameter 'stream' is set
    if (stream == null) {
      throw new ApiException(400, "Missing the required parameter 'stream' when calling registerStream");
    }
    
    // create path and map variables
    String localVarPath = "/blockchain/proof/0.1.0/existence/{chainId}/register/stream".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "chainId" + "\\}", apiClient.escapeString(chainId.toString()));

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();


    
    if (stream != null)
      localVarFormParams.put("stream", stream);

    final String[] localVarAccepts = {
      "application/json;charset=UTF-8"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "multipart/form-data"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] { "oauth2schema" };

    GenericType<RegisterContentResponse> localVarReturnType = new GenericType<RegisterContentResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
  /**
   * Get the settings for registration/verification
   * 
   * @param chainId This is the chain where the content is registered/verified (required)
   * @return SettingsResponse
   * @throws ApiException if fails to make API call
   */
  public SettingsResponse settings(String chainId) throws ApiException {
    Object localVarPostBody = null;
    
    // verify the required parameter 'chainId' is set
    if (chainId == null) {
      throw new ApiException(400, "Missing the required parameter 'chainId' when calling settings");
    }
    
    // create path and map variables
    String localVarPath = "/blockchain/proof/0.1.0/existence/{chainId}/settings".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "chainId" + "\\}", apiClient.escapeString(chainId.toString()));

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();


    
    
    final String[] localVarAccepts = {
      "application/json;charset=UTF-8"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] { "oauth2schema" };

    GenericType<SettingsResponse> localVarReturnType = new GenericType<SettingsResponse>() {};
    return apiClient.invokeAPI(localVarPath, "GET", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
  /**
   * Verify content
   * 
   * @param chainId The chain where the content was registered (required)
   * @param existence Verify content using the current entity settings (required)
   * @return VerifyContentResponse
   * @throws ApiException if fails to make API call
   */
  public VerifyContentResponse verifyContent(String chainId, ContentRequest existence) throws ApiException {
    Object localVarPostBody = existence;
    
    // verify the required parameter 'chainId' is set
    if (chainId == null) {
      throw new ApiException(400, "Missing the required parameter 'chainId' when calling verifyContent");
    }
    
    // verify the required parameter 'existence' is set
    if (existence == null) {
      throw new ApiException(400, "Missing the required parameter 'existence' when calling verifyContent");
    }
    
    // create path and map variables
    String localVarPath = "/blockchain/proof/0.1.0/existence/{chainId}/verify/content".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "chainId" + "\\}", apiClient.escapeString(chainId.toString()));

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();


    
    
    final String[] localVarAccepts = {
      "application/json;charset=UTF-8"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "application/json;charset=UTF-8"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] { "oauth2schema" };

    GenericType<VerifyContentResponse> localVarReturnType = new GenericType<VerifyContentResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
  /**
   * Verify content using a bytestream/file
   * Verify content by supplying a file or some other binary data. Hashing will be done on the server side
   * @param chainId The chain where the content will be verified (required)
   * @param stream The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored (required)
   * @return VerifyContentResponse
   * @throws ApiException if fails to make API call
   */
  public VerifyContentResponse verifyStream(String chainId, File stream) throws ApiException {
    Object localVarPostBody = null;
    
    // verify the required parameter 'chainId' is set
    if (chainId == null) {
      throw new ApiException(400, "Missing the required parameter 'chainId' when calling verifyStream");
    }
    
    // verify the required parameter 'stream' is set
    if (stream == null) {
      throw new ApiException(400, "Missing the required parameter 'stream' when calling verifyStream");
    }
    
    // create path and map variables
    String localVarPath = "/blockchain/proof/0.1.0/existence/{chainId}/verify/stream".replaceAll("\\{format\\}","json")
      .replaceAll("\\{" + "chainId" + "\\}", apiClient.escapeString(chainId.toString()));

    // query params
    List<Pair> localVarQueryParams = new ArrayList<Pair>();
    Map<String, String> localVarHeaderParams = new HashMap<String, String>();
    Map<String, Object> localVarFormParams = new HashMap<String, Object>();


    
    if (stream != null)
      localVarFormParams.put("stream", stream);

    final String[] localVarAccepts = {
      "application/json;charset=UTF-8"
    };
    final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);

    final String[] localVarContentTypes = {
      "multipart/form-data"
    };
    final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);

    String[] localVarAuthNames = new String[] { "oauth2schema" };

    GenericType<VerifyContentResponse> localVarReturnType = new GenericType<VerifyContentResponse>() {};
    return apiClient.invokeAPI(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAccept, localVarContentType, localVarAuthNames, localVarReturnType);
      }
}
