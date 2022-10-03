using Newtonsoft.Json.Linq;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface ISpectator
	{
		Task<JObject> SummonerActiveGame(string encryptedSummonerId);
		Task<JObject> FeaturedGames();
	}
}
