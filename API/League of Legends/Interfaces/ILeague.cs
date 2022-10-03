using Newtonsoft.Json.Linq;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface ILeague
	{
		Task<JObject> Queue(AdvancedQueues league, Queue queue);
		Task<JObject> Entries(string encryptedSummoner);
		Task<JObject> Entries(Division division, Tier tier, Queue queue, int page = 1);
		Task<JObject> Leagues(string leagueId);
	}
}
