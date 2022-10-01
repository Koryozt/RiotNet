using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.League_of_Legends.Interfaces
{
	public interface ISpectator
	{
		Task<JObject> SummonerActiveGame(string encryptedSummonerId);
		Task<JObject> FeaturedGames();
	}
}
