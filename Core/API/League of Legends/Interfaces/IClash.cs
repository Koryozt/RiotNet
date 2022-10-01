using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.GamesAPI.Interfaces
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
