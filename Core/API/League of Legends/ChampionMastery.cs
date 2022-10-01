using Newtonsoft.Json.Linq;
using RiotNet.Core.API.GamesAPI.Interfaces;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.Connection;
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

		public  async Task<JObject> GetChampionMastery(string encrypterSummonerID)
		{
			string baseUrl = _request.CreateApiUrl("champion-mastery", "v4"),
			championMasteryUrl = "champion-masteries/by-summoner/";

			string url = $"{baseUrl}{championMasteryUrl}/{encrypterSummonerID}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetChampionMastery(string encrypterSummonerID, int championId)
		{
			string baseUrl = _request.CreateApiUrl("champion-mastery", "v4"),
			championMasteryUrl = "champion-masteries/by-summoner/";

			string url = $"{baseUrl}{championMasteryUrl}/{encrypterSummonerID}/by-champion/{championId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetChampionMasterySorted(string encrypterSummonerID)
		{
			string baseUrl = _request.CreateApiUrl("champion-mastery", "v4"),
			championMasteryUrl = "champion-masteries/by-summoner/";

			string url = $"{baseUrl}{championMasteryUrl}/{encrypterSummonerID}/";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
		public async Task<JObject> GetChampionMasteryScores(string encrypterSummonerID)
		{
			string baseUrl = _request.CreateApiUrl("champion-mastery", "v4"),
			championMasteryUrl = "champion-masteries/scores/by-summoner/";

			string url = $"{baseUrl}{championMasteryUrl}/{encrypterSummonerID}/";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
