using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.ValorantAPI.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API.ValorantAPI
{
    public class Content : IContent
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetContent()
		{
			string url = URL.RiotGamesRequestUrl("content", "v1", "val", "contents");
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
