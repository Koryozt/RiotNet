using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Enums;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends
{
    public class Challenges : IChallenges
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetChallengesConfig()
		{
			string url = URL.RiotGamesRequestUrl("challenges", "v1", "lol", "challenges", "config");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetChallengesConfig(long challengeId)
		{
			string url = URL.RiotGamesRequestUrl("challenges", "v1", "lol", "challenges", Convert.ToString(challengeId), "config");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetChallengesLeaderboards(long challengeId, Levels level, int? limit = null)
		{
			string strChId = Convert.ToString(challengeId);
			string strLvl = Convert.ToString(level)!;
			string url = URL.RiotGamesRequestUrl("challenges", "v1", "lol", "challenges", strChId, "leaderboards", "by-level", strLvl);

			if (limit is not null)
				url += $"?limit={limit}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetChallengesPercentiles()
		{
			string url = URL.RiotGamesRequestUrl("challenges", "v1", "lol", "challenges", "percentiles");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetChallengesPercentiles(long challengeId)
		{
			string url = URL.RiotGamesRequestUrl("challenges", "v1", "lol", "challenges", Convert.ToString(challengeId), "percentiles");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetChallengesPlayerProgress(string puuid)
		{
			string url = URL.RiotGamesRequestUrl("challenges", "v1","lol", "player-data", puuid);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
