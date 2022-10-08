using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;

namespace RiotNet.API.TeamfightTactics
{
    public class SummonerTFT : ISummoner
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetSummonerByAccountID(string encryptedAccountId)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v1", "tft", "summoners", "by-account", encryptedAccountId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);
				
			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerByAccountName(string summonerName)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v1", "tft", "summoners", "by-name", summonerName);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerByPUUID(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v1", "tft", "summoners", "by-puuid", puuid);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerBySummonerID(string summonerID)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v1", "tft", "summoners", summonerID);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
