using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.ValorantAPI.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Enums;

namespace RiotNet.API.ValorantAPI
{
    public class MatchVal : IMatchVal
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetMatch(string matchId)
		{

			string baseUrl = _request.CreateApiUrl("match", "v1", "val", "matches", matchId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetMatchList(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "val", "matchlist", "by-puuid", puuid);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetRecentMatches(Queue queue)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "val", "recent-matches", "by-queue", Convert.ToString(queue)!);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl) ;

			return await _request.GetResponseContent(response);
		}
	}
}
