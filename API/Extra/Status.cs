using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.Interfaces;
using RiotNet.Connection.Interfaces;
using System.Threading.Tasks;

namespace RiotNet.API.Extra
{
    public class Status : IStatus
    {
        private readonly IRequestApi _request = new Request();

        public async Task<JObject> LoLStatus()
        {
            string url = _request.CreateApiUrl("status", "v4","lol", "platform-data");

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }

        public async Task<JObject> LoRStatus()
        {
            string url = _request.CreateApiUrl("status", "v1", "lor", "platform-data");

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }

        public async Task<JObject> TFTStatus()
        {
            string url = _request.CreateApiUrl("status", "v1", "tft", "platform-data");

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }
        public async Task<JObject> ValorantStatus()
        {
            string url = _request.CreateApiUrl("status", "v1", "val", "platform-data");

			HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }
    }
}
