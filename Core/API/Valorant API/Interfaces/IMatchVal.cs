using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Valorant_API.Interfaces
{
	public interface IMatchVal
	{
		Task<JObject> GetMatch(string matchId);
		Task<JObject> GetMatchList(string puuid);
		Task<JObject> RecentMatches(Queue queue);
	}
}
