using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.API.Valorant_API.Interfaces
{
	public interface IValRanked
	{
		Task<JObject> GetQueueLeaderboard(string actId, int? size = 200, int? startIndex = 0);
	}
}
