using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LegendsOfRunaterra.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LegendsOfRunaterra
{
    public class Match : IMatchLoR
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetMatchesByID(string id)
		{
			string url = URL.RiotGamesRequestUrl("match", "v1", "lor", "matches", id);

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetMatchesByPUUID(string puuid)
		{
			string url = URL.RiotGamesRequestUrl("match", "v1", "lor", "matches", "by-puuid", puuid, "ids");

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
