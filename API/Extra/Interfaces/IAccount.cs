using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Interfaces
{
	public interface IAccount
	{
		Task<JObject> GetAccountByPUUID(string puuid);
		Task<JObject> GetAccountByRiotID(string gameName, string tagLine);
		Task<JObject> GetActiveShard(string game, string puuid);
	}
}
