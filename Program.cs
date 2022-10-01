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
            Startup create = new ("API KEY", Platforms.la1, Region.AMERICAS);
			LoL league = new LoL();

			JObject response = await league.GetSummonerByAccountName("kayle carupanera");
			Console.WriteLine(response);
		}
	}
}
