/* 
 * Sphereon :: BLOCKCHAIN :: PROOF API
 *
 * <b>The Blockchain Proof API is an easy to prove existence of (binary) data at a certain point in time. Behinde the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
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


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Sphereon.SDK.Blockchain.Proof.Api;
using Sphereon.SDK.Blockchain.Proof.Model;
using Sphereon.SDK.Blockchain.Proof.Client;
using System.Reflection;

namespace Sphereon.SDK.Blockchain.Proof.Test
{
    /// <summary>
    ///  Class for testing Settings
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SettingsTests
    {
        // TODO uncomment below to declare an instance variable for Settings
        //private Settings instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Settings
            //instance = new Settings();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Settings
        /// </summary>
        [Test]
        public void SettingsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Settings
            //Assert.IsInstanceOfType<Settings> (instance, "variable 'instance' is a Settings");
        }

        /// <summary>
        /// Test the property 'IncludeContentSize'
        /// </summary>
        [Test]
        public void IncludeContentSizeTest()
        {
            // TODO unit test for the property 'IncludeContentSize'
        }
        /// <summary>
        /// Test the property 'Version'
        /// </summary>
        [Test]
        public void VersionTest()
        {
            // TODO unit test for the property 'Version'
        }
        /// <summary>
        /// Test the property 'HashAlgorithm'
        /// </summary>
        [Test]
        public void HashAlgorithmTest()
        {
            // TODO unit test for the property 'HashAlgorithm'
        }

    }

}
