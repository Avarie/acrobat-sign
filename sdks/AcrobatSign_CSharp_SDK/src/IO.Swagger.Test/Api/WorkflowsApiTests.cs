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
using IO.Swagger.model.workflows;

namespace IO.Swagger.Test.Api
{
    /// <summary>
    ///  Class for testing WorkflowsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WorkflowsApiTests
    {
        private WorkflowsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkflowsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkflowsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WorkflowsApi
            //Assert.IsInstanceOfType(typeof(WorkflowsApi), instance, "instance is a WorkflowsApi");
        }

        
        /// <summary>
        /// Test GetWorkflows
        /// </summary>
        [Test]
        public void GetWorkflowsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string xApiUser = null;
            //bool? includeDraftWorkflows = null;
            //bool? includeInactiveWorkflows = null;
            //string groupId = null;
            //var response = instance.GetWorkflows(authorization, xApiUser, includeDraftWorkflows, includeInactiveWorkflows, groupId);
            //Assert.IsInstanceOf<UserWorkflows> (response, "response is UserWorkflows");
        }
        
    }

}
