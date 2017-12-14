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


package com.sphereon.sdk.blockchain.proof.api;

import com.sphereon.sdk.blockchain.proof.handler.ApiCallback;
import com.sphereon.sdk.blockchain.proof.handler.ApiClient;
import com.sphereon.sdk.blockchain.proof.handler.ApiException;
import com.sphereon.sdk.blockchain.proof.handler.ApiResponse;
import com.sphereon.sdk.blockchain.proof.handler.Configuration;
import com.sphereon.sdk.blockchain.proof.handler.Pair;
import com.sphereon.sdk.blockchain.proof.handler.ProgressRequestBody;
import com.sphereon.sdk.blockchain.proof.handler.ProgressResponseBody;

import com.google.gson.reflect.TypeToken;

import java.io.IOException;


import com.sphereon.sdk.blockchain.proof.model.ContentRequest;
import com.sphereon.sdk.blockchain.proof.model.ErrorResponse;
import java.io.File;
import com.sphereon.sdk.blockchain.proof.model.StreamLocation;
import com.sphereon.sdk.blockchain.proof.model.VerifyContentResponse;

import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class VerificationApi {
    private ApiClient apiClient;

    public VerificationApi() {
        this(Configuration.getDefaultApiClient());
    }

    public VerificationApi(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    public ApiClient getApiClient() {
        return apiClient;
    }

    public void setApiClient(ApiClient apiClient) {
        this.apiClient = apiClient;
    }

    /**
     * Build call for verifyUsingContent
     * @param configName The configName for this operation (required)
     * @param existence Verify content using the current settings (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call verifyUsingContentCall(String configName, ContentRequest existence, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = existence;
        
        // create path and map variables
        String localVarPath = "/blockchain/proof/0.9/existence/{configName}/content"
            .replaceAll("\\{" + "configName" + "\\}", apiClient.escapeString(configName.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json;charset=UTF-8"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json;charset=UTF-8"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "oauth2schema" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call verifyUsingContentValidateBeforeCall(String configName, ContentRequest existence, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'configName' is set
        if (configName == null) {
            throw new ApiException("Missing the required parameter 'configName' when calling verifyUsingContent(Async)");
        }
        
        // verify the required parameter 'existence' is set
        if (existence == null) {
            throw new ApiException("Missing the required parameter 'existence' when calling verifyUsingContent(Async)");
        }
        
        
        com.squareup.okhttp.Call call = verifyUsingContentCall(configName, existence, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Verify content
     * 
     * @param configName The configName for this operation (required)
     * @param existence Verify content using the current settings (required)
     * @return VerifyContentResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public VerifyContentResponse verifyUsingContent(String configName, ContentRequest existence) throws ApiException {
        ApiResponse<VerifyContentResponse> resp = verifyUsingContentWithHttpInfo(configName, existence);
        return resp.getData();
    }

    /**
     * Verify content
     * 
     * @param configName The configName for this operation (required)
     * @param existence Verify content using the current settings (required)
     * @return ApiResponse&lt;VerifyContentResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<VerifyContentResponse> verifyUsingContentWithHttpInfo(String configName, ContentRequest existence) throws ApiException {
        com.squareup.okhttp.Call call = verifyUsingContentValidateBeforeCall(configName, existence, null, null);
        Type localVarReturnType = new TypeToken<VerifyContentResponse>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Verify content (asynchronously)
     * 
     * @param configName The configName for this operation (required)
     * @param existence Verify content using the current settings (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call verifyUsingContentAsync(String configName, ContentRequest existence, final ApiCallback<VerifyContentResponse> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = verifyUsingContentValidateBeforeCall(configName, existence, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<VerifyContentResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for verifyUsingLocation
     * @param configName The context for this operation (required)
     * @param streamLocations The stream locations on storage (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call verifyUsingLocationCall(String configName, List<StreamLocation> streamLocations, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = streamLocations;
        
        // create path and map variables
        String localVarPath = "/blockchain/proof/0.9/existence/{configName}/streams/location"
            .replaceAll("\\{" + "configName" + "\\}", apiClient.escapeString(configName.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();

        final String[] localVarAccepts = {
            "application/json;charset=UTF-8"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "application/json;charset=UTF-8"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "oauth2schema" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call verifyUsingLocationValidateBeforeCall(String configName, List<StreamLocation> streamLocations, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'configName' is set
        if (configName == null) {
            throw new ApiException("Missing the required parameter 'configName' when calling verifyUsingLocation(Async)");
        }
        
        // verify the required parameter 'streamLocations' is set
        if (streamLocations == null) {
            throw new ApiException("Missing the required parameter 'streamLocations' when calling verifyUsingLocation(Async)");
        }
        
        
        com.squareup.okhttp.Call call = verifyUsingLocationCall(configName, streamLocations, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Verify content using Stream Locations from the Storage API
     * Verify content by supplying a file or some other binary data. Hashing will be done on the server side
     * @param configName The context for this operation (required)
     * @param streamLocations The stream locations on storage (required)
     * @return VerifyContentResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public VerifyContentResponse verifyUsingLocation(String configName, List<StreamLocation> streamLocations) throws ApiException {
        ApiResponse<VerifyContentResponse> resp = verifyUsingLocationWithHttpInfo(configName, streamLocations);
        return resp.getData();
    }

    /**
     * Verify content using Stream Locations from the Storage API
     * Verify content by supplying a file or some other binary data. Hashing will be done on the server side
     * @param configName The context for this operation (required)
     * @param streamLocations The stream locations on storage (required)
     * @return ApiResponse&lt;VerifyContentResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<VerifyContentResponse> verifyUsingLocationWithHttpInfo(String configName, List<StreamLocation> streamLocations) throws ApiException {
        com.squareup.okhttp.Call call = verifyUsingLocationValidateBeforeCall(configName, streamLocations, null, null);
        Type localVarReturnType = new TypeToken<VerifyContentResponse>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Verify content using Stream Locations from the Storage API (asynchronously)
     * Verify content by supplying a file or some other binary data. Hashing will be done on the server side
     * @param configName The context for this operation (required)
     * @param streamLocations The stream locations on storage (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call verifyUsingLocationAsync(String configName, List<StreamLocation> streamLocations, final ApiCallback<VerifyContentResponse> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = verifyUsingLocationValidateBeforeCall(configName, streamLocations, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<VerifyContentResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
    /**
     * Build call for verifyUsingStream
     * @param configName The configuration name this operation (required)
     * @param stream The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored (required)
     * @param progressListener Progress listener
     * @param progressRequestListener Progress request listener
     * @return Call to execute
     * @throws ApiException If fail to serialize the request body object
     */
    public com.squareup.okhttp.Call verifyUsingStreamCall(String configName, File stream, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        Object localVarPostBody = null;
        
        // create path and map variables
        String localVarPath = "/blockchain/proof/0.9/existence/{configName}/streams/multipart"
            .replaceAll("\\{" + "configName" + "\\}", apiClient.escapeString(configName.toString()));

        List<Pair> localVarQueryParams = new ArrayList<Pair>();

        Map<String, String> localVarHeaderParams = new HashMap<String, String>();

        Map<String, Object> localVarFormParams = new HashMap<String, Object>();
        if (stream != null)
        localVarFormParams.put("stream", stream);

        final String[] localVarAccepts = {
            "application/json;charset=UTF-8"
        };
        final String localVarAccept = apiClient.selectHeaderAccept(localVarAccepts);
        if (localVarAccept != null) localVarHeaderParams.put("Accept", localVarAccept);

        final String[] localVarContentTypes = {
            "multipart/form-data"
        };
        final String localVarContentType = apiClient.selectHeaderContentType(localVarContentTypes);
        localVarHeaderParams.put("Content-Type", localVarContentType);

        if(progressListener != null) {
            apiClient.getHttpClient().networkInterceptors().add(new com.squareup.okhttp.Interceptor() {
                @Override
                public com.squareup.okhttp.Response intercept(com.squareup.okhttp.Interceptor.Chain chain) throws IOException {
                    com.squareup.okhttp.Response originalResponse = chain.proceed(chain.request());
                    return originalResponse.newBuilder()
                    .body(new ProgressResponseBody(originalResponse.body(), progressListener))
                    .build();
                }
            });
        }

        String[] localVarAuthNames = new String[] { "oauth2schema" };
        return apiClient.buildCall(localVarPath, "POST", localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarAuthNames, progressRequestListener);
    }
    
    @SuppressWarnings("rawtypes")
    private com.squareup.okhttp.Call verifyUsingStreamValidateBeforeCall(String configName, File stream, final ProgressResponseBody.ProgressListener progressListener, final ProgressRequestBody.ProgressRequestListener progressRequestListener) throws ApiException {
        
        // verify the required parameter 'configName' is set
        if (configName == null) {
            throw new ApiException("Missing the required parameter 'configName' when calling verifyUsingStream(Async)");
        }
        
        // verify the required parameter 'stream' is set
        if (stream == null) {
            throw new ApiException("Missing the required parameter 'stream' when calling verifyUsingStream(Async)");
        }
        
        
        com.squareup.okhttp.Call call = verifyUsingStreamCall(configName, stream, progressListener, progressRequestListener);
        return call;

        
        
        
        
    }

    /**
     * Verify content using a bytestream/file
     * Verify content by supplying a file or some other binary data. Hashing will be done on the server side
     * @param configName The configuration name this operation (required)
     * @param stream The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored (required)
     * @return VerifyContentResponse
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public VerifyContentResponse verifyUsingStream(String configName, File stream) throws ApiException {
        ApiResponse<VerifyContentResponse> resp = verifyUsingStreamWithHttpInfo(configName, stream);
        return resp.getData();
    }

    /**
     * Verify content using a bytestream/file
     * Verify content by supplying a file or some other binary data. Hashing will be done on the server side
     * @param configName The configuration name this operation (required)
     * @param stream The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored (required)
     * @return ApiResponse&lt;VerifyContentResponse&gt;
     * @throws ApiException If fail to call the API, e.g. server error or cannot deserialize the response body
     */
    public ApiResponse<VerifyContentResponse> verifyUsingStreamWithHttpInfo(String configName, File stream) throws ApiException {
        com.squareup.okhttp.Call call = verifyUsingStreamValidateBeforeCall(configName, stream, null, null);
        Type localVarReturnType = new TypeToken<VerifyContentResponse>(){}.getType();
        return apiClient.execute(call, localVarReturnType);
    }

    /**
     * Verify content using a bytestream/file (asynchronously)
     * Verify content by supplying a file or some other binary data. Hashing will be done on the server side
     * @param configName The configuration name this operation (required)
     * @param stream The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored (required)
     * @param callback The callback to be executed when the API call finishes
     * @return The request call
     * @throws ApiException If fail to process the API call, e.g. serializing the request body object
     */
    public com.squareup.okhttp.Call verifyUsingStreamAsync(String configName, File stream, final ApiCallback<VerifyContentResponse> callback) throws ApiException {

        ProgressResponseBody.ProgressListener progressListener = null;
        ProgressRequestBody.ProgressRequestListener progressRequestListener = null;

        if (callback != null) {
            progressListener = new ProgressResponseBody.ProgressListener() {
                @Override
                public void update(long bytesRead, long contentLength, boolean done) {
                    callback.onDownloadProgress(bytesRead, contentLength, done);
                }
            };

            progressRequestListener = new ProgressRequestBody.ProgressRequestListener() {
                @Override
                public void onRequestProgress(long bytesWritten, long contentLength, boolean done) {
                    callback.onUploadProgress(bytesWritten, contentLength, done);
                }
            };
        }

        com.squareup.okhttp.Call call = verifyUsingStreamValidateBeforeCall(configName, stream, progressListener, progressRequestListener);
        Type localVarReturnType = new TypeToken<VerifyContentResponse>(){}.getType();
        apiClient.executeAsync(call, localVarReturnType, callback);
        return call;
    }
}