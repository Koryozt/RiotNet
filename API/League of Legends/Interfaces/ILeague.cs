using Newtonsoft.Json.Linq;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface ILeague
	{
		Task<JObject> GetQueue(AdvancedQueues league, Queue queue);
		Task<JObject> GetEntries(string encryptedSummoner);
		Task<JObject> GetEntries(Division division, Tier tier, Queue queue, int page = 1);
		Task<JObject> GetLeagues(string leagueId);
	}
}
