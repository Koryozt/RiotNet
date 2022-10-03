using Newtonsoft.Json.Linq;

namespace RiotNet.API.TeamfightTactics.Interfaces
{
	public interface IMatchTFT
	{
		Task<JObject> GetMatchIDS(string puuid);
		Task<JObject> GetMatch(string matchId);
	}
}
