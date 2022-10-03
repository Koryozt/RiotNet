using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;

namespace RiotNet.API.LeagueOfLegends
{
	internal class Summoner : ISummoner
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetSummonerByAccountID(string encryptedAccountId)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v4", "lol", "summoners", "by-account", encryptedAccountId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerByAccountName(string summonerName)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v4", "lol", "summoners", "by-name", summonerName);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerByPUUID(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v4", "lol", "summoners", "by-puuod", puuid);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerBySummonerID(string summonerID)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v4", "lol", "summoners", summonerID);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
