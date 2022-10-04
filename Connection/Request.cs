using Newtonsoft.Json.Linq;
using System.Text;

namespace RiotNet.API.Connection
{
    public class Request : IRequestApi
    {
        private static string s_baseUrl = "https://.api.riotgames.com/";

        public async Task<HttpResponseMessage> MakeRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("X-Riot-Token", RiotNetAPI.s_apikey);
                client.DefaultRequestHeaders.Add("Origin", "https://developer.riotgames.com");

                HttpResponseMessage response = await client.GetAsync(url);

                response.EnsureSuccessStatusCode();

                return response;
            }
        }

        public async Task<JObject> GetResponseContent(HttpResponseMessage response)
        {
            string strJson = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(strJson);
            return json;
        }

        #nullable disable
        public string CreateApiUrl(string coreEndpoint, string version, string initial, params string[] endpointDetails)
        {
            try
            {
                string baseUrl = s_baseUrl, executeAgainst;
                StringBuilder sb = new StringBuilder(baseUrl);

                switch (initial)
                {
                    case "lol":
                    case "tft":
                        executeAgainst = Convert.ToString(RiotNetAPI.LoLPlatform).ToLower();
                        sb.Insert(8, executeAgainst);
                        break;
                    case "lor":
                        executeAgainst = Convert.ToString(RiotNetAPI.LoRPlatform).ToLower();
                        sb.Insert(8, executeAgainst);
                        break;
                    case "val":
                        executeAgainst = Convert.ToString(RiotNetAPI.ValorantPlatform).ToLower();
                        sb.Insert(8, executeAgainst);
                        break;
                    case "riot":
                        executeAgainst = Convert.ToString(RiotNetAPI.AccountPlatform).ToLower();
                        sb.Insert(8, executeAgainst);
                        break;
                }

                sb.AppendJoin('/', initial, coreEndpoint, version).Append('/');

                if (endpointDetails is not null)
                    
                    sb.AppendJoin('/', endpointDetails).Append('/');
                
                return sb.ToString();
                
            }
            catch (ArgumentNullException)
            {
                throw;
            }
        }
        #nullable enable

    }
}
