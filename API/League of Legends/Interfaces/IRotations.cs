using Newtonsoft.Json.Linq;

namespace RiotNet.API.LeagueOfLegends.Interfaces
{
	public interface IRotations
	{
		Task<JObject> ChampionsRotations();
	}
}
