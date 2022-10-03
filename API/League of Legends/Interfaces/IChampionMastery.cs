using Newtonsoft.Json.Linq;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface IChampionMastery
	{
		Task<JObject> GetChampionMastery(string encrypterSummonerID);
		Task<JObject> GetChampionMastery(string encrypterSummonerID, int championId);
		Task<JObject> GetChampionMasterySorted(string encrypterSummonerID);
		Task<JObject> GetChampionMasteryScores(string encrypterSummonerID);


	}
}
