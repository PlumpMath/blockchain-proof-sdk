/**
 * Blockchain Proof
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
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
    define(['SphereonSDKBlockchainProof/ApiClient', 'SphereonSDKBlockchainProof/model/CommittedChain', 'SphereonSDKBlockchainProof/model/ContentRequest'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CommittedChain'), require('./ContentRequest'));
  } else {
    // Browser globals (root is window)
    if (!root.BlockchainProof) {
      root.BlockchainProof = {};
    }
    root.BlockchainProof.RegisterContentResponse = factory(root.BlockchainProof.ApiClient, root.BlockchainProof.CommittedChain, root.BlockchainProof.ContentRequest);
  }
}(this, function(ApiClient, CommittedChain, ContentRequest) {
  'use strict';




  /**
   * The RegisterContentResponse model module.
   * @module SphereonSDKBlockchainProof/model/RegisterContentResponse
   * @version 0.1.0
   */

  /**
   * Constructs a new <code>RegisterContentResponse</code>.
   * Committed Content response
   * @alias module:SphereonSDKBlockchainProof/model/RegisterContentResponse
   * @class
   * @param contentRequest {module:SphereonSDKBlockchainProof/model/ContentRequest} 
   * @param proofChain {module:SphereonSDKBlockchainProof/model/CommittedChain} 
   * @param registrationState {module:SphereonSDKBlockchainProof/model/RegisterContentResponse.RegistrationStateEnum} 
   */
  var exports = function(contentRequest, proofChain, registrationState) {
    var _this = this;

    _this['contentRequest'] = contentRequest;
    _this['proofChain'] = proofChain;
    _this['registrationState'] = registrationState;
  };

  /**
   * Constructs a <code>RegisterContentResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:SphereonSDKBlockchainProof/model/RegisterContentResponse} obj Optional instance to populate.
   * @return {module:SphereonSDKBlockchainProof/model/RegisterContentResponse} The populated <code>RegisterContentResponse</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('contentRequest')) {
        obj['contentRequest'] = ContentRequest.constructFromObject(data['contentRequest']);
      }
      if (data.hasOwnProperty('proofChain')) {
        obj['proofChain'] = CommittedChain.constructFromObject(data['proofChain']);
      }
      if (data.hasOwnProperty('registrationState')) {
        obj['registrationState'] = ApiClient.convertToType(data['registrationState'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {module:SphereonSDKBlockchainProof/model/ContentRequest} contentRequest
   */
  exports.prototype['contentRequest'] = undefined;
  /**
   * @member {module:SphereonSDKBlockchainProof/model/CommittedChain} proofChain
   */
  exports.prototype['proofChain'] = undefined;
  /**
   * @member {module:SphereonSDKBlockchainProof/model/RegisterContentResponse.RegistrationStateEnum} registrationState
   */
  exports.prototype['registrationState'] = undefined;


  /**
   * Allowed values for the <code>registrationState</code> property.
   * @enum {String}
   * @readonly
   */
  exports.RegistrationStateEnum = {
    /**
     * value: "PENDING"
     * @const
     */
    "PENDING": "PENDING",
    /**
     * value: "REGISTERED"
     * @const
     */
    "REGISTERED": "REGISTERED",
    /**
     * value: "NOT_REGISTERED"
     * @const
     */
    "NOT_REGISTERED": "NOT_REGISTERED"  };


  return exports;
}));


