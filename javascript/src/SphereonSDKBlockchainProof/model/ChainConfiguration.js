/**
 * Blockchain Proof
 * <b>With the Blockchain Proof API it is easy to prove or disprove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin), Multichain or Ethereum blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a configuration is present  2. Register content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing  3. Verify content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing. You will get back whether the content has been registered previously or not      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
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
    define(['SphereonSDKBlockchainProof/ApiClient'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'));
  } else {
    // Browser globals (root is window)
    if (!root.BlockchainProof) {
      root.BlockchainProof = {};
    }
    root.BlockchainProof.ChainConfiguration = factory(root.BlockchainProof.ApiClient);
  }
}(this, function(ApiClient) {
  'use strict';




  /**
   * The ChainConfiguration model module.
   * @module SphereonSDKBlockchainProof/model/ChainConfiguration
   * @version 0.9
   */

  /**
   * Constructs a new <code>ChainConfiguration</code>.
   * @alias module:SphereonSDKBlockchainProof/model/ChainConfiguration
   * @class
   * @param ownerType {module:SphereonSDKBlockchainProof/model/ChainConfiguration.OwnerTypeEnum} 
   * @param context {String} 
   * @param name {String} 
   * @param settingChainId {String} 
   * @param id {String} 
   */
  var exports = function(ownerType, context, name, settingChainId, id) {
    var _this = this;

    _this['ownerType'] = ownerType;
    _this['context'] = context;
    _this['name'] = name;
    _this['settingChainId'] = settingChainId;
    _this['id'] = id;
  };

  /**
   * Constructs a <code>ChainConfiguration</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:SphereonSDKBlockchainProof/model/ChainConfiguration} obj Optional instance to populate.
   * @return {module:SphereonSDKBlockchainProof/model/ChainConfiguration} The populated <code>ChainConfiguration</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('ownerType')) {
        obj['ownerType'] = ApiClient.convertToType(data['ownerType'], 'String');
      }
      if (data.hasOwnProperty('context')) {
        obj['context'] = ApiClient.convertToType(data['context'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
      if (data.hasOwnProperty('settingChainId')) {
        obj['settingChainId'] = ApiClient.convertToType(data['settingChainId'], 'String');
      }
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {module:SphereonSDKBlockchainProof/model/ChainConfiguration.OwnerTypeEnum} ownerType
   */
  exports.prototype['ownerType'] = undefined;
  /**
   * @member {String} context
   */
  exports.prototype['context'] = undefined;
  /**
   * @member {String} name
   */
  exports.prototype['name'] = undefined;
  /**
   * @member {String} settingChainId
   */
  exports.prototype['settingChainId'] = undefined;
  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;


  /**
   * Allowed values for the <code>ownerType</code> property.
   * @enum {String}
   * @readonly
   */
  exports.OwnerTypeEnum = {
    /**
     * value: "PUBLIC"
     * @const
     */
    "PUBLIC": "PUBLIC",
    /**
     * value: "PRIVATE"
     * @const
     */
    "PRIVATE": "PRIVATE"  };


  return exports;
}));


