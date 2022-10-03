using Newtonsoft.Json.Linq;
using System.Text;

namespace RiotNet.API.Connection
{
    public class Request : IRequestApi
    {
        private readonly string _apiKey = RiotNetAPI.s_apikey;

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

        #nullable disable
        public string CreateApiUrl(string coreEndpoint, string version, string initial, params string[] endpointDetails)
        {
            try
            {
                string baseUrl = Configuration.s_baseUrl, executeAgainst;
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

                sb.AppendJoin('/', initial, coreEndpoint, version);

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
