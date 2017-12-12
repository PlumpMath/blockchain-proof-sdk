/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9.0-SNAPSHOT
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Sphereon.SDK.Blockchain.Proof.Client;
using Sphereon.SDK.Blockchain.Proof.Model;

namespace Sphereon.SDK.Blockchain.Proof.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IProofOfExistenceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Verify content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The configName for this operation</param>
        /// <param name="existence">Verify content using the current settings</param>
        /// <returns>VerifyContentResponse</returns>
        VerifyContentResponse VerifyContent (string configName, ContentRequest existence);

        /// <summary>
        /// Verify content
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The configName for this operation</param>
        /// <param name="existence">Verify content using the current settings</param>
        /// <returns>ApiResponse of VerifyContentResponse</returns>
        ApiResponse<VerifyContentResponse> VerifyContentWithHttpInfo (string configName, ContentRequest existence);
        /// <summary>
        /// Verify content using a bytestream/file
        /// </summary>
        /// <remarks>
        /// Verify content by supplying a file or some other binary data. Hashing will be done on the server side
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The configuration name this operation</param>
        /// <param name="stream">The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored</param>
        /// <returns>VerifyContentResponse</returns>
        VerifyContentResponse VerifyStream (string configName, System.IO.Stream stream);

        /// <summary>
        /// Verify content using a bytestream/file
        /// </summary>
        /// <remarks>
        /// Verify content by supplying a file or some other binary data. Hashing will be done on the server side
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The configuration name this operation</param>
        /// <param name="stream">The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored</param>
        /// <returns>ApiResponse of VerifyContentResponse</returns>
        ApiResponse<VerifyContentResponse> VerifyStreamWithHttpInfo (string configName, System.IO.Stream stream);
        /// <summary>
        /// Verify content using a bytestream/file
        /// </summary>
        /// <remarks>
        /// Verify content by supplying a file or some other binary data. Hashing will be done on the server side
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The context for this operation</param>
        /// <param name="streamLocations">The stream locations on storage</param>
        /// <returns>VerifyContentResponse</returns>
        VerifyContentResponse VerifyStreamsOnStorage (string configName, List<StreamLocation> streamLocations);

        /// <summary>
        /// Verify content using a bytestream/file
        /// </summary>
        /// <remarks>
        /// Verify content by supplying a file or some other binary data. Hashing will be done on the server side
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The context for this operation</param>
        /// <param name="streamLocations">The stream locations on storage</param>
        /// <returns>ApiResponse of VerifyContentResponse</returns>
        ApiResponse<VerifyContentResponse> VerifyStreamsOnStorageWithHttpInfo (string configName, List<StreamLocation> streamLocations);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ProofOfExistenceApi : IProofOfExistenceApi
    {
        private Sphereon.SDK.Blockchain.Proof.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProofOfExistenceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProofOfExistenceApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Sphereon.SDK.Blockchain.Proof.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProofOfExistenceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProofOfExistenceApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Sphereon.SDK.Blockchain.Proof.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Sphereon.SDK.Blockchain.Proof.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Verify content 
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The configName for this operation</param>
        /// <param name="existence">Verify content using the current settings</param>
        /// <returns>VerifyContentResponse</returns>
        public VerifyContentResponse VerifyContent (string configName, ContentRequest existence)
        {
             ApiResponse<VerifyContentResponse> localVarResponse = VerifyContentWithHttpInfo(configName, existence);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Verify content 
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The configName for this operation</param>
        /// <param name="existence">Verify content using the current settings</param>
        /// <returns>ApiResponse of VerifyContentResponse</returns>
        public ApiResponse< VerifyContentResponse > VerifyContentWithHttpInfo (string configName, ContentRequest existence)
        {
            // verify the required parameter 'configName' is set
            if (configName == null)
                throw new ApiException(400, "Missing required parameter 'configName' when calling ProofOfExistenceApi->VerifyContent");
            // verify the required parameter 'existence' is set
            if (existence == null)
                throw new ApiException(400, "Missing required parameter 'existence' when calling ProofOfExistenceApi->VerifyContent");

            var localVarPath = "/blockchain/proof/0.9.0-SNAPSHOT/existence/{configName}/content";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (configName != null) localVarPathParams.Add("configName", Configuration.ApiClient.ParameterToString(configName)); // path parameter
            if (existence != null && existence.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(existence); // http body (model) parameter
            }
            else
            {
                localVarPostBody = existence; // byte array
            }

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VerifyContent", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VerifyContentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VerifyContentResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VerifyContentResponse)));
        }

        /// <summary>
        /// Verify content using a bytestream/file Verify content by supplying a file or some other binary data. Hashing will be done on the server side
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The configuration name this operation</param>
        /// <param name="stream">The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored</param>
        /// <returns>VerifyContentResponse</returns>
        public VerifyContentResponse VerifyStream (string configName, System.IO.Stream stream)
        {
             ApiResponse<VerifyContentResponse> localVarResponse = VerifyStreamWithHttpInfo(configName, stream);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Verify content using a bytestream/file Verify content by supplying a file or some other binary data. Hashing will be done on the server side
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The configuration name this operation</param>
        /// <param name="stream">The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored</param>
        /// <returns>ApiResponse of VerifyContentResponse</returns>
        public ApiResponse< VerifyContentResponse > VerifyStreamWithHttpInfo (string configName, System.IO.Stream stream)
        {
            // verify the required parameter 'configName' is set
            if (configName == null)
                throw new ApiException(400, "Missing required parameter 'configName' when calling ProofOfExistenceApi->VerifyStream");
            // verify the required parameter 'stream' is set
            if (stream == null)
                throw new ApiException(400, "Missing required parameter 'stream' when calling ProofOfExistenceApi->VerifyStream");

            var localVarPath = "/blockchain/proof/0.9.0-SNAPSHOT/existence/{configName}/streams/multipart";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (configName != null) localVarPathParams.Add("configName", Configuration.ApiClient.ParameterToString(configName)); // path parameter
            if (stream != null) localVarFileParams.Add("stream", Configuration.ApiClient.ParameterToFile("stream", stream));

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VerifyStream", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VerifyContentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VerifyContentResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VerifyContentResponse)));
        }

        /// <summary>
        /// Verify content using a bytestream/file Verify content by supplying a file or some other binary data. Hashing will be done on the server side
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The context for this operation</param>
        /// <param name="streamLocations">The stream locations on storage</param>
        /// <returns>VerifyContentResponse</returns>
        public VerifyContentResponse VerifyStreamsOnStorage (string configName, List<StreamLocation> streamLocations)
        {
             ApiResponse<VerifyContentResponse> localVarResponse = VerifyStreamsOnStorageWithHttpInfo(configName, streamLocations);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Verify content using a bytestream/file Verify content by supplying a file or some other binary data. Hashing will be done on the server side
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="configName">The context for this operation</param>
        /// <param name="streamLocations">The stream locations on storage</param>
        /// <returns>ApiResponse of VerifyContentResponse</returns>
        public ApiResponse< VerifyContentResponse > VerifyStreamsOnStorageWithHttpInfo (string configName, List<StreamLocation> streamLocations)
        {
            // verify the required parameter 'configName' is set
            if (configName == null)
                throw new ApiException(400, "Missing required parameter 'configName' when calling ProofOfExistenceApi->VerifyStreamsOnStorage");
            // verify the required parameter 'streamLocations' is set
            if (streamLocations == null)
                throw new ApiException(400, "Missing required parameter 'streamLocations' when calling ProofOfExistenceApi->VerifyStreamsOnStorage");

            var localVarPath = "/blockchain/proof/0.9.0-SNAPSHOT/existence/{configName}/streams/location";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (configName != null) localVarPathParams.Add("configName", Configuration.ApiClient.ParameterToString(configName)); // path parameter
            if (streamLocations != null && streamLocations.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(streamLocations); // http body (model) parameter
            }
            else
            {
                localVarPostBody = streamLocations; // byte array
            }

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("VerifyStreamsOnStorage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VerifyContentResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VerifyContentResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VerifyContentResponse)));
        }

    }
}
