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
	public class DDragon : IChampion//, IItem
	{
		private readonly IChampion _champion;
		
		public DDragon()
		{
			_champion = new Champion();
		}


		public Task<JObject> GetAllChampions()
		{
			return _champion.GetAllChampions();
		}

		public Task<JObject> GetChampionByName(string championName)
		{
			return _champion.GetChampionByName(championName);
		}

		public Task<string> GetChampionLoadingScreenAsset(string championName, int skin = 0)
		{
			return _champion.GetChampionLoadingScreenAsset(championName, skin);
		}

		public Task<string> GetChampionPassiveAsset(string championName)
		{
			return _champion.GetChampionPassiveAsset(championName);
		}

		public Task<string> GetChampionSplashAsset(string championName, int skin = 0)
		{
			return _champion.GetChampionSplashAsset(championName, skin);
		}

		public Task<string> GetChampionSquareAsset(string championName)
		{
			return _champion.GetChampionSquareAsset(championName);
		}

		public Task<string> GetAbilityAsset(string abilityName)
		{
			return _champion.GetAbilityAsset(abilityName);
		}
	}
}
