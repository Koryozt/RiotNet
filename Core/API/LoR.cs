using Newtonsoft.Json.Linq;
using RiotNet.Core.API.GamesAPI.Interfaces;
using RiotNet.Core.API.Legends_of_Runaterra;
using RiotNet.Core.API.Legends_of_Runaterra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API
{
	public class LoR : IMatch, IRanked, IStatus
	{
		private readonly IMatch _match;
		private readonly IRanked _ranked;
		private readonly IStatus _status;

		public LoR()
		{
			_match = new Match();
			_ranked = new Ranked();
			_status = new StatusLoR();
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

		public Task<JObject> Status()
		{
			return _status.Status();
		}
	}
}
