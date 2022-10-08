using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LegendsOfRunaterra.Interfaces;
using RiotNet.Connection.Interfaces;

namespace RiotNet.API.LegendsOfRunaterra
{
    public class Ranked : IRanked
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetLeaderboard()
		{
			string baseUrl = _request.CreateApiUrl("ranked", "v1", "lor", "matches");

			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
