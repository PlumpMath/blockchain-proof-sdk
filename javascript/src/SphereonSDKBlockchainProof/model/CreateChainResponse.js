/**
 * Blockchain Proof
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['SphereonSDKBlockchainProof/ApiClient', 'SphereonSDKBlockchainProof/model/CommittedChain', 'SphereonSDKBlockchainProof/model/CreateChainRequest'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./CommittedChain'), require('./CreateChainRequest'));
  } else {
    // Browser globals (root is window)
    if (!root.BlockchainProof) {
      root.BlockchainProof = {};
    }
    root.BlockchainProof.CreateChainResponse = factory(root.BlockchainProof.ApiClient, root.BlockchainProof.CommittedChain, root.BlockchainProof.CreateChainRequest);
  }
}(this, function(ApiClient, CommittedChain, CreateChainRequest) {
  'use strict';




  /**
   * The CreateChainResponse model module.
   * @module SphereonSDKBlockchainProof/model/CreateChainResponse
   * @version 0.1.0
   */

  /**
   * Constructs a new <code>CreateChainResponse</code>.
   * Committed Chain response
   * @alias module:SphereonSDKBlockchainProof/model/CreateChainResponse
   * @class
   * @param settingsChain {module:SphereonSDKBlockchainProof/model/CommittedChain} 
   * @param chainRequest {module:SphereonSDKBlockchainProof/model/CreateChainRequest} 
   * @param proofChain {module:SphereonSDKBlockchainProof/model/CommittedChain} 
   */
  var exports = function(settingsChain, chainRequest, proofChain) {
    var _this = this;

    _this['settingsChain'] = settingsChain;
    _this['chainRequest'] = chainRequest;
    _this['proofChain'] = proofChain;
  };

  /**
   * Constructs a <code>CreateChainResponse</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:SphereonSDKBlockchainProof/model/CreateChainResponse} obj Optional instance to populate.
   * @return {module:SphereonSDKBlockchainProof/model/CreateChainResponse} The populated <code>CreateChainResponse</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();

      if (data.hasOwnProperty('settingsChain')) {
        obj['settingsChain'] = CommittedChain.constructFromObject(data['settingsChain']);
      }
      if (data.hasOwnProperty('chainRequest')) {
        obj['chainRequest'] = CreateChainRequest.constructFromObject(data['chainRequest']);
      }
      if (data.hasOwnProperty('proofChain')) {
        obj['proofChain'] = CommittedChain.constructFromObject(data['proofChain']);
      }
    }
    return obj;
  }

  /**
   * @member {module:SphereonSDKBlockchainProof/model/CommittedChain} settingsChain
   */
  exports.prototype['settingsChain'] = undefined;
  /**
   * @member {module:SphereonSDKBlockchainProof/model/CreateChainRequest} chainRequest
   */
  exports.prototype['chainRequest'] = undefined;
  /**
   * @member {module:SphereonSDKBlockchainProof/model/CommittedChain} proofChain
   */
  exports.prototype['proofChain'] = undefined;



  return exports;
}));

