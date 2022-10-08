using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.ValorantAPI.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Enums;
using RiotNet.Miscellaneous;

namespace RiotNet.API.ValorantAPI
{
    public class MatchVal : IMatchVal
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetMatch(string matchId)
		{

			string url = URL.RiotGamesRequestUrl("match", "v1", "val", "matches", matchId);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetMatchList(string puuid)
		{
			string url = URL.RiotGamesRequestUrl("match", "v1", "val", "matchlist", "by-puuid", puuid);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetRecentMatches(Queue queue)
		{
			string url = URL.RiotGamesRequestUrl("match", "v1", "val", "recent-matches", "by-queue", Convert.ToString(queue)!);
			HttpResponseMessage response = await _request.MakeRequest(url) ;

			return await _request.GetContent(response);
		}
	}
}
