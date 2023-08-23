# Telstra.Messaging.Api.MessagingApi

All URIs are relative to *https://tapi.telstra.com/v2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetMMSStatus**](MessagingApi.md#getmmsstatus) | **GET** /messages/mms/{messageid}/status | Get MMS Status |
| [**GetSMSStatus**](MessagingApi.md#getsmsstatus) | **GET** /messages/sms/{messageId}/status | Get SMS Status |
| [**RetrieveMMSResponses**](MessagingApi.md#retrievemmsresponses) | **GET** /messages/mms | Retrieve MMS Responses |
| [**RetrieveSMSResponses**](MessagingApi.md#retrievesmsresponses) | **GET** /messages/sms | Retrieve SMS Responses |
| [**SendMMS**](MessagingApi.md#sendmms) | **POST** /messages/mms | Send MMS |
| [**SendSMS**](MessagingApi.md#sendsms) | **POST** /messages/sms | Send SMS |

<a id="getmmsstatus"></a>
# **GetMMSStatus**
> List&lt;OutboundPollResponse&gt; GetMMSStatus (string messageid)

Get MMS Status

Get MMS Status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class GetMMSStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(config);
            var messageid = "messageid_example";  // string | Unique identifier of a message - it is the value returned from a previous POST call to https://api.telstra.com/v2/messages/mms 

            try
            {
                // Get MMS Status
                List<OutboundPollResponse> result = apiInstance.GetMMSStatus(messageid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.GetMMSStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetMMSStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get MMS Status
    ApiResponse<List<OutboundPollResponse>> response = apiInstance.GetMMSStatusWithHttpInfo(messageid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApi.GetMMSStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageid** | **string** | Unique identifier of a message - it is the value returned from a previous POST call to https://api.telstra.com/v2/messages/mms  |  |

### Return type

[**List&lt;OutboundPollResponse&gt;**](OutboundPollResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |
| **400** | Invalid or missing request parameters  NOT-PROVISIONED  Request flagged as containing suspicious content |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist OLD-NONEXISTANT-MESSAGE-ID RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsmsstatus"></a>
# **GetSMSStatus**
> List&lt;OutboundPollResponse&gt; GetSMSStatus (string messageId)

Get SMS Status

If no notification URL has been specified, it is possible to poll for the message status. Note that the `MessageId` that appears in the URL must be URL encoded. Just copying the `MessageId` as it was supplied when submitting the message may not work.  SMS Status with Notification URL - -- When a message has reached its final state, the API will send a POST to the URL that has been previously specified. <pre><code class=\"language-sh\">{     to: '+61418123456'     sentTimestamp: '2017-03-17T10:05:22+10:00'     receivedTimestamp: '2017-03-17T10:05:23+10:00'     messageId: /cccb284200035236000000000ee9d074019e0301/1261418123456     deliveryStatus: DELIVRD   } </code></pre>  The fields are: <table>   <thead>     <tr>       <th>Field</th>       <th>Description</th>     </tr>   </thead>   <tbody>     <tr>       <td><code>to</code></td>       <td>The number the message was sent to.</td>     </tr>     <tr>       <td><code>receivedTimestamp</code></td>       <td>Time the message was sent to the API.</td>     </tr>     <tr>       <td><code>sentTimestamp</code></td>       <td>Time handling of the message ended.</td>     </tr>     <tr>       <td><code>deliveryStatus</code></td>       <td>The final state of the message.</td>     </tr>     <tr>       <td><code>messageId</code></td>       <td>The same reference that was returned when the original message was sent.</td>     </tr>     <tr>       <td><code>receivedTimestamp</code></td>       <td>Time the message was sent to the API.</td>     </tr>   </tbody> </table>  Upon receiving this call it is expected that your servers will give a 204 (No Content) response. Anything else will cause the API to reattempt the call 5 minutes later. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class GetSMSStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(config);
            var messageId = "messageId_example";  // string | Unique identifier of a message - it is the value returned from a previous POST call to https://api.telstra.com/v2/messages/sms. 

            try
            {
                // Get SMS Status
                List<OutboundPollResponse> result = apiInstance.GetSMSStatus(messageId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.GetSMSStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSMSStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get SMS Status
    ApiResponse<List<OutboundPollResponse>> response = apiInstance.GetSMSStatusWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApi.GetSMSStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageId** | **string** | Unique identifier of a message - it is the value returned from a previous POST call to https://api.telstra.com/v2/messages/sms.  |  |

### Return type

[**List&lt;OutboundPollResponse&gt;**](OutboundPollResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid or missing request parameters  NOT-PROVISIONED  Request flagged as containing suspicious content |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission  SpikeArrest-The API call rate limit has been exceeded |  -  |
| **404** | The requested URI does not exist  OLD-NONEXISTANT-MESSAGE-ID  RESOURCE-NOT-FOUND |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievemmsresponses"></a>
# **RetrieveMMSResponses**
> List&lt;MMSContent&gt; RetrieveMMSResponses ()

Retrieve MMS Responses

Messages are retrieved one at a time, starting with the earliest response. If the subscription has a `notifyURL`, response messages will be logged there instead.  # Notification URL Format for MMS Replies  <pre><code class=\"language-sh\">{   \"status\": \"RECEIVED\",   \"destinationAddress\": \"+61418123456\",   \"senderAddress\": \"+61421987654\",   \"subject\": \"Foo\",   \"sentTimestamp\": \"2018-03-23T12:15:45+10:00\",   \"envelope\": \"string\",   \"MMSContent\":     [       {         \"type\": \"text/plain\",         \"filename\": \"text_1.txt\",         \"payload\": \"string\"       },       {         \"type\": \"image/jpeg\",         \"filename\": \"sample.jpeg\",         \"payload\": \"string\"       }     ] }</code></pre>  The fields are: | Field | Description | | - -- | - -- | | `status` | The final state of the message. | | `destinationAddress` |The number the message was sent to. | | `senderAddress` | The number the message was sent from. | | `subject` | The subject assigned to the message. | | `sentTimestamp` | Time handling of the message ended. | | `envelope` | Information about about terminal type and originating operator. | | `MMSContent` | An array of the actual content of the reply message. | | `type` | The content type of the message. | | `filename` | The filename for the message content. | | `payload` | The content of the message. | 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class RetrieveMMSResponsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(config);

            try
            {
                // Retrieve MMS Responses
                List<MMSContent> result = apiInstance.RetrieveMMSResponses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.RetrieveMMSResponses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveMMSResponsesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve MMS Responses
    ApiResponse<List<MMSContent>> response = apiInstance.RetrieveMMSResponsesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApi.RetrieveMMSResponsesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;MMSContent&gt;**](MMSContent.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid or missing request parameters NOT-PROVISIONED Request flagged as containing suspicious content  |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="retrievesmsresponses"></a>
# **RetrieveSMSResponses**
> InboundPollResponse RetrieveSMSResponses ()

Retrieve SMS Responses

Messages are retrieved one at a time, starting with the earliest response. The API supports the encoding of the full range of emojis in the reply message. The emojis will be in their UTF-8 format. If the subscription has a `notifyURL`, response messages will be logged there instead.  # Notification URL Format for SMS Response  <pre><code class=\"language-sh\">{   \"to\":\"+61472880123\",   \"from\":\"+61412345678\",   \"body\":\"Foo4\",   \"sentTimestamp\":\"2018-04-20T14:24:35\",   \"messageId\":\"DMASApiA0000000146\" }</code></pre>  The fields are: | Field | Description | | - -- |- -- | | `to` | The number the message was sent to. | | `from` | The number the message was sent from. | | `body` | The content of the SMS response. | | `sentTimestamp` | Time handling of the message ended. | | `messageId` | The ID assigned to the message. | 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class RetrieveSMSResponsesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(config);

            try
            {
                // Retrieve SMS Responses
                InboundPollResponse result = apiInstance.RetrieveSMSResponses();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.RetrieveSMSResponses: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RetrieveSMSResponsesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve SMS Responses
    ApiResponse<InboundPollResponse> response = apiInstance.RetrieveSMSResponsesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApi.RetrieveSMSResponsesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**InboundPollResponse**](InboundPollResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Invalid or missing request parameters NOT-PROVISIONED Request flagged as containing suspicious content  |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendmms"></a>
# **SendMMS**
> MessageSentResponse SendMMS (SendMmsRequest body)

Send MMS

Send MMS

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class SendMMSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(config);
            var body = new SendMmsRequest(); // SendMmsRequest | A JSON or XML payload containing the recipient's phone number and MMS message. The recipient number should be in the format '04xxxxxxxx' where x is a digit. 

            try
            {
                // Send MMS
                MessageSentResponse result = apiInstance.SendMMS(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.SendMMS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendMMSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send MMS
    ApiResponse<MessageSentResponse> response = apiInstance.SendMMSWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApi.SendMMSWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**SendMmsRequest**](SendMmsRequest.md) | A JSON or XML payload containing the recipient&#39;s phone number and MMS message. The recipient number should be in the format &#39;04xxxxxxxx&#39; where x is a digit.  |  |

### Return type

[**MessageSentResponse**](MessageSentResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Invalid or missing request parameters MMS-TYPE-MISSING MMS-PAYLOAD-MISSING MMS-FILENAME-MISSING DELIVERY-IMPOSSIBLE TO-MSISDN-NOT-VALID SENDER-MISSING DELIVERY-IMPOSSIBLE SUBJECT-TOO-LONG FROM-MSISDN-TOO-LONG TO-MSISDN-TOO-LONG NOT-PROVISIONED Request flagged as containing suspicious content  |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendsms"></a>
# **SendSMS**
> MessageSentResponse SendSMS (SendSMSRequest payload)

Send SMS

Send an SMS Message to a single or multiple mobile number/s. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class SendSMSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://tapi.telstra.com/v2";
            // Configure OAuth2 access token for authorization: auth
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagingApi(config);
            var payload = new SendSMSRequest(); // SendSMSRequest | A JSON or XML payload containing the recipient's phone number and text message. This number can be in international format if preceeded by a '+' or in national format ('04xxxxxxxx') where x is a digit. 

            try
            {
                // Send SMS
                MessageSentResponse result = apiInstance.SendSMS(payload);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagingApi.SendSMS: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendSMSWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send SMS
    ApiResponse<MessageSentResponse> response = apiInstance.SendSMSWithHttpInfo(payload);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagingApi.SendSMSWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **payload** | [**SendSMSRequest**](SendSMSRequest.md) | A JSON or XML payload containing the recipient&#39;s phone number and text message. This number can be in international format if preceeded by a &#39;+&#39; or in national format (&#39;04xxxxxxxx&#39;) where x is a digit.  |  |

### Return type

[**MessageSentResponse**](MessageSentResponse.md)

### Authorization

[auth](../README.md#auth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | Invalid or missing request parameters TO-MSISDN-NOT-VALID SENDER-MISSING DELIVERY-IMPOSSIBLE FROM-MSISDN-TOO-LONG BODY-TOO-LONG BODY-MISSING TO-MSISDN-TOO-LONG TECH-ERR BODY-NOT-VALID NOT-PROVISIONED Request flagged as containing suspicious content  |  -  |
| **401** | Invalid access token. Please try with a valid token |  -  |
| **403** | Authorization credentials passed and accepted but account does not have permission SpikeArrest-The API call rate limit has been exceeded  |  -  |
| **404** | The requested URI does not exist RESOURCE-NOT-FOUND  |  -  |
| **405** | The requested resource does not support the supplied verb |  -  |
| **415** | API does not support the requested content type |  -  |
| **422** | The request is formed correctly, but due to some condition the request cannot be processed e.g. email is required and it is not provided in the request  |  -  |
| **500** | Technical error : Unable to route the message to a Target Endpoint : An error has occurred while processing your request, please refer to API Docs for summary on the issue  |  -  |
| **501** | The HTTP method being used has not yet been implemented for the requested resource  |  -  |
| **503** | The service requested is currently unavailable |  -  |
| **0** | An internal error occurred when processing the request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

