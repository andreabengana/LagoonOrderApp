using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using LagoonOrderApp.Services;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;



namespace LagoonOrderApp.Services
{
    public class HttpService
    {
        private HttpClient _client;

        public HttpService()
        {
            _client = new HttpClient();
        }

        public async Task<string> HttpGetRequest(string url)
        {
            string response = await _client.GetStringAsync(url);

            return response;
        }

        public async Task<HttpStatusCode> HttpPostRequest(string url, object body = null)
        {
            JsonConvertService convert = new JsonConvertService();

            string json = convert.ConvertToJson(body);

            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(url, content);

            return response.StatusCode;
        }
    }
}
