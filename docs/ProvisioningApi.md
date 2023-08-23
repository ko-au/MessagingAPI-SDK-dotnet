# Telstra.Messaging.Api.ProvisioningApi

All URIs are relative to *https://tapi.telstra.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSubscription**](ProvisioningApi.md#createsubscription) | **POST** /messages/provisioning/subscriptions | Create Subscription |
| [**DeleteSubscription**](ProvisioningApi.md#deletesubscription) | **DELETE** /messages/provisioning/subscriptions | Delete Subscription |
| [**GetSubscription**](ProvisioningApi.md#getsubscription) | **GET** /messages/provisioning/subscriptions | Get Subscription |

<a id="createsubscription"></a>
# **CreateSubscription**
> ProvisionNumberResponse CreateSubscription (ProvisionNumberRequest body)

Create Subscription

Invoke the provisioning API to get a dedicated mobile number for an account or application. Note that Free Trial apps will have a 30-Day Limit for their provisioned number. If the Provisioning call is made several times within that 30-Day period, it will return the `expiryDate` in the Unix format and will not add any activeDays until after that `expiryDate`.  For paid apps, a provisioned number can be allotted for a maximum of 5 years. If a Provisioning call is made which will result to activeDays > 1830, the response body will indicate that the provisioned number is already valid for more than 5 years. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class CreateSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvisioningApi(config);
            var body = new ProvisionNumberRequest(); // ProvisionNumberRequest | A JSON payload containing the required attributes

            try
            {
                // Create Subscription
                ProvisionNumberResponse result = apiInstance.CreateSubscription(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.CreateSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Subscription
    ApiResponse<ProvisionNumberResponse> response = apiInstance.CreateSubscriptionWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.CreateSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**ProvisionNumberRequest**](ProvisionNumberRequest.md) | A JSON payload containing the required attributes |  |

### Return type

[**ProvisionNumberResponse**](ProvisionNumberResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Invalid or missing request parameters |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission  SpikeArrest-The API call rate limit has been exceeded |  -  |
| **404** | The requested URI does not exist  RESOURCE-NOT-FOUND  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletesubscription"></a>
# **DeleteSubscription**
> void DeleteSubscription (DeleteNumberRequest body)

Delete Subscription

Delete a mobile number subscription from an account 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class DeleteSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvisioningApi(config);
            var body = new DeleteNumberRequest(); // DeleteNumberRequest | EmptyArr

            try
            {
                // Delete Subscription
                apiInstance.DeleteSubscription(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.DeleteSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Subscription
    apiInstance.DeleteSubscriptionWithHttpInfo(body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.DeleteSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DeleteNumberRequest**](DeleteNumberRequest.md) | EmptyArr |  |

### Return type

void (empty response body)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | Invalid or missing request parameters |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission  SpikeArrest-The API call rate limit has been exceeded |  -  |
| **404** | The requested URI does not exist  RESOURCE-NOT-FOUND |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsubscription"></a>
# **GetSubscription**
> GetSubscriptionResponse GetSubscription ()

Get Subscription

Get mobile number subscription for an account 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class GetSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ProvisioningApi(config);

            try
            {
                // Get Subscription
                GetSubscriptionResponse result = apiInstance.GetSubscription();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ProvisioningApi.GetSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Subscription
    ApiResponse<GetSubscriptionResponse> response = apiInstance.GetSubscriptionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ProvisioningApi.GetSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GetSubscriptionResponse**](GetSubscriptionResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid or missing request parameters |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission  SpikeArrest-The API call rate limit has been exceeded |  -  |
| **404** | The requested URI does not exist  RESOURCE-NOT-FOUND |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

