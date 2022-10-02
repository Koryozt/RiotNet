using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.Valorant_API.Interfaces;
using RiotNet.Core.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Valorant_API
{
	public class Content : IContent
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetContent()
		{
			string baseUrl = _request.CreateApiUrl("content", "v1", "val"),
			methodEndpoint = "contents",
			url = baseUrl + methodEndpoint;

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
