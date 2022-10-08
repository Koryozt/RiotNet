using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;

namespace RiotNet.API.LeagueOfLegends
{
    public class ChampionMastery : IChampionMastery
	{
		private readonly IRequestApi _request = new Request();

		public  async Task<JObject> GetChampionMastery(string encrypterSummonerID)
		{
			string baseUrl = _request.CreateApiUrl("champion-mastery", "v4", "lol", "champion-masteries", "by-summoner", encrypterSummonerID);

			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetChampionMastery(string encrypterSummonerID, int championId)
		{
			string baseUrl = _request.CreateApiUrl("champion-mastery", "v4", "lol", "champion-masteries", "by-summoner", encrypterSummonerID, "by-champion", Convert.ToString(championId));

			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetChampionMasterySorted(string encrypterSummonerID)
		{
			string baseUrl = _request.CreateApiUrl("champion-mastery", "v4", "lol", "champion-masteries", "by-summoner", encrypterSummonerID);

			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
		public async Task<JObject> GetChampionMasteryScores(string encrypterSummonerID)
		{
			string baseUrl = _request.CreateApiUrl("champion-mastery", "v4", "lol", "champion-masteries", "scores", "by-summoner", encrypterSummonerID);

			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
