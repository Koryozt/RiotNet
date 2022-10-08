using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Enums;

namespace RiotNet.API.LeagueOfLegends
{
    public class League : ILeague
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetQueue(AdvancedQueues league, Queue queue)
		{
			string baseUrl = _request.CreateApiUrl("league", "v4", "lol", Convert.ToString(league)!, "by-queue", Convert.ToString(queue)!);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetEntries(string encryptedSummoner)
		{
			string baseUrl = _request.CreateApiUrl("league", "v4", "lol", "entries", "by-summoner", encryptedSummoner);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetEntries(Division division, Tier tier, Queue queue, int page = 1)
		{
			string baseUrl = _request.CreateApiUrl("league", "v4", "lol", "entries", Convert.ToString(queue)!, Convert.ToString(tier)!, Convert.ToString(division)!);

			HttpResponseMessage response = await _request.MakeRequest(baseUrl + $"?page={page}");

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetLeagues(string leagueId)
		{
			string baseUrl = _request.CreateApiUrl("league", "v4", "lol", "leagues", leagueId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

	}
}
