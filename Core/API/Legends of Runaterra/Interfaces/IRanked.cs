using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Legends_of_Runaterra.Interfaces
{
	public interface IRanked
	{
		Task<JObject> Leaderboard();
	}
}
