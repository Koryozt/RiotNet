using Newtonsoft.Json.Linq;
using RiotNet.Enums;

namespace RiotNet.API.ValorantAPI.Interfaces
{
    public interface IMatchVal
	{
		Task<JObject> GetMatch(string matchId);
		Task<JObject> GetMatchList(string puuid);
		Task<JObject> GetRecentMatches(Queue queue);
	}
}
