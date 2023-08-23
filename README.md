# Telstra.Messaging - the C# library for the Telstra Messaging API

The API specification for Telstra Messaging API

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2.2.9
- SDK version: 1.1.0

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 110.2.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 2.0.1 or later
- [Polly](https://www.nuget.org/packages/Polly/) - 7.2.4 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package Polly
Install-Package System.ComponentModel.Annotations
Install-Package CompareNETObjects
```

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Telstra.Messaging.Api;
using Telstra.Messaging.Client;
using Telstra.Messaging.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration.Default.BasePath = "https://tapi.telstra.com/v2";
            var apiInstance = new AuthenticationApi(Configuration.Default);
            var clientId = clientId_example;  // string | 
            var clientSecret = clientSecret_example;  // string | 
            var grantType = grantType_example;  // string |  (default to "client_credentials")
            var scope = scope_example;  // string | NSMS (optional) 

            try
            {
                // Generate OAuth2 token
                OAuthResponse result = apiInstance.AuthToken(clientId, clientSecret, grantType, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthenticationApi.AuthToken: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://tapi.telstra.com/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthenticationApi* | [**AuthToken**](docs/AuthenticationApi.md#authtoken) | **POST** /oauth/token | Generate OAuth2 token
*MessagingApi* | [**GetMMSStatus**](docs/MessagingApi.md#getmmsstatus) | **GET** /messages/mms/{messageid}/status | Get MMS Status
*MessagingApi* | [**GetSMSStatus**](docs/MessagingApi.md#getsmsstatus) | **GET** /messages/sms/{messageId}/status | Get SMS Status
*MessagingApi* | [**MMSHealthCheck**](docs/MessagingApi.md#mmshealthcheck) | **GET** /messages/mms/heathcheck | MMS Health Check
*MessagingApi* | [**RetrieveMMSReplies**](docs/MessagingApi.md#retrievemmsreplies) | **GET** /messages/mms | Retrieve MMS Replies
*MessagingApi* | [**RetrieveSMSReplies**](docs/MessagingApi.md#retrievesmsreplies) | **GET** /messages/sms | Retrieve SMS Replies
*MessagingApi* | [**SMSHealthCheck**](docs/MessagingApi.md#smshealthcheck) | **GET** /messages/sms/heathcheck | SMS Health Check
*MessagingApi* | [**SMSMulti**](docs/MessagingApi.md#smsmulti) | **POST** /messages/sms/multi | Send Multiple SMS
*MessagingApi* | [**SendMMS**](docs/MessagingApi.md#sendmms) | **POST** /messages/mms | Send MMS
*MessagingApi* | [**SendSMS**](docs/MessagingApi.md#sendsms) | **POST** /messages/sms | Send SMS
*ProvisioningApi* | [**CreateSubscription**](docs/ProvisioningApi.md#createsubscription) | **POST** /messages/provisioning/subscriptions | Create Subscription
*ProvisioningApi* | [**DeleteSubscription**](docs/ProvisioningApi.md#deletesubscription) | **DELETE** /messages/provisioning/subscriptions | Delete Subscription
*ProvisioningApi* | [**GetSubscription**](docs/ProvisioningApi.md#getsubscription) | **GET** /messages/provisioning/subscriptions | Get Subscription


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.DeleteNumberRequest](docs/DeleteNumberRequest.md)
 - [Model.GetMmsResponse](docs/GetMmsResponse.md)
 - [Model.GetSubscriptionResponse](docs/GetSubscriptionResponse.md)
 - [Model.HealthCheckResponse](docs/HealthCheckResponse.md)
 - [Model.InboundPollResponse](docs/InboundPollResponse.md)
 - [Model.MMSContent](docs/MMSContent.md)
 - [Model.Message](docs/Message.md)
 - [Model.MessageMulti](docs/MessageMulti.md)
 - [Model.MessageSentResponseMms](docs/MessageSentResponseMms.md)
 - [Model.MessageSentResponseSms](docs/MessageSentResponseSms.md)
 - [Model.OAuthResponse](docs/OAuthResponse.md)
 - [Model.OutboundPollResponse](docs/OutboundPollResponse.md)
 - [Model.ProvisionNumberRequest](docs/ProvisionNumberRequest.md)
 - [Model.ProvisionNumberResponse](docs/ProvisionNumberResponse.md)
 - [Model.SendMmsRequest](docs/SendMmsRequest.md)
 - [Model.SendSMSRequest](docs/SendSMSRequest.md)
 - [Model.SendSmsMultiRequest](docs/SendSmsMultiRequest.md)
 - [Model.Status](docs/Status.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="auth"></a>
### auth

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - NSMS: NSMS

