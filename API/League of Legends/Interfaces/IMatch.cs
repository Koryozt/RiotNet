using Newtonsoft.Json.Linq;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface IMatch
	{
		Task<JObject> GetMatchIDS(string puuid);
		Task<JObject> GetMatch(string id);
		Task<JObject> GetMatchTimeline(string matchId);
	}
}
