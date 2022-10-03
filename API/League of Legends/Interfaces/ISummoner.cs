using Newtonsoft.Json.Linq;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface ISummoner
	{
		Task<JObject> GetSummonerByAccountID(string encryptedAccountId);
		Task<JObject> GetSummonerByAccountName(string summonerName);
		Task<JObject> GetSummonerByPUUID(string puuid);
		Task<JObject> GetSummonerBySummonerID(string summonerID);
	}
}
