using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.LeagueOfLegends
{
    public class Rotations : IRotations
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetChampionsRotations()
		{
			string url = URL.RiotGamesRequestUrl("platform", "v3", "lol", "champion-rotations");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
