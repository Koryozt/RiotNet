using Newtonsoft.Json.Linq;
using RiotNet.Core.API.League_of_Legends.Interfaces;
using RiotNet.Core.API.Teamfight_Tactics;
using RiotNet.Core.API.Teamfight_Tactics.Interfaces;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API
{
    public class TFT : ILeagueTFT, IMatchTFT, ISummoner
	{
		private readonly ILeagueTFT _league;
		private readonly IMatchTFT _match;
		private readonly ISummoner _summoner;

		public TFT()
		{
			_league = new LeagueTFT();
			_match = new MatchTFT();
			_summoner = new SummonerTFT();
		}

		public Task<JObject> Entries(string summonerId)
		{
			return _league.Entries(summonerId);
		}

		public Task<JObject> Entries(Tier tier, Division division)
		{
			return _league.Entries(tier, division);
		}

		public Task<JObject> GetSummonerByAccountID(string encryptedAccountId)
		{
			return _summoner.GetSummonerByAccountID(encryptedAccountId);
		}

		public Task<JObject> GetSummonerByAccountName(string summonerName)
		{
			return _summoner.GetSummonerByAccountName(summonerName);
		}

		public Task<JObject> GetSummonerByPUUID(string puuid)
		{
			return _summoner.GetSummonerByPUUID(puuid);
		}

		public Task<JObject> GetSummonerBySummonerID(string summonerID)
		{
			return _summoner.GetSummonerBySummonerID(summonerID);
		}

		public Task<JObject> League(AdvancedQueues queue)
		{
			return _league.League(queue);
		}

		public Task<JObject> League(string leagueId)
		{
			return _league.League(leagueId);
		}

		public Task<JObject> Match(string matchId)
		{
			return _match.Match(matchId);
		}

		public Task<JObject> MatchIDS(string puuid)
		{
			return _match.MatchIDS(puuid);
		}

		public Task<JObject> Top(Queue queue)
		{
			return _league.Top(queue);
		}
	}
}
