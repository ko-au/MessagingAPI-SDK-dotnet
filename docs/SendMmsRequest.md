# Telstra.Messaging.Model.SendMmsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | This will be the source address that will be displayed on the receiving device. If it is not present then it will default to the MSISDN assigned to the app. If replyRequest is set to true, then this field will be ignored.  | 
**To** | **string** | This is the destination address. Can be an array of strings if sending to multiple numbers: \&quot;to\&quot;:[\&quot;+61412345678\&quot;, \&quot;+61418765432\&quot;]  | 
**Subject** | **string** | The subject that will be used in an MMS message. | 
**ReplyRequest** | **bool** | If set to true, the reply message functionality will be implemented and the to address will be ignored if present. | 
**NotifyURL** | **string** | Notify url | [optional] 
**MMSContent** | [**List&lt;MMSContent&gt;**](MMSContent.md) | An array of content that will be sent in an MMS message. If this array is present it will cause the &#x60;body&#x60; element to be ignored, and the message will be sent as an MMS. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

