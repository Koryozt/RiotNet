using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.Extra
{
    public class Account : IAccount
    {
        private readonly IRequest _request = new Request();

        public async Task<JObject> GetAccountByPUUID(string puuid)
        {
            string url = URL.RiotGamesRequestUrl("account", "v1", "riot", "accounts", "by-puuid", puuid);
            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }

        public async Task<JObject> GetAccountByRiotID(string gameName, string tagLine)
        {
            string url = URL.RiotGamesRequestUrl("account", "v1", "riot", "accounts", "by-riot-id", gameName, tagLine);
            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }

        public async Task<JObject> GetActiveShard(string game, string puuid)
        {
            string url = URL.RiotGamesRequestUrl("account", "v1", "riot", "active-shards", "by-game", game, "by-puuid", puuid);
            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }
    }
}
