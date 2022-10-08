using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.TeamfightTactics.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.TeamfightTactics
{
    public class MatchTFT : IMatchTFT
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetMatch(string matchId)
		{
			string url = URL.RiotGamesRequestUrl("match", "v1", "tft", "matches", matchId);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetMatchIDS(string puuid)
		{
			string url = URL.RiotGamesRequestUrl("match", "v1", "tft", "matches", "by-puuid", puuid, "ids");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
