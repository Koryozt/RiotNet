using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.TeamfightTactics.Interfaces;

namespace RiotNet.API.TeamfightTactics
{
	public class MatchTFT : IMatchTFT
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetMatch(string matchId)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "tft", "matches", matchId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetMatchIDS(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "tft", "matches", "by-puuid", puuid, "ids");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
