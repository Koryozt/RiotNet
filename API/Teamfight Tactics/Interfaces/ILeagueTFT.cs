using Newtonsoft.Json.Linq;
using RiotNet.Enums;

namespace RiotNet.API.TeamfightTactics.Interfaces
{
    public interface ILeagueTFT
	{
		Task<JObject> GetLeague(AdvancedQueues queue);
		Task<JObject> GetLeague(string leagueId);
		Task<JObject> GetEntries(string summonerId);
		Task<JObject> GetEntries(Tier tier, Division division);
		Task<JObject> GetTop(Queue queue);

	}
}
