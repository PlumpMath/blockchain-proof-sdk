/**
 * Sphereon :: BLOCKCHAIN :: PROOF API
 * <b>The Blockchain Proof API is an easy to prove existence of (binary) data at a certain point in time. Behinde the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
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

(function(factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['Sphereon-SDK-Blockchain-Proof/ApiClient', 'Sphereon-SDK-Blockchain-Proof/model/CommittedChain', 'Sphereon-SDK-Blockchain-Proof/model/ContentRequest', 'Sphereon-SDK-Blockchain-Proof/model/CreateChainRequest', 'Sphereon-SDK-Blockchain-Proof/model/CreateChainResponse', 'Sphereon-SDK-Blockchain-Proof/model/Link', 'Sphereon-SDK-Blockchain-Proof/model/RegisterContentResponse', 'Sphereon-SDK-Blockchain-Proof/model/Settings', 'Sphereon-SDK-Blockchain-Proof/model/VerifyContentResponse', 'Sphereon-SDK-Blockchain-Proof/model/VndError', 'Sphereon-SDK-Blockchain-Proof/model/VndErrors', 'Sphereon-SDK-Blockchain-Proof/api/ProofOfExistenceApi'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('./ApiClient'), require('./model/CommittedChain'), require('./model/ContentRequest'), require('./model/CreateChainRequest'), require('./model/CreateChainResponse'), require('./model/Link'), require('./model/RegisterContentResponse'), require('./model/Settings'), require('./model/VerifyContentResponse'), require('./model/VndError'), require('./model/VndErrors'), require('./api/ProofOfExistenceApi'));
  }
}(function(ApiClient, CommittedChain, ContentRequest, CreateChainRequest, CreateChainResponse, Link, RegisterContentResponse, Settings, VerifyContentResponse, VndError, VndErrors, ProofOfExistenceApi) {
  'use strict';

  /**
   * bThe_Blockchain_Proof_API_is_an_easy_to_prove_existence_of__binary_data_at_a_certain_point_in_time__Behinde_the_scenes_it_stores_entries_using_the_Factom__bitcoin_blockchain_by_means_of_our_generic_blockchain_API_bThe_flow_is_generally_as_follows1__Make_sure_a_Proof_chain_has_been_created_using_the_chain_POST_endpoint_beforehand__Normally_you_only_need_one_or_a_handful_of_chains_during_the_entiry_lifetime_of_your_proof_solution__This_is_a_relative_expensive_operation_in_terms_of_money_2__Store_proof_entries_on_the_proof_chain_from_step_1__The_entries_will_contain_the_content_and_metadata_you_want_to_store_forever_on_the_specified_chain_3__Retrieve_an_existing_entry_from_the_chain_to_verify_or_retrieve_databInteractive_testing_bA_web_based_test_console_is_available_in_the_a_hrefhttpsstore_sphereon_comSphereon_API_Storea.<br>
   * The <code>index</code> module provides access to constructors for all the classes which comprise the public API.
   * <p>
   * An AMD (recommended!) or CommonJS application will generally do something equivalent to the following:
   * <pre>
   * var SphereonBlockchainProofApi = require('Sphereon-SDK-Blockchain-Proof/index'); // See note below*.
   * var xxxSvc = new SphereonBlockchainProofApi.XxxApi(); // Allocate the API class we're going to use.
   * var yyyModel = new SphereonBlockchainProofApi.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * <em>*NOTE: For a top-level AMD script, use require(['Sphereon-SDK-Blockchain-Proof/index'], function(){...})
   * and put the application logic within the callback function.</em>
   * </p>
   * <p>
   * A non-AMD browser application (discouraged) might do something like this:
   * <pre>
   * var xxxSvc = new SphereonBlockchainProofApi.XxxApi(); // Allocate the API class we're going to use.
   * var yyy = new SphereonBlockchainProofApi.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * </p>
   * @module Sphereon-SDK-Blockchain-Proof/index
   * @version 0.1.0
   */
  var exports = {
    /**
     * The ApiClient constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/ApiClient}
     */
    ApiClient: ApiClient,
    /**
     * The CommittedChain model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/CommittedChain}
     */
    CommittedChain: CommittedChain,
    /**
     * The ContentRequest model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/ContentRequest}
     */
    ContentRequest: ContentRequest,
    /**
     * The CreateChainRequest model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/CreateChainRequest}
     */
    CreateChainRequest: CreateChainRequest,
    /**
     * The CreateChainResponse model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/CreateChainResponse}
     */
    CreateChainResponse: CreateChainResponse,
    /**
     * The Link model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/Link}
     */
    Link: Link,
    /**
     * The RegisterContentResponse model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/RegisterContentResponse}
     */
    RegisterContentResponse: RegisterContentResponse,
    /**
     * The Settings model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/Settings}
     */
    Settings: Settings,
    /**
     * The VerifyContentResponse model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/VerifyContentResponse}
     */
    VerifyContentResponse: VerifyContentResponse,
    /**
     * The VndError model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/VndError}
     */
    VndError: VndError,
    /**
     * The VndErrors model constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/model/VndErrors}
     */
    VndErrors: VndErrors,
    /**
     * The ProofOfExistenceApi service constructor.
     * @property {module:Sphereon-SDK-Blockchain-Proof/api/ProofOfExistenceApi}
     */
    ProofOfExistenceApi: ProofOfExistenceApi
  };

  return exports;
}));
