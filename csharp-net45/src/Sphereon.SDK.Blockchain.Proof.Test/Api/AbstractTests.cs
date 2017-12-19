﻿/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove or disprove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin), Multichain or Ethereum blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a configuration is present  2. Register content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing  3. Verify content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing. You will get back whether the content has been registered previously or not      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using NUnit.Framework;
using Sphereon.SDK.Blockchain.Proof.Api;
using Sphereon.SDK.Blockchain.Proof.Client;
using Sphereon.SDK.Blockchain.Proof.Model;

namespace Sphereon.SDK.Blockchain.Proof.Test.Api
{
    public abstract class AbstractTests
    {
        protected const string TestConfigBasename = "sphereoncstest";
        protected const string TestContextMultichain = "multichain";

        protected static string FixedAccessToken =
            Environment.GetEnvironmentVariable("tests.dotnet.bcproof.accesstoken");

        protected static string UnitTestConfigName;
        protected static byte[] RegisteredContent;
        protected static byte[] RegisteredContentForStream;
        protected static string SettingsChainId;
        protected static string ProofChainId;
        protected static ConfigurationApi _configurationApi;

        static AbstractTests()
        {
            UnitTestConfigName = TestConfigBasename + DateTime.Now.Ticks / 1000;
        }

        protected StoredSettings CreateProofAndSettingsChain()
        {
            var settings = new ChainSettings(Version: ChainSettings.VersionEnum.NUMBER_1)
            {
                HashAlgorithm = ChainSettings.HashAlgorithmEnum._256,
                ContentRegistrationChains = new List<ChainSettings.ContentRegistrationChainsEnum>
                {
                    ChainSettings.ContentRegistrationChainsEnum.PERHASHPROOFCHAIN,
                    ChainSettings.ContentRegistrationChainsEnum.SINGLEPROOFCHAIN
                }
            };

            var createConfiguration = new CreateConfigurationRequest(Name: UnitTestConfigName,
                InitialSettings: settings,
                Context: TestContextMultichain, AccessMode: CreateConfigurationRequest.AccessModeEnum.PRIVATE);

            var configurationResponse = _configurationApi.CreateConfiguration(createConfiguration);
            var storedSettings = configurationResponse.StoredSettings;
            Assert.NotNull(storedSettings);
            Assert.NotNull(storedSettings.Context);
            Assert.NotNull(storedSettings.ChainSettings);
            Assert.NotNull(storedSettings.SingleProofChain);
            Assert.NotNull(storedSettings.SettingsChain);
            Assert.NotNull(storedSettings.ChainConfiguration);
            Assert.NotNull(storedSettings.ChainSettings.SingleProofChain);
            Assert.NotNull(storedSettings.ChainSettings.HashAlgorithm);
            SettingsChainId = storedSettings.SettingsChain.Id;
            ProofChainId = storedSettings.SingleProofChain.Id;
            return storedSettings;
        }

        [SetUp]
        public void CreateConfigurationApi()
        {
            _configurationApi = new ConfigurationApi();
            ConfigureApi(_configurationApi.Configuration);
        }

        protected void ConfigureApi(Configuration configuration)
        {
            configuration.AccessToken = FixedAccessToken;
            configuration.Timeout = 40000;
            var gatewayUrl = Environment.GetEnvironmentVariable("tests.dotnet.bcproof.gateway-url");
            if (!string.IsNullOrEmpty(gatewayUrl))
            {
                configuration.ApiClient.RestClient.BaseUrl = new Uri(gatewayUrl);
            }
        }
    }
}