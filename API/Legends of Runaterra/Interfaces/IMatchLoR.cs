using Newtonsoft.Json.Linq;

namespace RiotNet.API.LegendsOfRunaterra.Interfaces
{
	public interface IMatchLoR
	{
		Task<JObject> GetMatchesByPUUID(string puuid);
		Task<JObject> GetMatchesByID(string id);
	}
}
