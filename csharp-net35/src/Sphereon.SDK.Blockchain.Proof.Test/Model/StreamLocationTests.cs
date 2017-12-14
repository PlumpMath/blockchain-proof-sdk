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
    ///  Class for testing StreamLocation
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class StreamLocationTests
    {
        // TODO uncomment below to declare an instance variable for StreamLocation
        //private StreamLocation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of StreamLocation
            //instance = new StreamLocation();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of StreamLocation
        /// </summary>
        [Test]
        public void StreamLocationInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" StreamLocation
            //Assert.IsInstanceOfType<StreamLocation> (instance, "variable 'instance' is a StreamLocation");
        }

        /// <summary>
        /// Test the property 'FolderPath'
        /// </summary>
        [Test]
        public void FolderPathTest()
        {
            // TODO unit test for the property 'FolderPath'
        }
        /// <summary>
        /// Test the property 'Filename'
        /// </summary>
        [Test]
        public void FilenameTest()
        {
            // TODO unit test for the property 'Filename'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'ContainerId'
        /// </summary>
        [Test]
        public void ContainerIdTest()
        {
            // TODO unit test for the property 'ContainerId'
        }
        /// <summary>
        /// Test the property 'OriginalFilename'
        /// </summary>
        [Test]
        public void OriginalFilenameTest()
        {
            // TODO unit test for the property 'OriginalFilename'
        }

    }

}