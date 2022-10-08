using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;

namespace RiotNet.API.LeagueOfLegends
{
    public class Clash : IClash
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetClashPlayers(string summonerId)
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1", "lol", "by-summoner", summonerId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetClashTeams(string teamId)
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1", "lol", "teams", teamId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetClashTournaments()
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1","lol", "tournaments");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetClashTournamentTeam(string teamId)
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1", "lol", "tournaments", "by-team", teamId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetClashTournamentById(string tournamentId)
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1", "tournaments", tournamentId);
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
