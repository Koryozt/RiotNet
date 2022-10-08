using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RiotNet.Connection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Connection
{
    public class DDragonRequest : IDDragonRequest
    {
        private readonly string _versionsUrl = "https://ddragon.leagueoflegends.com/api/versions.json";
        private readonly string _base = "http://ddragon.leagueoflegends.com/cdn/";

        public async Task<string> CreateURL(params string[] endpoints)
        {
            StringBuilder sb = new StringBuilder(_base);
            string version = await GetLatestVersion();
            sb.Append(version).Append('/');
            sb.AppendJoin('/', endpoints);

            return sb.ToString();
        }

        public async Task<JObject> GetContent(HttpResponseMessage response)
        {
            string strJson = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(strJson);
            return json;
        }

        public async Task<HttpResponseMessage> MakeRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                return response;
            }
        }

        public async Task<string> GetLatestVersion()
        {
            HttpResponseMessage response = await MakeRequest(_versionsUrl);
            string str = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<string[]>(str)!.First();
        }
    }
}
