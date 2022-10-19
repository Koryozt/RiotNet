using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.Connection.Interfaces;
using RiotNet.Exceptions;
using RiotNet.GameClient.Interfaces;
using RiotNet.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace RiotNet.GameClient.Methods
{
	public class LiveClientData : ILiveClientData
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetActivePlayer()
		{
			string url = URL.GameClientRequestUrl(endpoints: new string[] { "liveclientdata", "activeplayer" } );
			HttpResponseMessage response = await _request.MakeGameRequest(url);
			
			return await _request.GetContent(response);
		}

		public async Task<JObject> GetActivePlayer(string datakey = "name")
		{
			string url = URL.GameClientRequestUrl(endpoints: new string[] { "liveclientdata", "activeplayer" + datakey });
			HttpResponseMessage response = await _request.MakeGameRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetAllPlayers()
		{
			string url = URL.GameClientRequestUrl(endpoints: new string[] { "liveclientdata", "playerlist" });
			HttpResponseMessage response = await _request.MakeGameRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetGameData()
		{
			string url = URL.GameClientRequestUrl(endpoints: new string[] { "liveclientdata", "gamestats" });
			HttpResponseMessage response = await _request.MakeGameRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetGameEvents()
		{
			string url = URL.GameClientRequestUrl(endpoints: new string[] { "liveclientdata", "eventdata" });
			HttpResponseMessage response = await _request.MakeGameRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetPlayerItems(string summonerName)
		{
			string param = HttpUtility.UrlEncode(summonerName),
			url = URL.GameClientRequestUrl(true, "liveclientdata", "playeritems") + param;

			HttpResponseMessage response = await _request.MakeGameRequest(url);

			return await _request.GetContent(response);

		}

		public async Task<JObject> GetPlayerRunes(string summonerName)
		{
			string param = HttpUtility.UrlEncode(summonerName),
			url = URL.GameClientRequestUrl(true, "liveclientdata", "playermainrunes") + param;

			HttpResponseMessage response = await _request.MakeGameRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetPlayerScore(string summonerName)
		{
			string param = HttpUtility.UrlEncode(summonerName),
			url = URL.GameClientRequestUrl(true, "liveclientdata", "playerscores") + param;
			Console.WriteLine(url);
			HttpResponseMessage response = await _request.MakeGameRequest(url);

			return await _request.GetContent(response);
		}

		public async Task<JObject> GetPlayerSpells(string summonerName)
		{
			string param = HttpUtility.UrlEncode(summonerName),
			url = URL.GameClientRequestUrl(true, "liveclientdata", "playersummonerspells") + param;

			HttpResponseMessage response = await _request.MakeGameRequest(url);

			return await _request.GetContent(response);
		}
	}
}
