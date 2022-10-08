using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LegendsOfRunaterra.Interfaces;
using RiotNet.Connection.Interfaces;

namespace RiotNet.API.LegendsOfRunaterra
{
    public class Match : IMatchLoR
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetMatchesByID(string id)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "lor", "matches", id);

			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}

		public async Task<JObject> GetMatchesByPUUID(string puuid)
		{
			string baseUrl = _request.CreateApiUrl("match", "v1", "lor", "matches", "by-puuid", puuid, "ids");

			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
