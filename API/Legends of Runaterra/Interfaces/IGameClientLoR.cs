using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.API.Legends_of_Runaterra.Interfaces
{
	public interface IGameClientLoR
	{
		Task<JObject> GetActiveDeck();
		Task<JObject> GetCardPositions();
		Task<string> GetGameState();
		Task<JObject> GetRectangles();
		Task<JObject> GetGameResult();
	}
}
