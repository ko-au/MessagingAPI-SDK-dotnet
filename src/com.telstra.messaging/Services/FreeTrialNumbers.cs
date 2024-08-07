using com.telstra.messaging.Common;
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.FreeTrialNumbers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace com.telstra.messaging
{
    public class FreeTrialNumbers : Client
    {
        public FreeTrialNumbers(Credentials? credentials = null) : base(credentials ?? new Credentials())
        {

        }

        public async Task<FreeTrialNumbersList> Create(FreeTrialNumbersList freeTrialNumbers)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Post, "/messaging/v3/free-trial-numbers", freeTrialNumbers);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<FreeTrialNumbersList>(response.Content);
                    return responseObject ?? new FreeTrialNumbersList(new List<string>());
                }
                else
                {
                    throw new Exception($"Failed to create FreeTrialNumbers. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to create FreeTrialNumbers. {ex.Message}");
            }
        }

        public async Task<FreeTrialNumbersList> GetAll()
        {
            try
            {
                var response = await SendAsync(HttpMethod.Get, "/messaging/v3/free-trial-numbers");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<FreeTrialNumbersList>(response.Content);
                    return responseObject ?? new FreeTrialNumbersList(new List<string>());
                }
                else
                {
                    throw new Exception($"Failed to get FreeTrialNumbers. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get FreeTrialNumbers. {ex.Message}");
            }
        }
    }
}
