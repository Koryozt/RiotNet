using Newtonsoft.Json.Linq;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface IChallenges
	{
		Task<JObject> GetChallengesConfig();
		Task<JObject> GetChallengesConfig(long challengeId);
		Task<JObject> GetChallengesLeaderboards(long challengeId, Levels level, int? limit = null);
		Task<JObject> GetChallengesPercentiles();
		Task<JObject> GetChallengesPercentiles(long challengeId);
		Task<JObject> GetChallengesPlayerProgress(string puuid);

	}
}
