using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.League_of_Legends.Interfaces
{
	public interface ISummoner
	{
		Task<JObject> GetSummonerByAccountID(string encryptedAccountId);
		Task<JObject> GetSummonerByAccountName(string summonerName);
		Task<JObject> GetSummonerByPUUID(string puuid);
		Task<JObject> GetSummonerBySummonerID(string summonerID);
	}
}
