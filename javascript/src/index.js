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

(function(factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['SphereonSDKBlockchainProof/ApiClient', 'SphereonSDKBlockchainProof/model/ChainConfiguration', 'SphereonSDKBlockchainProof/model/ChainSettings', 'SphereonSDKBlockchainProof/model/CommittedChain', 'SphereonSDKBlockchainProof/model/ConfigurationResponse', 'SphereonSDKBlockchainProof/model/ContentRequest', 'SphereonSDKBlockchainProof/model/CreateConfiguration', 'SphereonSDKBlockchainProof/model/Error', 'SphereonSDKBlockchainProof/model/ErrorResponse', 'SphereonSDKBlockchainProof/model/RegisterContentResponse', 'SphereonSDKBlockchainProof/model/StoredSettings', 'SphereonSDKBlockchainProof/model/StreamLocation', 'SphereonSDKBlockchainProof/model/VerifyContentResponse', 'SphereonSDKBlockchainProof/api/ConfigurationApi', 'SphereonSDKBlockchainProof/api/RegistrationApi', 'SphereonSDKBlockchainProof/api/VerificationApi'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('./ApiClient'), require('./model/ChainConfiguration'), require('./model/ChainSettings'), require('./model/CommittedChain'), require('./model/ConfigurationResponse'), require('./model/ContentRequest'), require('./model/CreateConfiguration'), require('./model/Error'), require('./model/ErrorResponse'), require('./model/RegisterContentResponse'), require('./model/StoredSettings'), require('./model/StreamLocation'), require('./model/VerifyContentResponse'), require('./api/ConfigurationApi'), require('./api/RegistrationApi'), require('./api/VerificationApi'));
  }
}(function(ApiClient, ChainConfiguration, ChainSettings, CommittedChain, ConfigurationResponse, ContentRequest, CreateConfiguration, Error, ErrorResponse, RegisterContentResponse, StoredSettings, StreamLocation, VerifyContentResponse, ConfigurationApi, RegistrationApi, VerificationApi) {
  'use strict';

  /**
   * bWith_the_Blockchain_Proof_API_it_is_easy_to_prove_or_disprove_existence_of__binary_data_at_a_certain_point_in_time__Behind_the_scenes_it_stores_entries_using_the_Factom__bitcoin_Multichain_or_Ethereum_blockchain_by_means_of_our_generic_blockchain_API_bThe_flow_is_generally_as_follows1__Make_sure_a_configuration_is_present2__Register_content_by_uploading_a_file_some_content_or_providing_a_Stream_Location_from_the_Storage_API__When_you_upload_content_you_have_to_tell_the_API_whether_the_data_has_already_been_hashed_or_not__If_not_or_when_uploading_a_file_or_stream_location_the_API_will_take_care_of_the_hashing3__Verify_content_by_uploading_a_file_some_content_or_providing_a_Stream_Location_from_the_Storage_API__When_you_upload_content_you_have_to_tell_the_API_whether_the_data_has_already_been_hashed_or_not__If_not_or_when_uploading_a_file_or_stream_location_the_API_will_take_care_of_the_hashing__You_will_get_back_whether_the_content_has_been_registered_previously_or_notbInteractive_testing_bA_web_based_test_console_is_available_in_the_a_hrefhttpsstore_sphereon_comSphereon_API_Storea.<br>
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
   * @version 0.9
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
     * The ConfigurationApi service constructor.
     * @property {module:SphereonSDKBlockchainProof/api/ConfigurationApi}
     */
    ConfigurationApi: ConfigurationApi,
    /**
     * The RegistrationApi service constructor.
     * @property {module:SphereonSDKBlockchainProof/api/RegistrationApi}
     */
    RegistrationApi: RegistrationApi,
    /**
     * The VerificationApi service constructor.
     * @property {module:SphereonSDKBlockchainProof/api/VerificationApi}
     */
    VerificationApi: VerificationApi
  };

  return exports;
}));
