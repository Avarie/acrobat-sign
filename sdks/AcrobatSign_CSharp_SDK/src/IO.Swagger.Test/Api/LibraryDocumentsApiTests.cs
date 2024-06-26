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
using IO.Swagger.model.libraryDocuments;

namespace IO.Swagger.Test.Api
{
    /// <summary>
    ///  Class for testing LibraryDocumentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LibraryDocumentsApiTests
    {
        private LibraryDocumentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LibraryDocumentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LibraryDocumentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LibraryDocumentsApi
            //Assert.IsInstanceOfType(typeof(LibraryDocumentsApi), instance, "instance is a LibraryDocumentsApi");
        }

        
        /// <summary>
        /// Test CreateLibraryDocument
        /// </summary>
        [Test]
        public void CreateLibraryDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //LibraryDocumentCreationInfoV6 libraryDocumentInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.CreateLibraryDocument(authorization, libraryDocumentInfo, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<LibraryDocumentCreationResponse> (response, "response is LibraryDocumentCreationResponse");
        }
        
        /// <summary>
        /// Test CreateLibraryDocumentView
        /// </summary>
        [Test]
        public void CreateLibraryDocumentViewTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //LibraryViewInfo libraryViewInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.CreateLibraryDocumentView(authorization, libraryDocumentId, libraryViewInfo, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<LibraryDocumentViewResponse> (response, "response is LibraryDocumentViewResponse");
        }
        
        /// <summary>
        /// Test GetCombinedDocument
        /// </summary>
        [Test]
        public void GetCombinedDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //bool? attachAuditReport = null;
            //var response = instance.GetCombinedDocument(authorization, libraryDocumentId, xApiUser, xOnBehalfOfUser, ifNoneMatch, attachAuditReport);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetDocuments
        /// </summary>
        [Test]
        public void GetDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //string versionId = null;
            //var response = instance.GetDocuments(authorization, libraryDocumentId, xApiUser, xOnBehalfOfUser, ifNoneMatch, versionId);
            //Assert.IsInstanceOf<Documents> (response, "response is Documents");
        }
        
        /// <summary>
        /// Test GetEvents
        /// </summary>
        [Test]
        public void GetEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetEvents(authorization, libraryDocumentId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<LibraryDocumentEventList> (response, "response is LibraryDocumentEventList");
        }
        
        /// <summary>
        /// Test GetFormData
        /// </summary>
        [Test]
        public void GetFormDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetFormData(authorization, libraryDocumentId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetLibraryDocument
        /// </summary>
        [Test]
        public void GetLibraryDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //string documentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetLibraryDocument(authorization, libraryDocumentId, documentId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetLibraryDocumentAuditTrail
        /// </summary>
        [Test]
        public void GetLibraryDocumentAuditTrailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetLibraryDocumentAuditTrail(authorization, libraryDocumentId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<byte[]> (response, "response is byte[]");
        }
        
        /// <summary>
        /// Test GetLibraryDocumentImageUrls
        /// </summary>
        [Test]
        public void GetLibraryDocumentImageUrlsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //string documentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //string imageSizes = null;
            //int? startPage = null;
            //int? endPage = null;
            //var response = instance.GetLibraryDocumentImageUrls(authorization, libraryDocumentId, documentId, xApiUser, xOnBehalfOfUser, ifNoneMatch, imageSizes, startPage, endPage);
            //Assert.IsInstanceOf<DocumentImageUrlsInfo> (response, "response is DocumentImageUrlsInfo");
        }
        
        /// <summary>
        /// Test GetLibraryDocumentInfo
        /// </summary>
        [Test]
        public void GetLibraryDocumentInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //string ifNoneMatch = null;
            //var response = instance.GetLibraryDocumentInfo(authorization, libraryDocumentId, xApiUser, xOnBehalfOfUser, ifNoneMatch);
            //Assert.IsInstanceOf<LibraryDocumentCreationInfoV6> (response, "response is LibraryDocumentCreationInfoV6");
        }
        
        /// <summary>
        /// Test GetLibraryDocumentNoteForApiUser
        /// </summary>
        [Test]
        public void GetLibraryDocumentNoteForApiUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //var response = instance.GetLibraryDocumentNoteForApiUser(authorization, libraryDocumentId, xApiUser, xOnBehalfOfUser);
            //Assert.IsInstanceOf<Note> (response, "response is Note");
        }
        
        /// <summary>
        /// Test GetLibraryDocuments
        /// </summary>
        [Test]
        public void GetLibraryDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //bool? showHiddenLibraryDocuments = null;
            //string cursor = null;
            //int? pageSize = null;
            //var response = instance.GetLibraryDocuments(authorization, xApiUser, xOnBehalfOfUser, showHiddenLibraryDocuments, cursor, pageSize);
            //Assert.IsInstanceOf<LibraryDocuments> (response, "response is LibraryDocuments");
        }
        
        /// <summary>
        /// Test UpdateLibraryDocument
        /// </summary>
        [Test]
        public void UpdateLibraryDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string libraryDocumentId = null;
            //LibraryDocumentInfo libraryDocumentInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateLibraryDocument(authorization, ifMatch, libraryDocumentId, libraryDocumentInfo, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test UpdateLibraryDocumentNoteForApiUser
        /// </summary>
        [Test]
        public void UpdateLibraryDocumentNoteForApiUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //Note note = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateLibraryDocumentNoteForApiUser(authorization, libraryDocumentId, note, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test UpdateLibraryDocumentState
        /// </summary>
        [Test]
        public void UpdateLibraryDocumentStateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string ifMatch = null;
            //string libraryDocumentId = null;
            //LibraryDocumentStateInfo libraryDocumentStateInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateLibraryDocumentState(authorization, ifMatch, libraryDocumentId, libraryDocumentStateInfo, xApiUser, xOnBehalfOfUser);
            
        }
        
        /// <summary>
        /// Test UpdateLibraryDocumentVisibility
        /// </summary>
        [Test]
        public void UpdateLibraryDocumentVisibilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string authorization = null;
            //string libraryDocumentId = null;
            //VisibilityInfo visibilityInfo = null;
            //string xApiUser = null;
            //string xOnBehalfOfUser = null;
            //instance.UpdateLibraryDocumentVisibility(authorization, libraryDocumentId, visibilityInfo, xApiUser, xOnBehalfOfUser);
            
        }
        
    }

}
