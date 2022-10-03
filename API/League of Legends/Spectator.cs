using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;

namespace RiotNet.API.LeagueOfLegends
{
	public class Spectator : ISpectator
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetFeaturedGames()
		{
			string baseUrl = _request.CreateApiUrl("spectator", "v4", "lol", "featured-games");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetSummonerActiveGame(string encryptedSummonerId)
		{
			string baseUrl = _request.CreateApiUrl("spectator", "v4", "lol", "active-games", "by-summoner", encryptedSummonerId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
