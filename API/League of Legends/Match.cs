using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends
{
    public class Match : IMatch
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetMatch(string id)
		{
			string url = URL.RiotGamesRequestUrl("match", "v5", "lol", "matches", id);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetMatchIDS(string puuid)
		{
			string url = URL.RiotGamesRequestUrl("match", "v5", "lol", "matches", "by-puuid", puuid, "ids");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetMatchTimeline(string matchId)
		{
			string url = URL.RiotGamesRequestUrl("match", "v5", "lol", "matches", matchId, "timeline");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
