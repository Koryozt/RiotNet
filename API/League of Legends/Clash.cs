using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends
{
    public class Clash : IClash
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetClashPlayers(string summonerId)
		{
			string url = URL.RiotGamesRequestUrl("clash", "v1", "lol", "by-summoner", summonerId);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetClashTeams(string teamId)
		{
			string url = URL.RiotGamesRequestUrl("clash", "v1", "lol", "teams", teamId);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetClashTournaments()
		{
			string url = URL.RiotGamesRequestUrl("clash", "v1","lol", "tournaments");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetClashTournamentTeam(string teamId)
		{
			string url = URL.RiotGamesRequestUrl("clash", "v1", "lol", "tournaments", "by-team", teamId);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetClashTournamentById(string tournamentId)
		{
			string url = URL.RiotGamesRequestUrl("clash", "v1", "tournaments", tournamentId);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
