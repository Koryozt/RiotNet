using Newtonsoft.Json.Linq;

namespace RiotNet.API.LegendsOfRunaterra.Interfaces
{
	public interface IRanked
	{
		Task<JObject> GetLeaderboard();
	}
}
