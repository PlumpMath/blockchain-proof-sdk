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
    define(['SphereonSDKBlockchainProof/ApiClient', 'SphereonSDKBlockchainProof/model/ChainSettings'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ChainSettings'));
  } else {
    // Browser globals (root is window)
    if (!root.BlockchainProof) {
      root.BlockchainProof = {};
    }
    root.BlockchainProof.CreateConfiguration = factory(root.BlockchainProof.ApiClient, root.BlockchainProof.ChainSettings);
  }
}(this, function(ApiClient, ChainSettings) {
  'use strict';




  /**
   * The CreateConfiguration model module.
   * @module SphereonSDKBlockchainProof/model/CreateConfiguration
   * @version 0.9
   */

  /**
   * Constructs a new <code>CreateConfiguration</code>.
   * Create a context configuration
   * @alias module:SphereonSDKBlockchainProof/model/CreateConfiguration
   * @class
   * @param initialSettings {module:SphereonSDKBlockchainProof/model/ChainSettings} The initial context settings.
   * @param accessLevel {module:SphereonSDKBlockchainProof/model/CreateConfiguration.AccessLevelEnum} 
   * @param context {String} The blockchain context.
   * @param name {String} The configuration name.
   */
  var exports = function(initialSettings, accessLevel, context, name) {
    var _this = this;

    _this['initialSettings'] = initialSettings;
    _this['accessLevel'] = accessLevel;
    _this['context'] = context;
    _this['name'] = name;
  };

  /**
   * Constructs a <code>CreateConfiguration</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:SphereonSDKBlockchainProof/model/CreateConfiguration} obj Optional instance to populate.
   * @return {module:SphereonSDKBlockchainProof/model/CreateConfiguration} The populated <code>CreateConfiguration</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('initialSettings')) {
        obj['initialSettings'] = ChainSettings.constructFromObject(data['initialSettings']);
      }
      if (data.hasOwnProperty('accessLevel')) {
        obj['accessLevel'] = ApiClient.convertToType(data['accessLevel'], 'String');
      }
      if (data.hasOwnProperty('context')) {
        obj['context'] = ApiClient.convertToType(data['context'], 'String');
      }
      if (data.hasOwnProperty('name')) {
        obj['name'] = ApiClient.convertToType(data['name'], 'String');
      }
    }
    return obj;
  }

  /**
   * The initial context settings.
   * @member {module:SphereonSDKBlockchainProof/model/ChainSettings} initialSettings
   */
  exports.prototype['initialSettings'] = undefined;
  /**
   * @member {module:SphereonSDKBlockchainProof/model/CreateConfiguration.AccessLevelEnum} accessLevel
   */
  exports.prototype['accessLevel'] = undefined;
  /**
   * The blockchain context.
   * @member {String} context
   */
  exports.prototype['context'] = undefined;
  /**
   * The configuration name.
   * @member {String} name
   */
  exports.prototype['name'] = undefined;


  /**
   * Allowed values for the <code>accessLevel</code> property.
   * @enum {String}
   * @readonly
   */
  exports.AccessLevelEnum = {
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


