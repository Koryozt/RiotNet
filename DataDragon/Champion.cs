using Newtonsoft.Json.Linq;
using RiotNet.Connection;
using RiotNet.DataDragon.Interfaces;


namespace RiotNet.DataDragon
{
    public class Champion : IChampion
	{
		private readonly DDragonRequest _request = new();

		public async Task<JObject> GetAllChampions()
		{
			string url = await _request.CreateURL("data", Convert.ToString(RiotNetAPI.Langs)!, "champion.json");
			HttpResponseMessage responseMessage = await _request.MakeRequest(url);

			return await _request.GetContent(responseMessage);
		}

		public async Task<JObject> GetChampionByName(string championName)
		{
			if (!CheckParameter(championName))
				return null!;

			string url = await _request.CreateURL("data", Convert.ToString(RiotNetAPI.Langs)!, "champion", $"{championName}.json");
			HttpResponseMessage responseMessage = await _request.MakeRequest(url);

			return await _request.GetContent(responseMessage);
		}


		public async Task<string> GetChampionSquareAsset(string championName)
		{
			if (!CheckParameter(championName))
				return string.Empty;
			
			string name = $"{championName}.png";
			string url = await _request.CreateURL("img", "champion", name);


			return url;
		}

		public async Task<string> GetChampionLoadingScreenAsset(string championName, int skin = 0)
		{
			if (!CheckParameter(championName, skin))
				return string.Empty;

			string url = await _request.CreateURL("img", "champion", "loading", $"{championName}_{skin}.jpg");
			return url;
		}

		public async Task<string> GetChampionSplashAsset(string championName, int skin = 0)
		{
			if (!CheckParameter(championName, skin))
				return string.Empty;
			

			string url = await _request.CreateURL("img", "champion","splash", $"{championName}_{skin}.jpg");
			return url;
		}

		public async Task<string> GetChampionPassiveAsset(string championName)
		{
			if (!CheckParameter(championName))
				return string.Empty;
			

			string url = await _request.CreateURL("img", "passive", $"{championName}_P.png");
			return url;
		}

		public async Task<string> GetAbilityAsset(string abilityName)
		{
			if (!CheckParameter(abilityName))
				return string.Empty;
			

			string url = await _request.CreateURL("img", "spell", $"{abilityName}.png");
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
