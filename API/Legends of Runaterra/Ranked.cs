using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LegendsOfRunaterra.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LegendsOfRunaterra
{
    public class Ranked : IRanked
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetLeaderboard()
		{
			string url = URL.RiotGamesRequestUrl("ranked", "v1", "lor", "matches");

			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
