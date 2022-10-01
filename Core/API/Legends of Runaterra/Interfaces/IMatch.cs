using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Legends_of_Runaterra.Interfaces
{
	public interface IMatch
	{
		Task<JObject> GetMatchesByPUUID(string puuid);
		Task<JObject> GetMatchesByID(string id);
	}
}
