using Newtonsoft.Json.Linq;
using RiotNet.Connection.Interfaces;
using RiotNet.Exceptions;
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
                    
                    ValidateStatusCode(response);
                    
                    return response;
                }
                catch (HttpMethodException Ex)
                {
                    Console.WriteLine(Ex.Message);
                    return new HttpResponseMessage();
                }
            }
        }

		public async Task<HttpResponseMessage> MakeRequestWithoutHeaders(string url)
		{
			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage response = await client.GetAsync(url);
				response.EnsureSuccessStatusCode();

				return response;
			}
		}

		public async Task<JObject> GetContent(HttpResponseMessage response)
        {
            string strJson = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(strJson);
            return json;
        }

        private static void ValidateStatusCode(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                throw new HttpMethodException(((int)response.StatusCode));
            }
        }
    }
}
