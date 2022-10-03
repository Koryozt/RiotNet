using Newtonsoft.Json.Linq;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface IClash
	{
		Task<JObject> GetClashPlayers(string summonerId);
		Task<JObject> GetClashTeams(string teamId);
		Task<JObject> GetClashTournaments();
		Task<JObject> GetClashTournamentTeam(string teamId);
		Task<JObject> GetClashTournamentById(string tournamentId);
	}
}
