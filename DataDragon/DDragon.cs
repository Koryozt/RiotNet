using Newtonsoft.Json.Linq;
using RiotNet.API.ValorantAPI;
using RiotNet.DataDragon.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.DataDragon
{
	public class DDragon : IChampion, IItem
	{
		private readonly DDragonRequest _request = new();

		public async Task<JObject> GetAllChampions()
		{
			string url = await _request.CreateURL("data", Convert.ToString(RiotNetAPI.Langs)!, "champion.json");
			HttpResponseMessage responseMessage = await _request.MakeRequest(url);

			return await _request.GetContent(responseMessage);
		}

		public async Task<JObject> GetAllItems()
		{
			string url = await _request.CreateURL("data", Convert.ToString(RiotNetAPI.Langs)!, "item.json");
			HttpResponseMessage responseMessage = await _request.MakeRequest(url);

			return await _request.GetContent(responseMessage);
		}

		public async Task<JObject> GetChampionByName(string championName)
		{
			JObject champions = await GetAllChampions();
			JToken token = champions["data"]![championName]!;
			return token.ToObject<JObject>()!;
		}

		public async Task<string> GetChampionImage(string championName)
		{
			JObject champion = await GetChampionByName(championName);
			JToken image = champion["image"]!["full"]!;
			string url = await _request.CreateURL("img", "champion", image.ToString());

			return url;
		}

		public async Task SaveImage(string url, string fileName)
		{
			HttpResponseMessage response = await _request.MakeRequest(url);
			string path = Path.Combine(Directory.GetCurrentDirectory(), $"src{Path.DirectorySeparatorChar}{fileName}.png"); 

			using (FileStream fs = new FileStream(path, FileMode.Create))
			{
				await response.Content.CopyToAsync(fs);
				Console.WriteLine("File created at: " + path);
			}
		}

		public async Task<string> GetChampionSprite(string championName)
		{
			JObject champion = await GetChampionByName(championName);
			JToken image = champion["image"]!["sprite"]!;
			string url = await _request.CreateURL("img", "champion", image.ToString());

			return url;
		}

		public async Task<JObject> GetItemByID(int id)
		{
			JObject content = await GetAllItems();
			JToken jToken = content["object"]!["data"]![id]!;
			return jToken.ToObject<JObject>()!;
		}

		public async Task<string> GetItemImage(int id)
		{
			JObject content = await GetItemByID(id);
			JToken jToken = content["image"]!["full"]!;
			string url = await _request.CreateURL("img", "item", jToken.ToString());

			return url;
		}
	}
}
