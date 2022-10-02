using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace RiotNet.Core.Connection
{
    public class Request : IRequestApi
    {
        private readonly string _apiKey = RiotNetAPI.apikey;
        private readonly Platforms _platform = RiotNetAPI.platform;
        private readonly Region _region = RiotNetAPI.region;

        public async Task<HttpResponseMessage> MakeRequest(string url)
        {
            Configuration.client.DefaultRequestHeaders.Add("X-Riot-Token", _apiKey);
            Configuration.client.DefaultRequestHeaders.Add("Origin", "https://developer.riotgames.com");

            Console.WriteLine($"Executing request to: {url}");

            HttpResponseMessage response = await Configuration.client.GetAsync(url);

            response.EnsureSuccessStatusCode();

            return response;
        }

        public async Task<JObject> GetResponseContent(HttpResponseMessage response)
        {
            string strJson = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(strJson);
            return json;
        }

        public string CreateApiUrl(string endpoint, string? version = null, string game = "lol")
        {
            try
            {
                string url = string.Empty;
                
                if (game == "lor")
                {
                    #nullable disable
                    string strRegion = Convert.ToString(_region).ToLower();

                    url = Configuration.s_baseUrl.Insert(8, strRegion);
                }
                
                string strPlatform = Convert.ToString(_platform);

				url = Configuration.s_baseUrl.Insert(8, strPlatform);
                url += $"{game}/{endpoint}/{version}/";
                
                #nullable enable

				return url;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
    }
}
