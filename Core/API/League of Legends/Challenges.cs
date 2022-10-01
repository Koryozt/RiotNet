using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.League_of_Legends.Interfaces;
using RiotNet.Core.Connection;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.League_of_Legends
{
	public class Challenges : IChallenges
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> ChallengesConfig()
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1"),
			methodEndpoint = "challenges/config",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ChallengesConfig(long challengeId)
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1"),
			methodEndpoint = $"challenges/{challengeId}/config",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ChallengesLeaderboards(long challengeId, Levels level, int? limit = null)
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1"),
			methodEndpoint = $"challenges/{challengeId}/leaderboards/by-level/{level}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ChallengesPercentiles()
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1"),
			methodEndpoint = $"challenges/percentiles",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ChallengesPercentiles(long challengeId)
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1"),
			methodEndpoint = $"challenges/{challengeId}/percentiles",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> ChallengesPlayerProgress(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("challenges", "v1"),
			methodEndpoint = $"player-data/{puuid}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
