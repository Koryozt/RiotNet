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
	public class DDragon : IChampion, IItem, IOthers
	{
		private readonly IChampion _champion;
		private readonly IOthers _others;
		private readonly IItem _item;
		
		public DDragon()
		{
			_champion = new Champion();
			_others = new Others();
			_item = new Item();
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

		public Task<JObject> GetAllItems()
		{
			return _item.GetAllItems();
		}

		public Task<JObject> GetItemByID(int id)
		{
			return _item.GetItemByID(id);
		}

		public Task<string> GetItemImage(int id)
		{
			return _item.GetItemImage(id);
		}

		public Task<JObject> GetAllSummonerSpells()
		{
			return _others.GetAllSummonerSpells();
		}

		public Task<string> GetSummonerSpellAsset(string summonerSpell)
		{
			return _others.GetSummonerSpellAsset(summonerSpell);
		}

		public Task<JObject> GetProfileIconsData()
		{
			return _others.GetProfileIconsData();
		}

		public Task<string> GetProfileIconAsset(int iconId)
		{
			return _others.GetProfileIconAsset(iconId);
		}

		public Task<string> GetMinimapAsset(int mapId)
		{
			return _others.GetMinimapAsset(mapId);
		}

		public Task<string> GetSpriteAsset(string sprite)
		{
			return _others.GetSpriteAsset(sprite);
		}
	}
}
