using com.telstra.messaging.Common;
using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Models.Reports;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace com.telstra.messaging
{
    public class Reports : Client
    {
        public Reports(Credentials? credentials = null) : base(credentials ?? new Credentials())
        {

        }

        public async Task<Report> Create(CreateReportsParams createReportsParams)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Post, "/messaging/v3/reports/messages", createReportsParams);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<Report>(response.Content);
                    return responseObject ?? new Report();
                }
                else
                {
                    throw new Exception($"Failed to create Messages Report. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to create Messages Report. {ex.Message}");
            }
        }

        public async Task<Report> CreateDailySummary(CreateReportsParams createReportsParams)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Post, "/messaging/v3/reports/messages/daily", createReportsParams);

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<Report>(response.Content);
                    return responseObject ?? new Report();
                }
                else
                {
                    throw new Exception($"Failed to create Messages Daily Summary Report. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to create Messages Daily Summary Report. {ex.Message}");
            }
        }

        public async Task<ReportsList> GetAll()
        {
            try
            {
                var response = await SendAsync(HttpMethod.Get, "/messaging/v3/reports");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<ReportsList>(response.Content);
                    return responseObject ?? new ReportsList();
                }
                else
                {
                    throw new Exception($"Failed to get Reports. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get Reports. {ex.Message}");
            }
        }

        public async Task<Report> Get(string reportId)
        {
            try
            {
                var response = await SendAsync(HttpMethod.Get, $"/messaging/v3/reports/{reportId}");

                if (response.IsSuccessStatusCode)
                {
                    var responseObject = JsonConvert.DeserializeObject<Report>(response.Content);
                    return responseObject ?? new Report();
                }
                else
                {
                    throw new Exception($"Failed to get the Report. {response.Content}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Failed to get the Report. {ex.Message}");
            }
        }
    }
}
