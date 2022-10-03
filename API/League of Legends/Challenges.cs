using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends
{
	public class Challenges : IChallenges
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetChallengesConfig()
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1", "lol", "challenges", "config");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetChallengesConfig(long challengeId)
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1", "lol", "challenges", Convert.ToString(challengeId), "config");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetChallengesLeaderboards(long challengeId, Levels level, int? limit = null)
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1", "lol", "challenges", Convert.ToString(challengeId), "leaderboards", "by-level", Convert.ToString(level)!);

			if (limit is not null)
				baseUrl += $"?limit={limit}";

			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetChallengesPercentiles()
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1", "lol", "challenges", "percentiles");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetChallengesPercentiles(long challengeId)
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1", "lol", "challenges", Convert.ToString(challengeId), "percentiles");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetChallengesPlayerProgress(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1","lol", "player-data", puuid);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
