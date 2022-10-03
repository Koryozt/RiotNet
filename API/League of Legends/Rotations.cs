using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.LeagueOfLegends.Interfaces;

namespace RiotNet.API.LeagueOfLegends
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
