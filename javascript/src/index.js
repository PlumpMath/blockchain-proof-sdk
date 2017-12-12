/**
 * Blockchain Proof
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9.0-SNAPSHOT
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

(function(factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['SphereonSDKBlockchainProof/ApiClient', 'SphereonSDKBlockchainProof/model/ChainConfiguration', 'SphereonSDKBlockchainProof/model/ChainSettings', 'SphereonSDKBlockchainProof/model/CommittedChain', 'SphereonSDKBlockchainProof/model/ConfigurationResponse', 'SphereonSDKBlockchainProof/model/ContentRequest', 'SphereonSDKBlockchainProof/model/CreateConfiguration', 'SphereonSDKBlockchainProof/model/Error', 'SphereonSDKBlockchainProof/model/ErrorResponse', 'SphereonSDKBlockchainProof/model/RegisterContentResponse', 'SphereonSDKBlockchainProof/model/StoredSettings', 'SphereonSDKBlockchainProof/model/StreamLocation', 'SphereonSDKBlockchainProof/model/VerifyContentResponse', 'SphereonSDKBlockchainProof/api/AllApi', 'SphereonSDKBlockchainProof/api/ConfigurationApi', 'SphereonSDKBlockchainProof/api/ProofOfExistenceApi', 'SphereonSDKBlockchainProof/api/RegistrationApi'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('./ApiClient'), require('./model/ChainConfiguration'), require('./model/ChainSettings'), require('./model/CommittedChain'), require('./model/ConfigurationResponse'), require('./model/ContentRequest'), require('./model/CreateConfiguration'), require('./model/Error'), require('./model/ErrorResponse'), require('./model/RegisterContentResponse'), require('./model/StoredSettings'), require('./model/StreamLocation'), require('./model/VerifyContentResponse'), require('./api/AllApi'), require('./api/ConfigurationApi'), require('./api/ProofOfExistenceApi'), require('./api/RegistrationApi'));
  }
}(function(ApiClient, ChainConfiguration, ChainSettings, CommittedChain, ConfigurationResponse, ContentRequest, CreateConfiguration, Error, ErrorResponse, RegisterContentResponse, StoredSettings, StreamLocation, VerifyContentResponse, AllApi, ConfigurationApi, ProofOfExistenceApi, RegistrationApi) {
  'use strict';

  /**
   * bWith_the_Blockchain_Proof_API_it_is_easy_to_prove_existence_of__binary_data_at_a_certain_point_in_time__Behind_the_scenes_it_stores_entries_using_the_Factom__bitcoin_blockchain_by_means_of_our_generic_blockchain_API_bThe_flow_is_generally_as_follows1__Make_sure_a_Proof_chain_has_been_created_using_the_chain_POST_endpoint_beforehand__Normally_you_only_need_one_or_a_handful_of_chains_during_the_entiry_lifetime_of_your_proof_solution__This_is_a_relative_expensive_operation_in_terms_of_money_2__Store_proof_entries_on_the_proof_chain_from_step_1__The_entries_will_contain_the_content_and_metadata_you_want_to_store_forever_on_the_specified_chain_3__Retrieve_an_existing_entry_from_the_chain_to_verify_or_retrieve_databInteractive_testing_bA_web_based_test_console_is_available_in_the_a_hrefhttpsstore_sphereon_comSphereon_API_Storea.<br>
   * The <code>index</code> module provides access to constructors for all the classes which comprise the public API.
   * <p>
   * An AMD (recommended!) or CommonJS application will generally do something equivalent to the following:
   * <pre>
   * var BlockchainProof = require('SphereonSDKBlockchainProof/index'); // See note below*.
   * var xxxSvc = new BlockchainProof.XxxApi(); // Allocate the API class we're going to use.
   * var yyyModel = new BlockchainProof.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * <em>*NOTE: For a top-level AMD script, use require(['SphereonSDKBlockchainProof/index'], function(){...})
   * and put the application logic within the callback function.</em>
   * </p>
   * <p>
   * A non-AMD browser application (discouraged) might do something like this:
   * <pre>
   * var xxxSvc = new BlockchainProof.XxxApi(); // Allocate the API class we're going to use.
   * var yyy = new BlockchainProof.Yyy(); // Construct a model instance.
   * yyyModel.someProperty = 'someValue';
   * ...
   * var zzz = xxxSvc.doSomething(yyyModel); // Invoke the service.
   * ...
   * </pre>
   * </p>
   * @module SphereonSDKBlockchainProof/index
   * @version 0.9.0-SNAPSHOT
   */
  var exports = {
    /**
     * The ApiClient constructor.
     * @property {module:SphereonSDKBlockchainProof/ApiClient}
     */
    ApiClient: ApiClient,
    /**
     * The ChainConfiguration model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/ChainConfiguration}
     */
    ChainConfiguration: ChainConfiguration,
    /**
     * The ChainSettings model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/ChainSettings}
     */
    ChainSettings: ChainSettings,
    /**
     * The CommittedChain model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/CommittedChain}
     */
    CommittedChain: CommittedChain,
    /**
     * The ConfigurationResponse model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/ConfigurationResponse}
     */
    ConfigurationResponse: ConfigurationResponse,
    /**
     * The ContentRequest model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/ContentRequest}
     */
    ContentRequest: ContentRequest,
    /**
     * The CreateConfiguration model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/CreateConfiguration}
     */
    CreateConfiguration: CreateConfiguration,
    /**
     * The Error model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/Error}
     */
    Error: Error,
    /**
     * The ErrorResponse model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/ErrorResponse}
     */
    ErrorResponse: ErrorResponse,
    /**
     * The RegisterContentResponse model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/RegisterContentResponse}
     */
    RegisterContentResponse: RegisterContentResponse,
    /**
     * The StoredSettings model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/StoredSettings}
     */
    StoredSettings: StoredSettings,
    /**
     * The StreamLocation model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/StreamLocation}
     */
    StreamLocation: StreamLocation,
    /**
     * The VerifyContentResponse model constructor.
     * @property {module:SphereonSDKBlockchainProof/model/VerifyContentResponse}
     */
    VerifyContentResponse: VerifyContentResponse,
    /**
     * The AllApi service constructor.
     * @property {module:SphereonSDKBlockchainProof/api/AllApi}
     */
    AllApi: AllApi,
    /**
     * The ConfigurationApi service constructor.
     * @property {module:SphereonSDKBlockchainProof/api/ConfigurationApi}
     */
    ConfigurationApi: ConfigurationApi,
    /**
     * The ProofOfExistenceApi service constructor.
     * @property {module:SphereonSDKBlockchainProof/api/ProofOfExistenceApi}
     */
    ProofOfExistenceApi: ProofOfExistenceApi,
    /**
     * The RegistrationApi service constructor.
     * @property {module:SphereonSDKBlockchainProof/api/RegistrationApi}
     */
    RegistrationApi: RegistrationApi
  };

  return exports;
}));
