/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Sphereon.SDK.Blockchain.Proof.Client;
using Sphereon.SDK.Blockchain.Proof.Api;
using Sphereon.SDK.Blockchain.Proof.Model;

namespace Sphereon.SDK.Blockchain.Proof.Test
{
    /// <summary>
    ///  Class for testing AllApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AllApiTests
    {
        private AllApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AllApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AllApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AllApi
            //Assert.IsInstanceOfType(typeof(AllApi), instance, "instance is a AllApi");
        }

        
        /// <summary>
        /// Test CreateChain
        /// </summary>
        [Test]
        public void CreateChainTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateChainRequest request = null;
            //var response = instance.CreateChain(request);
            //Assert.IsInstanceOf<CreateChainResponse> (response, "response is CreateChainResponse");
        }
        
        /// <summary>
        /// Test RegisterContent
        /// </summary>
        [Test]
        public void RegisterContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string chainId = null;
            //ContentRequest existence = null;
            //var response = instance.RegisterContent(chainId, existence);
            //Assert.IsInstanceOf<RegisterContentResponse> (response, "response is RegisterContentResponse");
        }
        
        /// <summary>
        /// Test RegisterStream
        /// </summary>
        [Test]
        public void RegisterStreamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string chainId = null;
            //System.IO.Stream stream = null;
            //var response = instance.RegisterStream(chainId, stream);
            //Assert.IsInstanceOf<RegisterContentResponse> (response, "response is RegisterContentResponse");
        }
        
        /// <summary>
        /// Test Settings
        /// </summary>
        [Test]
        public void SettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string chainId = null;
            //var response = instance.Settings(chainId);
            //Assert.IsInstanceOf<SettingsResponse> (response, "response is SettingsResponse");
        }
        
        /// <summary>
        /// Test VerifyContent
        /// </summary>
        [Test]
        public void VerifyContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string chainId = null;
            //ContentRequest existence = null;
            //var response = instance.VerifyContent(chainId, existence);
            //Assert.IsInstanceOf<VerifyContentResponse> (response, "response is VerifyContentResponse");
        }
        
        /// <summary>
        /// Test VerifyStream
        /// </summary>
        [Test]
        public void VerifyStreamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string chainId = null;
            //System.IO.Stream stream = null;
            //var response = instance.VerifyStream(chainId, stream);
            //Assert.IsInstanceOf<VerifyContentResponse> (response, "response is VerifyContentResponse");
        }
        
    }

}