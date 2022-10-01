using Newtonsoft.Json.Linq;
using RiotNet.Core.API.GamesAPI.Interfaces;
using RiotNet.Core.API.GamesAPI.LeagueOfLegends;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.League_of_Legends;
using RiotNet.Core.API.League_of_Legends.Interfaces;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.GamesAPI
{
    public class LoL : IChampionMastery, IClash, IStatus, ILeague, IRotations, IChallenges, ISpectator, IMatch, ISummoner
    {
        private readonly IChampionMastery _championMastery;
        private readonly IClash _clash;
        private readonly ILeague _league;
        private readonly IRotations _rotations;
        private readonly IStatus _status;
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
            _status = new StatusLoL();
            _challenges = new Challenges();
            _spectator = new Spectator();
            _match = new Match();
            _summoner = new Summoner();
        }

        public Task<JObject> ChallengesConfig()
        {
            return _challenges.ChallengesConfig();
        }

        public Task<JObject> ChallengesConfig(long challengeId)
        {
            return _challenges.ChallengesConfig(challengeId);
        }

        public Task<JObject> ChallengesLeaderboards(long challengeId, Levels level, int? limit = null)
        {
            return _challenges.ChallengesLeaderboards(challengeId, level, limit);
        }

        public Task<JObject> ChallengesPercentiles()
        {
            return _challenges.ChallengesPercentiles();
        }

        public Task<JObject> ChallengesPercentiles(long challengeId)
        {
            return _challenges.ChallengesPercentiles(challengeId);
        }

        public Task<JObject> ChallengesPlayerProgress(string puuid)
        {
            return _challenges.ChallengesPlayerProgress(puuid);
        }

        public Task<JObject> ChampionsRotations()
        {
            return _rotations.ChampionsRotations();
        }

        public Task<JObject> ClashPlayers(string summonerId)
        {
            return _clash.ClashPlayers(summonerId);
        }

        public Task<JObject> ClashTeams(string teamId)
        {
            return _clash.ClashTeams(teamId);
        }

        public Task<JObject> ClashTournamentById(string tournamentId)
        {
            return _clash.ClashTournamentById(tournamentId);
        }

        public Task<JObject> ClashTournaments()
        {
            return _clash.ClashTournaments();
        }

        public Task<JObject> ClashTournamentTeam(string teamId)
        {
            return _clash.ClashTournamentTeam(teamId);
        }

        public Task<JObject> Entries(string encryptedSummoner)
        {
            return _league.Entries(encryptedSummoner);
        }

        public Task<JObject> Entries(Division division, Tier tier, Queue queue, int page = 1)
        {
            return _league.Entries(division, tier, queue, page);
        }

        public Task<JObject> FeaturedGames()
        {
            return _spectator.FeaturedGames();
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

        public Task<JObject> Leagues(string leagueId)
        {
            return _league.Leagues(leagueId);
        }

        public Task<JObject> Status()
        {
            return _status.Status();
        }

        public Task<JObject> Queue(AdvancedQueues league, Queue queue)
        {
            return _league.Queue(league, queue);
        }

        public Task<JObject> SummonerActiveGame(string encryptedSummonerId)
        {
            return _spectator.SummonerActiveGame(encryptedSummonerId);
        }
    }
}
