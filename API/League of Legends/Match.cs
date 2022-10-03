using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;

namespace RiotNet.API.LeagueOfLegends
{
	public class Match : IMatch
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetMatch(string id)
		{
			string baseUrl = _request.CreateApiUrl("match", "v5"),
			methodEndpoint = $"matches/{id}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetMatchIDS(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("match", "v5"),
			methodEndpoint = $"matches/by-puuid/{puuid}/ids",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetMatchTimeline(string matchId)
		{
			string baseUrl = _request.CreateApiUrl("match", "v5"),
			methodEndpoint = $"matches/{matchId}/timeline",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
