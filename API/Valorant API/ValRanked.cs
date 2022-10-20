using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.Valorant_API.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.API.Valorant_API
{
	public class ValRanked : IValRanked
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetQueueLeaderboard(string actId, int? size = 200, int? startIndex = 0)
		{
			string url = URL.RiotGamesRequestUrl("ranked", "v1", "val", "leaderboards", "by-act", actId);
			StringBuilder sb = new StringBuilder(url);
			sb.Append($"?size={size}&startIndex={startIndex}");

			url = sb.ToString();

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
