using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using RiotNet.Core.API.GamesAPI;
using RiotNet.Core.API.GamesAPI.Interfaces;
using RiotNet.Core.Connection;
using RiotNet.Core.Miscellaneous;

namespace RiotNet
{
	class Program
	{
		public static async Task Main(string[] args)
		{
            RiotNetAPI create = new ("RGAPI-abc97b0e-6e5b-4f8e-89cd-6b22528f6e3a", Platforms.la1, Region.AMERICAS);
			LoL league = new LoL();

			JObject response = await league.GetSummonerByAccountName("kayle carupanera");
			Console.WriteLine(response);
		}
	}
}
