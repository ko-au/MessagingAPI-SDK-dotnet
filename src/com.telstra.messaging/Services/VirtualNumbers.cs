using com.telstra.messaging.Common;
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.VirtualNumbers;
using com.telstra.messaging.Utils;
using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http;
using System.Threading.Tasks;

namespace com.telstra.messaging
{
    public class VirtualNumbers : Client
    {
        public VirtualNumbers(Credentials? credentials = null) : base(credentials ?? new Credentials())
        {

        }

        public async Task<VirtualNumber> Assign(AssignVirtualNumberParams assignVirtualNumberParams)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Post, "/messaging/v3/virtual-numbers", assignVirtualNumberParams);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<VirtualNumber>(response.Content);
                    return responseObject ?? new VirtualNumber();
                }
                else
                {
                    throw new Exception($"Failed to assign VirtualNumber. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to assign VirtualNumber. {ex.Message}");
            }
        }

        public async Task<VirtualNumbersList> GetAll(QueryParams? queryParams = null)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Get, "/messaging/v3/virtual-numbers", null, queryParams);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<VirtualNumbersList>(response.Content);
                    return responseObject ?? new VirtualNumbersList();
                }
                else
                {
                    throw new Exception($"Failed to get a list of VirtualNumbers. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get a list of VirtualNumbers. {ex.Message}");
            }
        }

        public async Task<VirtualNumber> Get(string virtualNumber)
        {
            try
            {
                if (virtualNumber.Length != 10 || !Helper.IsStringDigitsOnly(virtualNumber))
                {
                    throw new ValidationException("Number is not a valid virtual number.");
                }

                var response = await SendAsync(HttpMethod.Get, $"/messaging/v3/virtual-numbers/{virtualNumber}");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<VirtualNumber>(response.Content);
                    return responseObject ?? new VirtualNumber();
                }
                else
                {
                    throw new Exception($"Failed to get VirtualNumber. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get VirtualNumber. {ex.Message}");
            }
        }

        public async Task<VirtualNumber> Update(UpdateVirtualNumberParams updateVirtualNumberParams)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Put, $"/messaging/v3/virtual-numbers/{updateVirtualNumberParams.Number}", updateVirtualNumberParams.UpdateData);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<VirtualNumber>(response.Content);
                    return responseObject ?? new VirtualNumber();
                }
                else
                {
                    throw new Exception($"Failed to update VirtualNumber. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to update VirtualNumber. {ex.Message}");
            }
        }

        public async Task Delete(string virtualNumber)
        {
            try
            {
                if (virtualNumber.Length != 10 || !Helper.IsStringDigitsOnly(virtualNumber))
                {
                    throw new ValidationException("Number is not a valid virtual number.");
                }

                var response = await SendAsync(HttpMethod.Delete, $"/messaging/v3/virtual-numbers/{virtualNumber}");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception($"Failed to delete VirtualNumber. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to delete VirtualNumber. {ex.Message}");
            }
        }

        public async Task<RecipientOptoutsList> GetOptouts(string virtualNumber)
        {
            try
            {
                if (virtualNumber.Length != 10 || !Helper.IsStringDigitsOnly(virtualNumber))
                {
                    throw new ValidationException("Number is not a valid virtual number.");
                }

                var response = await SendAsync(HttpMethod.Get, $"/messaging/v3/virtual-numbers/{virtualNumber}/optouts");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<RecipientOptoutsList>(response.Content);
                    return responseObject ?? new RecipientOptoutsList();
                }
                else
                {
                    throw new Exception($"Failed to get Recipient Optouts List. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get Recipient Optouts List. {ex.Message}");
            }
        }
    }
}