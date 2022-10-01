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
	public class Ranked : IRanked
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> Leaderboard()
		{
			string baseUrl = _request.CreateApiUrl("ranked", "v1", "lor"),
			methodEndpoint = "matches",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
