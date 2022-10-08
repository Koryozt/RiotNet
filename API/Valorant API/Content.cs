using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.ValorantAPI.Interfaces;
using RiotNet.Connection.Interfaces;

namespace RiotNet.API.ValorantAPI
{
    public class Content : IContent
	{
		private readonly IRequestApi _request = new Request();

		public async Task<JObject> GetContent()
		{
			string baseUrl = _request.CreateApiUrl("content", "v1", "val", "contents");
			HttpResponseMessage response = await _request.MakeRequest(baseUrl);

			return await _request.GetResponseContent(response);
		}
	}
}
