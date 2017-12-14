/* 
 * Blockchain Proof
 *
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9.0-SNAPSHOT
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
    ///  Class for testing RegistrationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RegistrationApiTests
    {
        private RegistrationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RegistrationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RegistrationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RegistrationApi
            //Assert.IsInstanceOfType(typeof(RegistrationApi), instance, "instance is a RegistrationApi");
        }

        
        /// <summary>
        /// Test RegisterContent
        /// </summary>
        [Test]
        public void RegisterContentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string configName = null;
            //ContentRequest existence = null;
            //var response = instance.RegisterContent(configName, existence);
            //Assert.IsInstanceOf<RegisterContentResponse> (response, "response is RegisterContentResponse");
        }
        
        /// <summary>
        /// Test RegisterStream
        /// </summary>
        [Test]
        public void RegisterStreamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string configName = null;
            //System.IO.Stream stream = null;
            //var response = instance.RegisterStream(configName, stream);
            //Assert.IsInstanceOf<RegisterContentResponse> (response, "response is RegisterContentResponse");
        }
        
        /// <summary>
        /// Test RegisterStreamOnStorage
        /// </summary>
        [Test]
        public void RegisterStreamOnStorageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string configName = null;
            //List<StreamLocation> streamLocations = null;
            //var response = instance.RegisterStreamOnStorage(configName, streamLocations);
            //Assert.IsInstanceOf<RegisterContentResponse> (response, "response is RegisterContentResponse");
        }
        
    }

}
