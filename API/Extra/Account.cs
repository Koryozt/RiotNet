using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.Interfaces;
using RiotNet.Core.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Extra
{
    public class Account : IAccount
    {
        private readonly IRequestApi _request = new Request();

        public async Task<JObject> GetAccountByPUUID(string puuid)
        {
            string url = _request.CreateApiUrl("account", "v1", "riot", "accounts", "by-puuid", puuid);
            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }

        public async Task<JObject> GetAccountByRiotID(string gameName, string tagLine)
        {
            string url = _request.CreateApiUrl("account", "v1", "riot", "accounts", "by-riot-id", gameName, tagLine);
            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }

        public async Task<JObject> GetActiveShard(string game, string puuid)
        {
            string url = _request.CreateApiUrl("account", "v1", "riot", "active-shards", "by-game", game, "by-puuid", puuid);
            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }
    }
}
