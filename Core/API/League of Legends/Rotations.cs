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
	public class Rotations : IRotations
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> ChampionsRotations()
		{
			string baseUrl = _request.CreateApiUrl("platform", "v3"),
			rotationUrl = "champion-rotations";

			string url = $"{baseUrl}{rotationUrl}";

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetResponseContent(response);
		}
	}
}
