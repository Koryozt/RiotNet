using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.GamesAPI.Interfaces
{
	public interface IChampionMastery
	{
		Task<JObject> GetChampionMastery(string encrypterSummonerID);
		Task<JObject> GetChampionMastery(string encrypterSummonerID, int championId);
		Task<JObject> GetChampionMasterySorted(string encrypterSummonerID);
		Task<JObject> GetChampionMasteryScores(string encrypterSummonerID);


	}
}
