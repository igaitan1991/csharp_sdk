/* 
 * predictor_scoring
 *
 * Credit Score Predictor
 *
 * OpenAPI spec version: 1.0
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
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing PredictorScoringApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PredictorScoringApiTests
    {
        private PredictorScoringApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PredictorScoringApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PredictorScoringApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PredictorScoringApi
            //Assert.IsInstanceOfType(typeof(PredictorScoringApi), instance, "instance is a PredictorScoringApi");
        }

        
        /// <summary>
        /// Test CancelAndDeleteBatchExecution
        /// </summary>
        [Test]
        public void CancelAndDeleteBatchExecutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //var response = instance.CancelAndDeleteBatchExecution(executionId);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetBatchExecutionFile
        /// </summary>
        [Test]
        public void GetBatchExecutionFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //int? index = null;
            //string fileName = null;
            //var response = instance.GetBatchExecutionFile(executionId, index, fileName);
            //Assert.IsInstanceOf<System.IO.Stream> (response, "response is System.IO.Stream");
        }
        
        /// <summary>
        /// Test GetBatchExecutionFiles
        /// </summary>
        [Test]
        public void GetBatchExecutionFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //int? index = null;
            //var response = instance.GetBatchExecutionFiles(executionId, index);
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test GetBatchExecutionStatus
        /// </summary>
        [Test]
        public void GetBatchExecutionStatusTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string executionId = null;
            //bool? showPartialResults = null;
            //var response = instance.GetBatchExecutionStatus(executionId, showPartialResults);
            //Assert.IsInstanceOf<BatchWebServiceResult> (response, "response is BatchWebServiceResult");
        }
        
        /// <summary>
        /// Test GetBatchExecutions
        /// </summary>
        [Test]
        public void GetBatchExecutionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetBatchExecutions();
            //Assert.IsInstanceOf<List<string>> (response, "response is List<string>");
        }
        
        /// <summary>
        /// Test PredictorScoring
        /// </summary>
        [Test]
        public void PredictorScoringTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //InputParameters webServiceParameters = null;
            //var response = instance.PredictorScoring(webServiceParameters);
            //Assert.IsInstanceOf<WebServiceResult> (response, "response is WebServiceResult");
        }
        
        /// <summary>
        /// Test StartBatchExecution
        /// </summary>
        [Test]
        public void StartBatchExecutionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<InputParameters> batchWebServiceParameters = null;
            //int? parallelCount = null;
            //var response = instance.StartBatchExecution(batchWebServiceParameters, parallelCount);
            //Assert.IsInstanceOf<StartBatchExecutionResponse> (response, "response is StartBatchExecutionResponse");
        }
        
    }

}
