using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.Connection;
using RiotNet.DataDragon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.DataDragon
{
	public class Item : IItem
	{
		private readonly DDragonRequest _request = new DDragonRequest();

		public async Task<JObject> GetAllItems()
		{
			string url = await _request.CreateURL("data", Convert.ToString(RiotNetAPI.Langs)!, "item.json");
			HttpResponseMessage responseMessage = await _request.MakeRequest(url);

			return await _request.GetContent(responseMessage);
		}

		public async Task<JObject> GetItemByID(int id)
		{
			JObject content = await GetAllItems();
			JToken jToken = content["object"]!["data"]![id]!;
			return jToken.ToObject<JObject>()!;
		}

		public async Task<string> GetItemImage(int id)
		{
			string url = await _request.CreateURL("img", "item", $"{id}.png");
			return url;
		}
	}
}
