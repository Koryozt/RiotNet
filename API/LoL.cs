using Newtonsoft.Json.Linq;
using RiotNet.API.LeagueOfLegends;
using RiotNet.API.LeagueOfLegends.Interfaces;
using RiotNet.Miscellaneous;

namespace RiotNet.API
{
    public class LoL : IChampionMastery, IClash, ILeague, IRotations, IChallenges, ISpectator, IMatch, ISummoner
    {
        private readonly IChampionMastery _championMastery;
        private readonly IClash _clash;
        private readonly ILeague _league;
        private readonly IRotations _rotations;
        private readonly IChallenges _challenges;
        private readonly ISpectator _spectator;
        private readonly IMatch _match;
        private readonly ISummoner _summoner;

        public LoL()
        {
            _championMastery = new ChampionMastery();
            _clash = new Clash();
            _league = new League();
            _rotations = new Rotations();
            _challenges = new Challenges();
            _spectator = new Spectator();
            _match = new Match();
            _summoner = new Summoner();
        }

        public Task<JObject> GetChallengesConfig()
        {
            return _challenges.GetChallengesConfig();
        }

        public Task<JObject> GetChallengesConfig(long challengeId)
        {
            return _challenges.GetChallengesConfig(challengeId);
        }

        public Task<JObject> GetChallengesLeaderboards(long challengeId, Levels level, int? limit = null)
        {
            return _challenges.GetChallengesLeaderboards(challengeId, level, limit);
        }

        public Task<JObject> GetChallengesPercentiles()
        {
            return _challenges.GetChallengesPercentiles();
        }

        public Task<JObject> GetChallengesPercentiles(long challengeId)
        {
            return _challenges.GetChallengesPercentiles(challengeId);
        }

        public Task<JObject> GetChallengesPlayerProgress(string puuid)
        {
            return _challenges.GetChallengesPlayerProgress(puuid);
        }

        public Task<JObject> GetChampionsRotations()
        {
            return _rotations.GetChampionsRotations();
        }

        public Task<JObject> GetClashPlayers(string summonerId)
        {
            return _clash.GetClashPlayers(summonerId);
        }

        public Task<JObject> GetClashTeams(string teamId)
        {
            return _clash.GetClashTeams(teamId);
        }

        public Task<JObject> GetClashTournamentById(string tournamentId)
        {
            return _clash.GetClashTournamentById(tournamentId);
        }

        public Task<JObject> GetClashTournaments()
        {
            return _clash.GetClashTournaments();
        }

        public Task<JObject> GetClashTournamentTeam(string teamId)
        {
            return _clash.GetClashTournamentTeam(teamId);
        }

        public Task<JObject> GetEntries(string encryptedSummoner)
        {
            return _league.GetEntries(encryptedSummoner);
        }

        public Task<JObject> GetEntries(Division division, Tier tier, Queue queue, int page = 1)
        {
            return _league.GetEntries(division, tier, queue, page);
        }

        public Task<JObject> GetFeaturedGames()
        {
            return _spectator.GetFeaturedGames();
        }

        public Task<JObject> GetChampionMastery(string encrypterSummonerID)
        {
            return _championMastery.GetChampionMastery(encrypterSummonerID);
        }

        public Task<JObject> GetChampionMastery(string encrypterSummonerID, int championId)
        {
            return _championMastery.GetChampionMastery(encrypterSummonerID, championId);
        }

        public Task<JObject> GetChampionMasteryScores(string encrypterSummonerID)
        {
            return _championMastery.GetChampionMasteryScores(encrypterSummonerID);
        }

        public Task<JObject> GetChampionMasterySorted(string encrypterSummonerID)
        {
            return _championMastery.GetChampionMasterySorted(encrypterSummonerID);
        }

        public Task<JObject> GetMatch(string id)
        {
            return _match.GetMatch(id);
        }

        public Task<JObject> GetMatchIDS(string puuid)
        {
            return _match.GetMatchIDS(puuid);
        }

        public Task<JObject> GetMatchTimeline(string matchId)
        {
            return _match.GetMatchTimeline(matchId);
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

        public Task<JObject> GetLeagues(string leagueId)
        {
            return _league.GetLeagues(leagueId);
        }

        public Task<JObject> GetQueue(AdvancedQueues league, Queue queue)
        {
            return _league.GetQueue(league, queue);
        }

        public Task<JObject> GetSummonerActiveGame(string encryptedSummonerId)
        {
            return _spectator.GetSummonerActiveGame(encryptedSummonerId);
        }
    }
}
