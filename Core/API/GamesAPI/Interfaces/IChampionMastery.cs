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
		Task<JObject> Get(string apiKey, string encrypterSummonerID, Platforms platform);
		Task<JObject> Get(string apiKey, string encrypterSummonerID, int championId, Platforms platform);
		Task<JObject> GetSorted(string apiKey, string encrypterSummonerID, Platforms platform);
		Task<JObject> GetScores(string apiKey, string encrypterSummonerID, Platforms platform);


	}
}
