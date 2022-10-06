using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.DataDragon.Interfaces
{
	public interface IChampion
	{
		Task<JObject> GetAllChampions();
		Task<JObject> GetChampionByName(string championName);
		Task<string> GetChampionImage(string championName);
	}
}
