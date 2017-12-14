/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9.0-SNAPSHOT
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    ///  Class for testing ChainConfiguration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ChainConfigurationTests
    {
        // TODO uncomment below to declare an instance variable for ChainConfiguration
        //private ChainConfiguration instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ChainConfiguration
            //instance = new ChainConfiguration();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ChainConfiguration
        /// </summary>
        [Test]
        public void ChainConfigurationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ChainConfiguration
            //Assert.IsInstanceOfType<ChainConfiguration> (instance, "variable 'instance' is a ChainConfiguration");
        }

        /// <summary>
        /// Test the property 'Context'
        /// </summary>
        [Test]
        public void ContextTest()
        {
            // TODO unit test for the property 'Context'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'SettingChainId'
        /// </summary>
        [Test]
        public void SettingChainIdTest()
        {
            // TODO unit test for the property 'SettingChainId'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

    }

}
