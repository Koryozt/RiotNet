using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;

namespace RiotNet.API.LeagueOfLegends
{
	public class Rotations : IRotations
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetChampionsRotations()
		{
			string baseUrl = _request.CreateApiUrl("platform", "v3", "lol", "champion-rotations");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
