using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;

namespace RiotNet.API.LeagueOfLegends
{
    public class Match : IMatch
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetMatch(string id)
		{
			string baseUrl = _request.CreateApiUrl("match", "v5", "lol", "matches", id);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetMatchIDS(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("match", "v5", "lol", "matches", "by-puuid", puuid, "ids");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetMatchTimeline(string matchId)
		{
			string baseUrl = _request.CreateApiUrl("match", "v5", "lol", "matches", matchId, "timeline");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
