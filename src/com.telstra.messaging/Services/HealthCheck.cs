using com.telstra.messaging.Common;
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.HealthCheck;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace com.telstra.messaging
{
    public class HealthCheck : Client
    {
        public HealthCheck(Credentials? credentials = null) : base(credentials ?? new Credentials())
        {

        }

        public async Task<ApiStatus> GetStatus()
        {
            try
            {
                var response = await this.SendAsync(HttpMethod.Get, "/messaging/v3/health-check");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JObject.Parse(response.Content);
                    return new ApiStatus(responseObject["status"]?.ToString());
                }
                else
                {
                    throw new Exception($"Failed to get ApiStatus. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get ApiStatus. {ex.Message}");
            }
        }
    }
}
