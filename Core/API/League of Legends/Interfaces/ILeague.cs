using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.GamesAPI.Interfaces
{
	public interface ILeague
	{
		Task<JObject> Queue(AdvancedQueues league, Queue queue);
		Task<JObject> Entries(string encryptedSummoner);
		Task<JObject> Entries(Division division, Tier tier, Queue queue, int page = 1);
		Task<JObject> Leagues(string leagueId);
	}
}
