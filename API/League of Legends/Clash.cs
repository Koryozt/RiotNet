using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;

namespace RiotNet.API.LeagueOfLegends
{
	public class Clash : IClash
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> ClashPlayers(string summonerId)
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1"),
			clashUrl = "by-summoner/";

			string url = $"{baseUrl}{clashUrl}{summonerId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ClashTeams(string teamId)
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1"),
			clashUrl = "teams/";

			string url = $"{baseUrl}{clashUrl}{teamId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ClashTournaments()
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1"),
			clashUrl = "tournaments/";

			string url = $"{baseUrl}{clashUrl}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ClashTournamentTeam(string teamId)
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1"),
			clashUrl = "tournaments/by-team/";

			string url = $"{baseUrl}{clashUrl}{teamId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ClashTournamentById(string tournamentId)
		{
			string baseUrl = _request.CreateApiUrl("clash", "v1"),
			clashUrl = "tournaments/";

			string url = $"{baseUrl}{clashUrl}{tournamentId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
