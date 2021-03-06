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
    define(['SphereonSDKBlockchainProof/ApiClient', 'SphereonSDKBlockchainProof/model/ContentRequest', 'SphereonSDKBlockchainProof/model/ErrorResponse', 'SphereonSDKBlockchainProof/model/RegisterContentResponse', 'SphereonSDKBlockchainProof/model/StreamLocation'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('../model/ContentRequest'), require('../model/ErrorResponse'), require('../model/RegisterContentResponse'), require('../model/StreamLocation'));
  } else {
    // Browser globals (root is window)
    if (!root.BlockchainProof) {
      root.BlockchainProof = {};
    }
    root.BlockchainProof.RegistrationApi = factory(root.BlockchainProof.ApiClient, root.BlockchainProof.ContentRequest, root.BlockchainProof.ErrorResponse, root.BlockchainProof.RegisterContentResponse, root.BlockchainProof.StreamLocation);
  }
}(this, function(ApiClient, ContentRequest, ErrorResponse, RegisterContentResponse, StreamLocation) {
  'use strict';

  /**
   * Registration service.
   * @module SphereonSDKBlockchainProof/api/RegistrationApi
   * @version 0.9
   */

  /**
   * Constructs a new RegistrationApi. 
   * @alias module:SphereonSDKBlockchainProof/api/RegistrationApi
   * @class
   * @param {module:SphereonSDKBlockchainProof/ApiClient} apiClient Optional API client implementation to use,
   * default to {@link module:SphereonSDKBlockchainProof/ApiClient#instance} if unspecified.
   */
  var exports = function(apiClient) {
    this.apiClient = apiClient || ApiClient.instance;


    /**
     * Callback function to receive the result of the registerUsingContent operation.
     * @callback module:SphereonSDKBlockchainProof/api/RegistrationApi~registerUsingContentCallback
     * @param {String} error Error message, if any.
     * @param {module:SphereonSDKBlockchainProof/model/RegisterContentResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Register content
     * Register content. Please provide the content in the request. You also have to provide whether you have hashed the content yourself, or whether is should be done on the server side
     * @param {String} configName The configuration name this operation
     * @param {module:SphereonSDKBlockchainProof/model/ContentRequest} existence Register content using the current settings
     * @param {module:SphereonSDKBlockchainProof/api/RegistrationApi~registerUsingContentCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:SphereonSDKBlockchainProof/model/RegisterContentResponse}
     */
    this.registerUsingContent = function(configName, existence, callback) {
      var postBody = existence;

      // verify the required parameter 'configName' is set
      if (configName === undefined || configName === null) {
        throw new Error("Missing the required parameter 'configName' when calling registerUsingContent");
      }

      // verify the required parameter 'existence' is set
      if (existence === undefined || existence === null) {
        throw new Error("Missing the required parameter 'existence' when calling registerUsingContent");
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
      var contentTypes = ['application/json;charset=UTF-8'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = RegisterContentResponse;

      return this.apiClient.callApi(
        '/existence/{configName}/content', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the registerUsingLocation operation.
     * @callback module:SphereonSDKBlockchainProof/api/RegistrationApi~registerUsingLocationCallback
     * @param {String} error Error message, if any.
     * @param {module:SphereonSDKBlockchainProof/model/RegisterContentResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Register hash using the Storage API
     * Register a convertInputToHashWhenNeeded of file/blob by supplying a Stream location of the Storage API. This Stream Location maps to a location of a file/blob on some remote cloud storage. Hashing will be done on the server side Please note that the binary data itself will not be stored, only the convertInputToHashWhenNeeded. Use the registerUsingContent endpoint if you&#39;d like to store content
     * @param {String} configName The configuration name this operation
     * @param {Array.<module:SphereonSDKBlockchainProof/model/StreamLocation>} streamLocations The stream locations on storage
     * @param {module:SphereonSDKBlockchainProof/api/RegistrationApi~registerUsingLocationCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:SphereonSDKBlockchainProof/model/RegisterContentResponse}
     */
    this.registerUsingLocation = function(configName, streamLocations, callback) {
      var postBody = streamLocations;

      // verify the required parameter 'configName' is set
      if (configName === undefined || configName === null) {
        throw new Error("Missing the required parameter 'configName' when calling registerUsingLocation");
      }

      // verify the required parameter 'streamLocations' is set
      if (streamLocations === undefined || streamLocations === null) {
        throw new Error("Missing the required parameter 'streamLocations' when calling registerUsingLocation");
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
      var contentTypes = ['application/json;charset=UTF-8'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = RegisterContentResponse;

      return this.apiClient.callApi(
        '/existence/{configName}/streams/location', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }

    /**
     * Callback function to receive the result of the registerUsingStream operation.
     * @callback module:SphereonSDKBlockchainProof/api/RegistrationApi~registerUsingStreamCallback
     * @param {String} error Error message, if any.
     * @param {module:SphereonSDKBlockchainProof/model/RegisterContentResponse} data The data returned by the service call.
     * @param {String} response The complete HTTP response.
     */

    /**
     * Register bytestream/file hash
     * Register a convertInputToHashWhenNeeded of content by supplying a file or some other binary data. Hashing will be done on the server side. Please note that the binary data itself will not be stored, only the convertInputToHashWhenNeeded. Use the registerUsingContent endpoint if you&#39;d like to store content
     * @param {String} configName The configuration name this operation
     * @param {File} stream The binary data (not hashed). Hashing will be done on the server side. The binary data will not be stored
     * @param {Object} opts Optional parameters
     * @param {String} opts.fileName Optional input file name. Needed when using bytestreams instead of filestreams
     * @param {module:SphereonSDKBlockchainProof/api/RegistrationApi~registerUsingStreamCallback} callback The callback function, accepting three arguments: error, data, response
     * data is of type: {@link module:SphereonSDKBlockchainProof/model/RegisterContentResponse}
     */
    this.registerUsingStream = function(configName, stream, opts, callback) {
      opts = opts || {};
      var postBody = null;

      // verify the required parameter 'configName' is set
      if (configName === undefined || configName === null) {
        throw new Error("Missing the required parameter 'configName' when calling registerUsingStream");
      }

      // verify the required parameter 'stream' is set
      if (stream === undefined || stream === null) {
        throw new Error("Missing the required parameter 'stream' when calling registerUsingStream");
      }


      var pathParams = {
        'configName': configName
      };
      var queryParams = {
        'fileName': opts['fileName']
      };
      var headerParams = {
      };
      var formParams = {
        'stream': stream
      };

      var authNames = ['oauth2schema'];
      var contentTypes = ['multipart/form-data'];
      var accepts = ['application/json;charset=UTF-8'];
      var returnType = RegisterContentResponse;

      return this.apiClient.callApi(
        '/existence/{configName}/streams/multipart', 'PUT',
        pathParams, queryParams, headerParams, formParams, postBody,
        authNames, contentTypes, accepts, returnType, callback
      );
    }
  };

  return exports;
}));
