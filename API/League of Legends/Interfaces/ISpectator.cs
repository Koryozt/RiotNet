using Newtonsoft.Json.Linq;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface ISpectator
	{
		Task<JObject> GetSummonerActiveGame(string encryptedSummonerId);
		Task<JObject> GetFeaturedGames();
	}
}
