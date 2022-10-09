using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.Connection;
using RiotNet.Connection.Interfaces;
using RiotNet.DataDragon.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.DataDragon
{
    public class Champion : IChampion
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetAllChampions()
		{
			string url = await URL.DataDragonRequestURL("data", Convert.ToString(RiotNetAPI.Langs)!, "champion.json");
			HttpResponseMessage responseMessage = await _request.MakeRequest(url);

			return await _request.GetContent(responseMessage);
		}

		public async Task<JObject> GetChampionByName(string championName)
		{
			if (!CheckParameter(championName))
				return null!;

			string url = await URL.DataDragonRequestURL("data", Convert.ToString(RiotNetAPI.Langs)!, "champion", $"{championName}.json");
			HttpResponseMessage responseMessage = await _request.MakeRequest(url);

			return await _request.GetContent(responseMessage);
		}


		public async Task<string> GetChampionSquareAsset(string championName)
		{
			if (!CheckParameter(championName))
				return string.Empty;
			
			string name = $"{championName}.png";
			string url = await URL.DataDragonRequestURL("img", "champion", name);


			return url;
		}

		public async Task<string> GetChampionLoadingScreenAsset(string championName, int skin = 0)
		{
			if (!CheckParameter(championName, skin))
				return string.Empty;

			string url = await URL.DataDragonRequestURL("img", "champion", "loading", $"{championName}_{skin}.jpg");
			return url;
		}

		public async Task<string> GetChampionSplashAsset(string championName, int skin = 0)
		{
			if (!CheckParameter(championName, skin))
				return string.Empty;
			

			string url = await URL.DataDragonRequestURL("img", "champion","splash", $"{championName}_{skin}.jpg");
			return url;
		}

		public async Task<string> GetChampionPassiveAsset(string championName)
		{
			if (!CheckParameter(championName))
				return string.Empty;
			

			string url = await URL.DataDragonRequestURL("img", "passive", $"{championName}_P.png");
			return url;
		}

		public async Task<string> GetAbilityAsset(string abilityName)
		{
			if (!CheckParameter(abilityName))
				return string.Empty;
			

			string url = await URL.DataDragonRequestURL("img", "spell", $"{abilityName}.png");
			return url;
		}

		private bool CheckParameter(string name, int? number = null)
		{
			// TODO: Make custom exceptions.
			if (!string.IsNullOrEmpty(name) || char.IsUpper(name[0]))
				return true;
			if (number is not null)
				return number < 0 ? false : true;
			
			return false;
		}	
	}
}
