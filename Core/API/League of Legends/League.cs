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
	public class League : ILeague
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> Queue(AdvancedQueues league, Queue queue)
		{
			string baseUrl = _request.CreateApiUrl("league", "v4"),
			challengerleaguesUrl = $"{league}/by-queue/";

			string url = $"{baseUrl}{challengerleaguesUrl}{queue}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> Entries(string encryptedSummoner)
		{
			string baseUrl = _request.CreateApiUrl("league", "v4"),
			entriesUrl = "entries/by-summoner/";

			string url = $"{baseUrl}{entriesUrl}{encryptedSummoner}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> Entries(Division division, Tier tier, Queue queue, int page = 1)
		{
			string baseUrl = _request.CreateApiUrl("league", "v4"),
			entriesUrl = "entries/";

			string url = $"{baseUrl}{entriesUrl}{queue}/{tier}/{division}?page={page}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> Leagues(string leagueId)
		{
			string baseUrl = _request.CreateApiUrl("league", "v4"),
			leaguesUrl = "leagues/";

			string url = $"{baseUrl}{leaguesUrl}{leagueId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

	}
}
