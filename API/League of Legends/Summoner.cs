using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends
{
    internal class Summoner : ISummoner
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetSummonerByAccountID(string encryptedAccountId)
		{
			string url = URL.RiotGamesRequestUrl("summoner", "v4", "lol", "summoners", "by-account", encryptedAccountId);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetSummonerByAccountName(string summonerName)
		{
			string url = URL.RiotGamesRequestUrl("summoner", "v4", "lol", "summoners", "by-name", summonerName);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetSummonerByPUUID(string puuid)
		{
			string url = URL.RiotGamesRequestUrl("summoner", "v4", "lol", "summoners", "by-puuod", puuid);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetSummonerBySummonerID(string summonerID)
		{
			string url = URL.RiotGamesRequestUrl("summoner", "v4", "lol", "summoners", summonerID);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
