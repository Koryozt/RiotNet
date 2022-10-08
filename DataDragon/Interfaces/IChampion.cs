using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.DataDragon.Interfaces
{
	public interface IChampion
	{
		Task<JObject> GetAllChampions();
		Task<JObject> GetChampionByName(string championName);
		Task<string> GetChampionSquareAsset(string championName);
		Task<string> GetChampionSplashAsset(string championName, int skin = 0);
		Task<string> GetChampionLoadingScreenAsset(string championName, int skin = 0);
		Task<string> GetChampionPassiveAsset(string championName);
		Task<string> GetAbilityAsset(string abilityName);
	}
}
