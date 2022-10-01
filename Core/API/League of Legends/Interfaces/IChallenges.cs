using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.League_of_Legends.Interfaces
{
	public interface IChallenges
	{
		Task<JObject> ChallengesConfig();
		Task<JObject> ChallengesConfig(long challengeId);
		Task<JObject> ChallengesLeaderboards(long challengeId, Levels level, int? limit = null);
		Task<JObject> ChallengesPercentiles();
		Task<JObject> ChallengesPercentiles(long challengeId);
		Task<JObject> ChallengesPlayerProgress(string puuid);

	}
}
