using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.League_of_Legends;
using RiotNet.Core.API.Teamfight_Tactics.Interfaces;
using RiotNet.Core.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Teamfight_Tactics
{
	public class MatchTFT : IMatchTFT
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> Match(string matchId)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "tft"),
			methodEndpoint = $"matches/{matchId}";

			string url = $"{baseUrl}{methodEndpoint}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> MatchIDS(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "tft"),
			methodEndpoint = "matches/by-puuid";

			string url = $"{baseUrl}{methodEndpoint}/{puuid}/ids";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
