using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.GamesAPI.Interfaces
{
	public interface IRotations
	{
		Task<JObject> ChampionsRotations();
	}
}
