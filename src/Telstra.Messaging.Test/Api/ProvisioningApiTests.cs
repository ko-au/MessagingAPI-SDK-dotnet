/* 
 * Telstra Messaging API
 *
 * The API specification for Telstra Messaging API
 *
 * The version of the OpenAPI document: 2.2.9
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Telstra.Messaging.Client;
using Telstra.Messaging.Api;
using Telstra.Messaging.Model;

namespace Telstra.Messaging.Test
{
    /// <summary>
    ///  Class for testing ProvisioningApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ProvisioningApiTests : IDisposable
    {
        private ProvisioningApi instance;

        public ProvisioningApiTests()
        {
            instance = new ProvisioningApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ProvisioningApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProvisioningApi
            //Assert.IsType(typeof(ProvisioningApi), instance, "instance is a ProvisioningApi");
        }

        
        /// <summary>
        /// Test CreateSubscription
        /// </summary>
        [Fact]
        public void CreateSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProvisionNumberRequest body = null;
            //var response = instance.CreateSubscription(body);
            //Assert.IsType<ProvisionNumberResponse> (response, "response is ProvisionNumberResponse");
        }
        
        /// <summary>
        /// Test DeleteSubscription
        /// </summary>
        [Fact]
        public void DeleteSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteNumberRequest body = null;
            //instance.DeleteSubscription(body);
            
        }
        
        /// <summary>
        /// Test GetSubscription
        /// </summary>
        [Fact]
        public void GetSubscriptionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSubscription();
            //Assert.IsType<GetSubscriptionResponse> (response, "response is GetSubscriptionResponse");
        }
        
    }

}