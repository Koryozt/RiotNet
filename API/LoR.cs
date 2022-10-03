using Newtonsoft.Json.Linq;
using RiotNet.API.LegendsOfRunaterra;
using RiotNet.API.LegendsOfRunaterra.Interfaces;

namespace RiotNet.API
{
    public class LoR : IMatchLoR, IRanked
	{ 
		private readonly IMatchLoR _match;
		private readonly IRanked _ranked;

		public LoR()
		{
			_match = new Match();
			_ranked = new Ranked();
		}

		public Task<JObject> GetMatchesByID(string id)
		{
			return _match.GetMatchesByID(id);
		}

		public Task<JObject> GetMatchesByPUUID(string puuid)
		{
			return _match.GetMatchesByPUUID(puuid);
		}

		public Task<JObject> Leaderboard()
		{
			return _ranked.Leaderboard();
		}
	}
}
