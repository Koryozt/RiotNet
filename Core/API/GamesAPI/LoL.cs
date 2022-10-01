using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API
{
    public class LoL 
    {

		#region ClashMethods

        public async Task<JObject> ClashPlayers(string apiKey, string summonerId, Platforms platform)
        {
            string baseUrl = _request.CreateApiUrl(platform, "clash", "v1"),
            clashUrl = "by-summoner/";

            string url = $"{baseUrl}{clashUrl}{summonerId}";

            HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

            return await _request.GetResponseContent(response);
        }

        public async Task<JObject> ClashTeams(string apiKey, string teamId, Platforms platform)
        {
			string baseUrl = _request.CreateApiUrl(platform, "clash", "v1"),
            clashUrl = "teams/";

			string url = $"{baseUrl}{clashUrl}{teamId}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ClashTournaments(string apiKey, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "clash", "v1"),
			clashUrl = "tournaments/";

			string url = $"{baseUrl}{clashUrl}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ClashTournamentTeam(string apiKey, string teamId, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "clash", "v1"),
			clashUrl = "tournaments/by-team/";

			string url = $"{baseUrl}{clashUrl}{teamId}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ClashTournamentById(string apiKey, string tournamentId, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "clash", "v1"),
			clashUrl = "tournaments/";

			string url = $"{baseUrl}{clashUrl}{tournamentId}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		#endregion

		#region LeagueMethods

		public async Task<JObject> Queue(string apiKey, AdvancedQueues league, Queue queue, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "league", "v4"),
			challengerleaguesUrl = $"{league}/by-queue/";

			string url = $"{baseUrl}{challengerleaguesUrl}{queue}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> Entries(string apiKey, string encryptedSummoner, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "league", "v4"),
			entriesUrl = "entries/by-summoner/";

			string url = $"{baseUrl}{entriesUrl}{encryptedSummoner}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> Entries(string apiKey, Division division, Tier tier, Queue queue, Platforms platform, int page = 1)
		{
			string baseUrl = _request.CreateApiUrl(platform, "league", "v4"),
			entriesUrl = "entries/";

			string url = $"{baseUrl}{entriesUrl}{queue}/{tier}/{division}?page={page}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> League(string apiKey, string leagueId, Platforms platform)
		{
			string baseUrl = _request.CreateApiUrl(platform, "league", "v4"),
			leaguesUrl = "leagues/";

			string url = $"{baseUrl}{leaguesUrl}{leagueId}";

			HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

			return await _request.GetResponseContent(response);
		}

		#endregion



		public async Task<JObject> ChampionsRotation(string apiKey, Platforms platform)
        {
            string baseUrl = _request.CreateApiUrl(platform, "platform", "v3"),
            rotationUrl = "champion-rotations";

            string url = $"{baseUrl}{rotationUrl}";

            HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

            return await _request.GetResponseContent(response);
        }

		public async Task<JObject> Status(string apiKey, Platforms platform)
        {
            string url = _request.CreateApiUrl(platform, "status", "v4");
            url += "platform-data";

            HttpResponseMessage response = await _request.MakeRequest(apiKey, url);

            return await _request.GetResponseContent(response);
        }
    }
}
