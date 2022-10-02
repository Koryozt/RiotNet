using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.Interfaces;
using RiotNet.Core.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API
{
	public class Account : IAccount
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetAccountByPUUID(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("account", "v1", "riot"),
			methodEndpoint = $"accounts/by-puuid/{puuid}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetAccountByRiotID(string gameName, string tagLine)
		{
			string baseUrl = _request.CreateApiUrl("account", "v1", "riot"),
			methodEndpoint = $"accounts/by-riot-id/{gameName}/",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetActiveShard(string game, string puuid)
		{
			string baseUrl = _request.CreateApiUrl("account", "v1", "riot"),
			methodEndpoint = $"active-shards/by-game/{game}/by-puuid/{puuid}",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
