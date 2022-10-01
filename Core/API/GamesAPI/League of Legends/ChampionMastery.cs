using Newtonsoft.Json.Linq;
using RiotNet.Core.API.GamesAPI.Interfaces;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.GamesAPI.LeagueOfLegends
{
	public class ChampionMastery : IChampionMastery
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> Get(string apiKey, string encrypterSummonerID, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "champion-mastery", "v4"),
			championMasteryUrl = "champion-masteries/by-summoner/";

			string url = $"{baseUrl}{championMasteryUrl}/{encrypterSummonerID}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> Get(string apiKey, string encrypterSummonerID, int championId, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "champion-mastery", "v4"),
			championMasteryUrl = "champion-masteries/by-summoner/";

			string url = $"{baseUrl}{championMasteryUrl}/{encrypterSummonerID}/by-champion/{championId}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSorted(string apiKey, string encrypterSummonerID, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "champion-mastery", "v4"),
			championMasteryUrl = "champion-masteries/by-summoner/";

			string url = $"{baseUrl}{championMasteryUrl}/{encrypterSummonerID}/";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}
		public async Task<JObject> GetScores(string apiKey, string encrypterSummonerID, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "champion-mastery", "v4"),
			championMasteryUrl = "champion-masteries/scores/by-summoner/";

			string url = $"{baseUrl}{championMasteryUrl}/{encrypterSummonerID}/";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}
	}
}
