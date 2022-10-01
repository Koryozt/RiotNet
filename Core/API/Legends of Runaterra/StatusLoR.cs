using Newtonsoft.Json.Linq;
using RiotNet.Core.API.GamesAPI.Interfaces;
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
	public class StatusLoR : IStatus
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> Status()
		{
			string baseUrl = _request.CreateApiUrl("status", "v1", "lor"),
			methodEndpoint = $"platform-data",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
