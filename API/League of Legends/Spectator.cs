using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends
{
    public class Spectator : ISpectator
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetFeaturedGames()
		{
			string url = URL.RiotGamesRequestUrl("spectator", "v4", "lol", "featured-games");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetSummonerActiveGame(string encryptedSummonerId)
		{
			string url = URL.RiotGamesRequestUrl("spectator", "v4", "lol", "active-games", "by-summoner", encryptedSummonerId);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
