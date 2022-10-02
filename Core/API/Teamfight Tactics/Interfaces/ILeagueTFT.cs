using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Teamfight_Tactics.Interfaces
{
	public interface ILeagueTFT
	{
		Task<JObject> League(AdvancedQueues queue);
		Task<JObject> League(string leagueId);
		Task<JObject> Entries(string summonerId);
		Task<JObject> Entries(Tier tier, Division division);
		Task<JObject> Top(Queue queue);

	}
}
