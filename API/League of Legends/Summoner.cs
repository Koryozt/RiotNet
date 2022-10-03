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
			string baseUrl = _request.CreateApiUrl("summoner", "v4"),
			methodEndpoint = $"summoners/by-account/{encryptedAccountId}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerByAccountName(string summonerName)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v4"),
			methodEndpoint = $"summoners/by-name/{summonerName}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerByPUUID(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v4"),
			methodEndpoint = $"summoners/by-puuid/{puuid}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerBySummonerID(string summonerID)
		{
			string baseUrl = _request.CreateApiUrl("summoner", "v4"),
			methodEndpoint = $"summoners/{summonerID}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
