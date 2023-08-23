# Telstra.Messaging.Api.AuthenticationApi

All URIs are relative to *https://tapi.telstra.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AuthToken**](AuthenticationApi.md#authtoken) | **POST** /oauth/token | Generate OAuth2 token |

<a id="authtoken"></a>
# **AuthToken**
> OAuthResponse AuthToken (string clientId, string clientSecret, string grantType)

Generate OAuth2 token

To generate an OAuth2 Authentication token, pass through your `Client key` and `Client secret` that you received when you registered for the **API Free Trial** Product. The grant_type should be left as `client_credentials` and the scope as `NSMS`. The token will expire in one hour. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class AuthTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            var apiInstance = new AuthenticationApi(config);
            var clientId = "clientId_example";  // string | 
            var clientSecret = "clientSecret_example";  // string | 
            var grantType = "\"client_credentials\"";  // string |  (default to "client_credentials")

            try
            {
                // Generate OAuth2 token
                OAuthResponse result = apiInstance.AuthToken(clientId, clientSecret, grantType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AuthTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Generate OAuth2 token
    ApiResponse<OAuthResponse> response = apiInstance.AuthTokenWithHttpInfo(clientId, clientSecret, grantType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthenticationApi.AuthTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** |  |  |
| **clientSecret** | **string** |  |  |
| **grantType** | **string** |  | [default to &quot;client_credentials&quot;] |

### Return type

[**OAuthResponse**](OAuthResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | unsupported_grant_type |  -  |
| **401** | invalid_client |  -  |
| **404** | The requested URI does not exist |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

