using Newtonsoft.Json.Linq;
using RiotNet.Core.API.GamesAPI.Interfaces;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.Connection;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.GamesAPI.LeagueOfLegends
{
	public class StatusLoL : IStatus
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> Status()
		{
			string url = _request.CreateApiUrl("status", "v4");
			url += "platform-data";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
