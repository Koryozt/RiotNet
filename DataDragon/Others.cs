using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.Connection;
using RiotNet.Connection.Interfaces;
using RiotNet.DataDragon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.DataDragon
{
	public class Others : IOthers
	{
		private readonly IDDragonRequest _request = new DataDragonRequest();
		public async Task<JObject> GetAllSummonerSpells()
		{
			string url = await _request.CreateURL("data", Convert.ToString(RiotNetAPI.Langs)!, "summoner.json");
			HttpResponseMessage responseMessage = await _request.MakeRequest(url);

			return await _request.GetContent(responseMessage);
		}

		public async Task<string> GetMinimapAsset(int mapId)
		{
			string url = await _request.CreateURL("img", "map", $"map{mapId}.png");
			return url;
		}

		public async Task<string> GetProfileIconAsset(int iconId)
		{
			string url = await _request.CreateURL("img", "profileicon", $"{iconId}.png");
			return url;
		}

		public async Task<JObject> GetProfileIconsData()
		{
			string url = await _request.CreateURL("data", Convert.ToString(RiotNetAPI.Langs)!, $"profileicon.json");
			HttpResponseMessage response = await _request.MakeRequest(url);
			return await _request.GetContent(response);
		}

		public async Task<string> GetSpriteAsset(string sprite)
		{
			string url = await _request.CreateURL("img", "sprite", $"{sprite}.png");
			return url;
		}

		public async Task<string> GetSummonerSpellAsset(string summonerSpell)
		{
			string url = await _request.CreateURL("img", "spell", $"{summonerSpell}.png");
			return url;
		}
	}
}
