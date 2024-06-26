/* 
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 6.0.0
 * 
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

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.model.transientDocuments;

namespace IO.Swagger.Test.Api
{
    /// <summary>
    ///  Class for testing TransientDocumentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TransientDocumentsApiTests
    {
        private TransientDocumentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransientDocumentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TransientDocumentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TransientDocumentsApi
            //Assert.IsInstanceOfType(typeof(TransientDocumentsApi), instance, "instance is a TransientDocumentsApi");
        }

        
        /// <summary>
        /// Test CreateTransientDocument
        /// </summary>
        [Test]
        public void CreateTransientDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //System.IO.Stream file = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string fileName = null;
            //string mimeType = null;
            //var response = instance.CreateTransientDocument(authorization, file, xApiUser, xOnBehalfOfUser, fileName, mimeType);
            //Assert.IsInstanceOf<TransientDocumentResponse> (response, "response is TransientDocumentResponse");
        }
        
    }

}
