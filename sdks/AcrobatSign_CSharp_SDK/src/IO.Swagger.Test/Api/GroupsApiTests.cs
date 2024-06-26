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
using IO.Swagger.model.groups;

namespace IO.Swagger.Test.Api
{
    /// <summary>
    ///  Class for testing GroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GroupsApiTests
    {
        private GroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupsApi
            //Assert.IsInstanceOfType(typeof(GroupsApi), instance, "instance is a GroupsApi");
        }

        
        /// <summary>
        /// Test GetGroupDetails
        /// </summary>
        [Test]
        public void GetGroupDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string groupId = null;
            //string xApiUser = null;
            //var response = instance.GetGroupDetails(authorization, groupId, xApiUser);
            //Assert.IsInstanceOf<DetailedGroupInfo> (response, "response is DetailedGroupInfo");
        }
        
        /// <summary>
        /// Test GetGroups
        /// </summary>
        [Test]
        public void GetGroupsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string xApiUser = null;
            //string cursor = null;
            //int? pageSize = null;
            //var response = instance.GetGroups(authorization, xApiUser, cursor, pageSize);
            //Assert.IsInstanceOf<GroupsInfo> (response, "response is GroupsInfo");
        }
        
        /// <summary>
        /// Test GetUsersInGroup
        /// </summary>
        [Test]
        public void GetUsersInGroupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string groupId = null;
            //string xApiUser = null;
            //string cursor = null;
            //int? pageSize = null;
            //var response = instance.GetUsersInGroup(authorization, groupId, xApiUser, cursor, pageSize);
            //Assert.IsInstanceOf<GroupUsersInfo> (response, "response is GroupUsersInfo");
        }
        
    }

}
