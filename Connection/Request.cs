using Newtonsoft.Json.Linq;
using RiotNet.Connection.Interfaces;
using RiotNet.Exceptions;
using RiotNet.Miscellaneous;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;

namespace RiotNet.API.Connection
{
    public class Request : IRequest
    {
        public async Task<HttpResponseMessage> MakeRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.DefaultRequestHeaders.Add("X-Riot-Token", RiotNetAPI.Apikey);
                    client.DefaultRequestHeaders.Add("Origin", "https://developer.riotgames.com");

                    HttpResponseMessage response = await client.GetAsync(url);
                    
                    Validation.ValidateStatusCode(response);
                    
                    return response;
                }
                catch (HttpMethodException)
                {
                    throw;
                }
            }
        }

        public async Task<HttpResponseMessage> MakeRequestWithoutHeaders(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    
                    Validation.ValidateStatusCode(response);

                    return response;
                }
                catch (HttpMethodException)
                {
                    throw;
                }
            }
        }


        public async Task<HttpResponseMessage> MakeGameRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    Validation.ValidatePortOpened();
                    Validation.ValidateServerCertificate();

                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    return response;
                }
                catch (GameNotStartedException)
                {
                    throw;
                }
            }
        }

        public async Task<JObject> GetContent(HttpResponseMessage response)
        {
            string strJson = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(strJson);
            return json;
        }
    }
}
