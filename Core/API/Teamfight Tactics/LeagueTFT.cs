using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.League_of_Legends;
using RiotNet.Core.API.Teamfight_Tactics.Interfaces;
using RiotNet.Core.Connection;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Teamfight_Tactics
{
	public class LeagueTFT : ILeagueTFT
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> Entries(string summonerId)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft"),
			methodEndpoint = "entries/by-summoner";

			string url = $"{baseUrl}{methodEndpoint}/{summonerId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> Entries(Tier tier, Division division)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft"),
			methodEndpoint = "entries";

			string url = $"{baseUrl}{methodEndpoint}/{tier}/{division}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> League(AdvancedQueues queue)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft");
			string url = $"{baseUrl}{queue}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> League(string leagueId)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft"),
			methodEndpoint = "leagues";

			string url = $"{baseUrl}{methodEndpoint}/{leagueId}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> Top(Queue queue)
		{
			string baseUrl = _request.CreateApiUrl("league", "v1", "tft"),
			methodEndpoint = "rate-ladders/";

			string url = $"{baseUrl}{methodEndpoint}/{queue}/top";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
