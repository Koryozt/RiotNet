using Newtonsoft.Json.Linq;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.API.TeamfightTactics;
using RiotNet.API.TeamfightTactics.Interfaces;
using RiotNet.Enums;

namespace RiotNet.API
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

		public Task<JObject> GetEntries(string summonerId)
		{
			return _league.GetEntries(summonerId);
		}

		public Task<JObject> GetEntries(Tier tier, Division division)
		{
			return _league.GetEntries(tier, division);
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

		public Task<JObject> GetLeague(AdvancedQueues queue)
		{
			return _league.GetLeague(queue);
		}

		public Task<JObject> GetLeague(string leagueId)
		{
			return _league.GetLeague(leagueId);
		}

		public Task<JObject> GetMatch(string matchId)
		{
			return _match.GetMatch(matchId);
		}

		public Task<JObject> GetMatchIDS(string puuid)
		{
			return _match.GetMatchIDS(puuid);
		}

		public Task<JObject> GetTop(Queue queue)
		{
			return _league.GetTop(queue);
		}
	}
}
