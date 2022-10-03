using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;

namespace RiotNet.API.LeagueOfLegends
{
	public class Spectator : ISpectator
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> FeaturedGames()
		{
			string baseUrl = _request.CreateApiUrl("spectator", "v4"),
			methodEndpoint = $"featured-games",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> SummonerActiveGame(string encryptedSummonerId)
		{
			string baseUrl = _request.CreateApiUrl("spectator", "v4"),
			methodEndpoint = $"active-games/by-summoner/{encryptedSummonerId}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
