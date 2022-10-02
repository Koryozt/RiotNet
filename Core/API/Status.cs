using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API
{
	public class Status : IStatus
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> LoLStatus()
		{
			string baseUrl = _request.CreateApiUrl("status", "v4"),
			methodEndpoint = $"platform-data",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> LoRStatus()
		{
			string baseUrl = _request.CreateApiUrl("status", "v1", "lor"),
			methodEndpoint = $"platform-data",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> TFTStatus()
		{
			string baseUrl = _request.CreateApiUrl("status", "v1", "tft"),
			methodEndpoint = $"platform-data",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
		public async Task<JObject> ValorantStatus()
		{
			string baseUrl = _request.CreateApiUrl("status", "v1", "val"),
			methodEndpoint = $"platform-data",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
