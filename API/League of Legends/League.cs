using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Enums;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends
{
    public class League : ILeague
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetQueue(AdvancedQueues league, Queue queue)
		{
			string url = URL.RiotGamesRequestUrl("league", "v4", "lol", Convert.ToString(league)!, "by-queue", Convert.ToString(queue)!);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetEntries(string encryptedSummoner)
		{
			string url = URL.RiotGamesRequestUrl("league", "v4", "lol", "entries", "by-summoner", encryptedSummoner);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetEntries(Division division, Tier tier, Queue queue, int page = 1)
		{
			string url = URL.RiotGamesRequestUrl("league", "v4", "lol", "entries", Convert.ToString(queue)!, Convert.ToString(tier)!, Convert.ToString(division)!);

			HttpResponseMessage response = await _request.MakeRequest(url + $"?page={page}");

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetLeagues(string leagueId)
		{
			string url = URL.RiotGamesRequestUrl("league", "v4", "lol", "leagues", leagueId);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

	}
}
