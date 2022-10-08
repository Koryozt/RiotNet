using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends
{
    public class ChampionMastery : IChampionMastery
	{
		private readonly IRequest _request = new Request();

		public  async Task<JObject> GetChampionMastery(string encrypterSummonerID)
		{
			string url = URL.RiotGamesRequestUrl("champion-mastery", "v4", "lol", "champion-masteries", "by-summoner", encrypterSummonerID);

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetChampionMastery(string encrypterSummonerID, int championId)
		{
			string strChId = Convert.ToString(championId);
			string url = URL.RiotGamesRequestUrl("champion-mastery", "v4", "lol", "champion-masteries", "by-summoner", encrypterSummonerID, "by-champion", strChId);

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetChampionMasterySorted(string encrypterSummonerID)
		{
			string url = URL.RiotGamesRequestUrl("champion-mastery", "v4", "lol", "champion-masteries", "by-summoner", encrypterSummonerID);

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
		public async Task<JObject> GetChampionMasteryScores(string encrypterSummonerID)
		{
			string url = URL.RiotGamesRequestUrl("champion-mastery", "v4", "lol", "champion-masteries", "scores", "by-summoner", encrypterSummonerID);

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
