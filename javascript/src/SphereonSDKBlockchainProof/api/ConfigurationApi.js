/**
 * Blockchain Proof
 * With the Blockchain Proof API it is easy to prove or disprove existence of data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin), Multichain or Ethereum blockchain by means of our generic blockchain API.    The flow is generally as follows:  1. Make sure a configuration is present  2. Register content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing  3. Verify content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing. You will get back whether the content has been registered previously or not    Full API Documentation: https://docs.sphereon.com/api/blockchain-proof/0.9/html  Interactive testing: A web based test console is available in the Sphereon API Store at https://store.sphereon.com
 *
 * OpenAPI spec version: 0.9
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.2.3
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['SphereonSDKBlockchainProof/ApiClient', 'SphereonSDKBlockchainProof/model/ConfigurationResponse', 'SphereonSDKBlockchainProof/model/CreateConfigurationRequest', 'SphereonSDKBlockchainProof/model/ErrorResponse'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/ConfigurationResponse'), require('../model/CreateConfigurationRequest'), require('../model/ErrorResponse'));
  } else {
    // Browser globals (root is window)
    if (!root.BlockchainProof) {
      root.BlockchainProof = {};
    }
    root.BlockchainProof.ConfigurationApi = factory(root.BlockchainProof.ApiClient, root.BlockchainProof.ConfigurationResponse, root.BlockchainProof.CreateConfigurationRequest, root.BlockchainProof.ErrorResponse);
  }
}(this, function(ApiClient, ConfigurationResponse, CreateConfigurationRequest, ErrorResponse) {
  'use strict';

  /**
   * Configuration service.
   * @module SphereonSDKBlockchainProof/api/ConfigurationApi
   * @version 0.9
   */

  /**
   * Constructs a new ConfigurationApi. 
   * @alias module:SphereonSDKBlockchainProof/api/ConfigurationApi
   * @class
   * @param {module:SphereonSDKBlockchainProof/ApiClient} apiClient Optional API client implementation to use,
   * default to {@link module:SphereonSDKBlockchainProof/ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the createConfiguration operation.
     * @callback module:SphereonSDKBlockchainProof/api/ConfigurationApi~createConfigurationCallback
     * @param {String} error Error message, if any.
     * @param {module:SphereonSDKBlockchainProof/model/ConfigurationResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Create a new configuration
     * Create a new configuration
     * @param {module:SphereonSDKBlockchainProof/model/CreateConfigurationRequest} request Create a new Proof of Existence configuration using the provided settings. The context points to a context of the Easy Blockchain API. When you have no own context, simply use &#39;multichain&#39; without the quotes as context. You will be using our multichain ledger then, which is recomended during development/testing
     * @param {module:SphereonSDKBlockchainProof/api/ConfigurationApi~createConfigurationCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:SphereonSDKBlockchainProof/model/ConfigurationResponse}
     */
    this.createConfiguration = function(request, callback) {
      var postBody = request;

      // verify the required parameter 'request' is set
      if (request === undefined || request === null) {
        throw new Error("Missing the required parameter 'request' when calling createConfiguration");
      }


      var pathParams = {
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth2schema'];
      var contentTypes = ['application/json;charset=UTF-8'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = ConfigurationResponse;

      return this.apiClient.callApi(
        '/config', 'POST',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the getConfiguration operation.
     * @callback module:SphereonSDKBlockchainProof/api/ConfigurationApi~getConfigurationCallback
     * @param {String} error Error message, if any.
     * @param {module:SphereonSDKBlockchainProof/model/ConfigurationResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Get configuration
     * Get the configuration for registration/verification
     * @param {String} configName The configuration name this operation
     * @param {module:SphereonSDKBlockchainProof/api/ConfigurationApi~getConfigurationCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:SphereonSDKBlockchainProof/model/ConfigurationResponse}
     */
    this.getConfiguration = function(configName, callback) {
      var postBody = null;

      // verify the required parameter 'configName' is set
      if (configName === undefined || configName === null) {
        throw new Error("Missing the required parameter 'configName' when calling getConfiguration");
      }


      var pathParams = {
        'configName': configName
      };
      var queryParams = {
      };
      var headerParams = {
      };
      var formParams = {
      };

      var authNames = ['oauth2schema'];
      var contentTypes = ['application/json'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = ConfigurationResponse;

      return this.apiClient.callApi(
        '/config/{configName}', 'GET',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
