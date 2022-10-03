using Newtonsoft.Json.Linq;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface IClash
	{
		Task<JObject> ClashPlayers(string summonerId);
		Task<JObject> ClashTeams(string teamId);
		Task<JObject> ClashTournaments();
		Task<JObject> ClashTournamentTeam(string teamId);
		Task<JObject> ClashTournamentById(string tournamentId);
	}
}
