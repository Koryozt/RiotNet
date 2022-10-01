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

namespace RiotNet.Core.API
{
    public class Request : IRequestApi
    {
        public async Task<HttpResponseMessage> MakeRequest(string apiKey, string url)
        {
            Configuration.client.DefaultRequestHeaders.Add("X-Riot-Token", apiKey);
            Configuration.client.DefaultRequestHeaders.Add("Origin", "https://developer.riotgames.com");

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

        public string CreateApiUrl(Platforms platform, string endpoint, string? version = null, string game = "lol")
        {
            try
            {
                string url = Configuration.s_baseUrl.Insert(8, platform.ToString());
                url += $"{game}/{endpoint}/{version}/";

                return url;
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
    }
}
