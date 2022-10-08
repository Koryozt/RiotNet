using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;
using System.Threading.Tasks;

namespace RiotNet.API.Extra
{
    public class Status : IStatus
    {
        private readonly IRequest _request = new Request();

        public async Task<JObject> LoLStatus()
        {
            string url = URL.RiotGamesRequestUrl("status", "v4","lol", "platform-data");
            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }

        public async Task<JObject> LoRStatus()
        {
            string url = URL.RiotGamesRequestUrl("status", "v1", "lor", "platform-data");
            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }

        public async Task<JObject> TFTStatus()
        {
            string url = URL.RiotGamesRequestUrl("status", "v1", "tft", "platform-data");

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }
        public async Task<JObject> ValorantStatus()
        {
            string url = URL.RiotGamesRequestUrl("status", "v1", "val", "platform-data");

			HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }
    }
}
