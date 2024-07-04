using com.telstra.messaging.Models.Common;
using com.telstra.messaging.Utils;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace com.telstra.messaging.Common
{
    public abstract class Client
    {
        private readonly HttpClient _httpClient;
        private readonly AuthConfig _authConfig;
        private AuthToken? _authToken;

        public Client(Credentials credentials)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(Constants.BASE_PATH)
            };

            if (credentials.HasValues)
            {
                _authConfig = new AuthConfig(credentials);
            }
            else
            {
                _authConfig = new AuthConfig();
            }
        }

        public async Task<Response> SendAsync(HttpMethod httpMethod, string path, object? payload = null, QueryParams? queryParams = null)
        {
            //var isReportParams = payload?.GetType().ToString() == "com.telstra.messaging.Models.Reports.CreateReportsParams";
            queryParams = queryParams ?? new QueryParams(10, 0, null);
            // Check AccessToken validitiy
            if (_authToken == null || string.IsNullOrEmpty(_authToken.AccessToken) || _authToken.IsExpired)
            {
                var response = await RenewToken();
                if (!response.IsSuccessStatusCode)
                    return new Response(await response.Content.ReadAsStringAsync(), response.IsSuccessStatusCode);
            }

            // Build Request
            var serializeOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            };

            if (payload?.GetType().ToString() == "com.telstra.messaging.Models.Reports.CreateReportsParams")
            {
                serializeOptions = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                    WriteIndented = true,
                    DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                    Converters = { new CustomDateTimeConverter() }
                };
            }

            var msgAPIRequest = (HttpWebRequest)WebRequest.Create($"{Constants.BASE_PATH}{path}{queryParams.BuildQueryString()}");
            msgAPIRequest.Accept = "application/json";
            msgAPIRequest.ContentType = "application/json";
            msgAPIRequest.Method = httpMethod.Method;
            msgAPIRequest.Headers.Add("Telstra-api-version", "3.x");
            msgAPIRequest.Headers.Add("Accept-Charset", "utf-8");
            msgAPIRequest.Headers.Add("Authorization", $"Bearer {_authToken?.AccessToken}");
            msgAPIRequest.Headers.Add("Content-Language", "en-au");

            // Hack to allow GET request to contain a body
            var type = msgAPIRequest.GetType();
            var currentMethod = type.GetProperty("CurrentMethod", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(msgAPIRequest);
            var methodType = currentMethod.GetType();
            methodType.GetField("ContentBodyNotAllowed", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(currentMethod, false);

            using (var streamWriter = new StreamWriter(msgAPIRequest.GetRequestStream()))
            {
                streamWriter.Write(JsonSerializer.Serialize(payload ?? new object(), serializeOptions));
            }

            var msgAPIResponse = (HttpWebResponse)msgAPIRequest.GetResponse();
            var success = (int)msgAPIResponse.StatusCode >= 200 && (int)msgAPIResponse.StatusCode < 300;
            using var stream = msgAPIResponse.GetResponseStream();
            using var reader = new StreamReader(stream, Encoding.UTF8);
            return new Response(reader.ReadToEnd(), success);
        }

        public async Task<HttpResponseMessage> RenewToken()
        {
            HttpRequestMessage msgAPIRequest = new HttpRequestMessage(HttpMethod.Post, "/v2/oauth/token");

            var formData = new Dictionary<string, string>
            {
                { "grant_type", "client_credentials" },
                { "client_id", _authConfig.AuthCredentials.ClientId },
                { "client_secret", _authConfig.AuthCredentials.ClientSecret },
                { "scope", "free-trial-numbers:read free-trial-numbers:write messages:read messages:write virtual-numbers:read virtual-numbers:write reports:read reports:write" }
            };
            msgAPIRequest.Content = new FormUrlEncodedContent(formData);
            msgAPIRequest.Headers.Add("Accept", "*/*");

            HttpResponseMessage response = await _httpClient.SendAsync(msgAPIRequest);

            if (response.IsSuccessStatusCode)
            {
                var authRespObject = JObject.Parse(await response.Content.ReadAsStringAsync().ConfigureAwait(false));
                var accessToken = authRespObject["access_token"]?.ToString();
                int.TryParse(authRespObject["expires_in"]?.ToString(), out int expiresIn);
                var tokenType = authRespObject["token_type"]?.ToString();

                _authToken = new AuthToken(accessToken ?? string.Empty, tokenType ?? string.Empty, expiresIn);
            }

            return response;
        }
    }
}