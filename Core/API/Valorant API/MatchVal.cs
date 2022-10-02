using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.Valorant_API.Interfaces;
using RiotNet.Core.Connection;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Valorant_API
{
	public class MatchVal : IMatchVal
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetMatch(string matchId)
		{

			string baseUrl = _request.CreateApiUrl("match", "v1", "val"),
			methodEndpoint = $"matches/{matchId}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetMatchList(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "val"),
			methodEndpoint = $"matchlist/by-puuid/{puuid}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> RecentMatches(Queue queue)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "val"),
			methodEndpoint = $"recent-matches/by-queue/{queue}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
