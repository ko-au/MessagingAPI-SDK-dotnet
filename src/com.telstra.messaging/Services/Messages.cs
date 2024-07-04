using com.telstra.messaging.Common;
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Messages;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace com.telstra.messaging
{
    public class Messages : Client
    {
        public Messages(Credentials? credentials = null) : base(credentials ?? new Credentials())
        {

        }

        public async Task<SendMessageResponse> Send(SendMessageParams sendMessageParams)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Post, "/messaging/v3/messages", sendMessageParams);

                if (response.IsSuccessStatusCode)
                {
                    try
                    {
                        Console.WriteLine(response.Content);
                        var responseObject = JsonConvert.DeserializeObject<SendMessageResponse>(response.Content);
                        return responseObject ?? new SendMessageResponse();
                    }
                    catch (Exception exResponse)
                    {
                        throw new Exception($"Failed to process response. {exResponse.Message}");
                    }
                }
                else
                {
                    throw new Exception($"Failed to send Message/s. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to send Message/s. {ex.Message}");
            }
        }

        public async Task<UpdateMessageResponse> Update(String messageId, UpdateMessageParams updateMessageParams)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Put, $"/messaging/v3/messages/{messageId}", updateMessageParams);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<UpdateMessageResponse>(response.Content);
                    return responseObject ?? new UpdateMessageResponse();
                }
                else
                {
                    throw new Exception($"Failed to update Message. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update Message. {ex.Message}");
            }
        }

        public async Task UpdateTags(String messageId, UpdateMessageTagsParams updateMessageTagsParams)
        {
            try
            {
                var response = await SendAsync(new HttpMethod("PATCH"), $"/messaging/v3/messages/{messageId}", updateMessageTagsParams);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Failed to update Message. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update Message. {ex.Message}");
            }
        }

        //public async Task<List<GetMessageResponse>> GetAll()
        public async Task<GetMessagesResponse> GetAll()
        {
            try
            {
                var response = await SendAsync(HttpMethod.Get, "/messaging/v3/messages");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<GetMessagesResponse>(response.Content);
                    return responseObject ?? new GetMessagesResponse();
                }
                else
                {
                    throw new Exception($"Failed to get Messages. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get Messages. {ex.Message}");
            }
        }

        public async Task<GetMessageResponse> Get(string messageId)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Get, $"/messaging/v3/messages/{messageId}");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<GetMessageResponse>(response.Content);
                    return responseObject ?? new GetMessageResponse();
                }
                else
                {
                    throw new Exception($"Failed to get the message. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get the message. {ex.Message}");
            }
        }

        public async Task Delete(string messageId)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Delete, $"/messaging/v3/messages/{messageId}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Failed to delete a message. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete a message. {ex.Message}");
            }
        }
    }
}
