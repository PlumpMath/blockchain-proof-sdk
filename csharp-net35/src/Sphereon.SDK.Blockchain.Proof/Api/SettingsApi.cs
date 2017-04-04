/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
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
    public interface ISettingsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get the settings for registration/verification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId">This is the chain where the content is registered/verified</param>
        /// <returns>SettingsResponse</returns>
        SettingsResponse Settings (string chainId);

        /// <summary>
        /// Get the settings for registration/verification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId">This is the chain where the content is registered/verified</param>
        /// <returns>ApiResponse of SettingsResponse</returns>
        ApiResponse<SettingsResponse> SettingsWithHttpInfo (string chainId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get the settings for registration/verification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId">This is the chain where the content is registered/verified</param>
        /// <returns>Task of SettingsResponse</returns>
        System.Threading.Tasks.Task<SettingsResponse> SettingsAsync (string chainId);

        /// <summary>
        /// Get the settings for registration/verification
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId">This is the chain where the content is registered/verified</param>
        /// <returns>Task of ApiResponse (SettingsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SettingsResponse>> SettingsAsyncWithHttpInfo (string chainId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SettingsApi : ISettingsApi
    {
        private Sphereon.SDK.Blockchain.Proof.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SettingsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="SettingsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SettingsApi(Configuration configuration = null)
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
        /// Get the settings for registration/verification 
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId">This is the chain where the content is registered/verified</param>
        /// <returns>SettingsResponse</returns>
        public SettingsResponse Settings (string chainId)
        {
             ApiResponse<SettingsResponse> localVarResponse = SettingsWithHttpInfo(chainId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the settings for registration/verification 
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId">This is the chain where the content is registered/verified</param>
        /// <returns>ApiResponse of SettingsResponse</returns>
        public ApiResponse< SettingsResponse > SettingsWithHttpInfo (string chainId)
        {
            // verify the required parameter 'chainId' is set
            if (chainId == null)
                throw new ApiException(400, "Missing required parameter 'chainId' when calling SettingsApi->Settings");

            var localVarPath = "/blockchain/proof/0.1.0/existence/{chainId}/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chainId != null) localVarPathParams.Add("chainId", Configuration.ApiClient.ParameterToString(chainId)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Settings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SettingsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SettingsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SettingsResponse)));
            
        }

        /// <summary>
        /// Get the settings for registration/verification 
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId">This is the chain where the content is registered/verified</param>
        /// <returns>Task of SettingsResponse</returns>
        public async System.Threading.Tasks.Task<SettingsResponse> SettingsAsync (string chainId)
        {
             ApiResponse<SettingsResponse> localVarResponse = await SettingsAsyncWithHttpInfo(chainId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the settings for registration/verification 
        /// </summary>
        /// <exception cref="Sphereon.SDK.Blockchain.Proof.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="chainId">This is the chain where the content is registered/verified</param>
        /// <returns>Task of ApiResponse (SettingsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SettingsResponse>> SettingsAsyncWithHttpInfo (string chainId)
        {
            // verify the required parameter 'chainId' is set
            if (chainId == null)
                throw new ApiException(400, "Missing required parameter 'chainId' when calling SettingsApi->Settings");

            var localVarPath = "/blockchain/proof/0.1.0/existence/{chainId}/settings";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (chainId != null) localVarPathParams.Add("chainId", Configuration.ApiClient.ParameterToString(chainId)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Settings", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SettingsResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SettingsResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SettingsResponse)));
            
        }

    }
}
