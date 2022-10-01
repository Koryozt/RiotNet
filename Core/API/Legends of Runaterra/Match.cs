using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.Legends_of_Runaterra.Interfaces;
using RiotNet.Core.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Legends_of_Runaterra
{
	public class Match : IMatch
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetMatchesByID(string id)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "lor"),
			methodEndpoint = $"matches/{id}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetMatchesByPUUID(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "lor"),
			methodEndpoint = $"matches/by-puuid/{puuid}/ids",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
