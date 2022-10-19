using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.GameClient.Interfaces
{
	public interface ILiveClientData
	{
		Task<JObject> GetActivePlayer();
		Task<JObject> GetActivePlayer(string datakey = "name");
		Task<JObject> GetPlayerScore(string summonerName);
		Task<JObject> GetPlayerSpells(string summonerName);
		Task<JObject> GetPlayerRunes(string summonerName);
		Task<JObject> GetPlayerItems(string summonerName); 
		Task<JObject> GetGameEvents();
		Task<JObject> GetGameData();
		Task<JObject> GetAllPlayers();
	}
}
