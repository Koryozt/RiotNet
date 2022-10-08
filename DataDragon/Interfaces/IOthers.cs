using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.DataDragon.Interfaces
{
	public interface IOthers
	{
		Task<JObject> GetAllSummonerSpells();
		Task<string> GetSummonerSpellAsset(string summonerSpell);
		Task<JObject> GetProfileIconsData();
		Task<string> GetProfileIconAsset(int iconId);
		Task<string> GetMinimapAsset(int mapId);
		Task<string> GetSpriteAsset(string sprite);
	}
}
