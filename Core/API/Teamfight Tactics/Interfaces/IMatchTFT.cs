using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Teamfight_Tactics.Interfaces
{
	public interface IMatchTFT
	{
		Task<JObject> MatchIDS(string puuid);
		Task<JObject> Match(string matchId);
	}
}
