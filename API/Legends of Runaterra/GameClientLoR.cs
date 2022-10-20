using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.Legends_of_Runaterra.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.API.Legends_of_Runaterra
{
	public class GameClientLoR : IGameClientLoR
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetActiveDeck()
		{
			string url = URL.GameClientRequestUrlLoR("static-decklist");
			HttpResponseMessage response = await _request.MakeRequestWithoutHeaders(url);
			return await _request.GetContent(response);
		}

		public async Task<JObject> GetCardPositions()
		{
			string url = URL.GameClientRequestUrlLoR("positional-rectangles");
			HttpResponseMessage response = await _request.MakeRequestWithoutHeaders(url);
			return await _request.GetContent(response);
		}

		public async Task<JObject> GetGameResult()
		{
			string url = URL.GameClientRequestUrlLoR("game-result");
			HttpResponseMessage response = await _request.MakeRequestWithoutHeaders(url);
			return await _request.GetContent(response);
		}

		public async Task<string> GetGameState()
		{
			JObject content = await GetCardPositions();
			string state = Convert.ToString(content["GameState"])!;

			return state;
		}

		public async Task<JObject> GetRectangles()
		{
			JObject content = await GetCardPositions();
			JToken rectangles = content["Rectangles"]!;
			JObject parsed = rectangles.ToObject<JObject>()!;
			
			return parsed;
		}
	}
}
