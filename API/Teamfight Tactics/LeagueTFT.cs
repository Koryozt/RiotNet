using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.TeamfightTactics.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.TeamfightTactics
{
	public class LeagueTFT : ILeagueTFT
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetEntries(string summonerId)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft"),
			methodEndpoint = "entries/by-summoner";

			string url = $"{baseUrl}{methodEndpoint}/{summonerId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetEntries(Tier tier, Division division)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft"),
			methodEndpoint = "entries";

			string url = $"{baseUrl}{methodEndpoint}/{tier}/{division}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetLeague(AdvancedQueues queue)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft");
			string url = $"{baseUrl}{queue}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetLeague(string leagueId)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft"),
			methodEndpoint = "leagues";

			string url = $"{baseUrl}{methodEndpoint}/{leagueId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetTop(Queue queue)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft"),
			methodEndpoint = "rate-ladders/";

			string url = $"{baseUrl}{methodEndpoint}/{queue}/top";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
