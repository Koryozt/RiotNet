using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Miscellaneous
{
	public class URL
	{
		#region url
		private readonly static string s_ddragonUrlBase = "http://ddragon.leagueoflegends.com/cdn/";
		private readonly static string s_riotGamesApiUrlBase = "https://.api.riotgames.com/";
		private readonly static string s_gameClientUrlBase = "​https://127.0.0.1:2999/";
		private readonly static string s_versions = "https://ddragon.leagueoflegends.com/api/versions.json";
		private readonly static string s_gameConstsUrlBase = "https://static.developer.riotgames.com/docs/";
		#endregion

		public static async Task<string> DataDragonRequestURL(params string[] endpoints)
		{
			string version = await GetLatestVersion();

			StringBuilder sb = new StringBuilder(s_ddragonUrlBase);
			sb.Append(version).Append('/');
			sb.AppendJoin('/', endpoints);

			return sb.ToString();
		}

		public static string RiotGamesRequestUrl(string coreEndpoint, string version, string initial, params string[] endpoints)
		{
			try
			{
				string executeAgainst;
				StringBuilder sb = new StringBuilder(s_riotGamesApiUrlBase);

				switch (initial)
				{
					case "lol":
					case "tft":
						executeAgainst = Convert.ToString(RiotNetAPI.LoLPlatform)!.ToLower();
						sb.Insert(8, executeAgainst);
						break;
					case "lor":
						executeAgainst = Convert.ToString(RiotNetAPI.LoRPlatform)!.ToLower();
						sb.Insert(8, executeAgainst);
						break;
					case "val":
						executeAgainst = Convert.ToString(RiotNetAPI.ValorantPlatform)!.ToLower();
						sb.Insert(8, executeAgainst);
						break;
					case "riot":
						executeAgainst = Convert.ToString(RiotNetAPI.AccountPlatform)!.ToLower();
						sb.Insert(8, executeAgainst);
						break;
				}

				sb.AppendJoin('/', initial, coreEndpoint, version).Append('/');

				if (endpoints is not null)
					sb.AppendJoin('/', endpoints).Append('/');

				return sb.ToString();
			}
			catch (ArgumentNullException)
			{
				throw;
			}
		}

		public static string GameClientRequestUrl(bool requiresSummoner = false, params string[] endpoints)
		{
			StringBuilder sb = new StringBuilder(s_gameClientUrlBase);
			sb.AppendJoin('/', endpoints);
			
			if (requiresSummoner)
			{
				sb.Append("?summonerName=");
			}

			return sb.ToString().Remove(0, 1);
		}

		public static string GameConstRequestUrl(params string[] endpoints)
		{
			StringBuilder sb = new StringBuilder(s_gameConstsUrlBase);
			sb.AppendJoin('/', endpoints);

			return sb.ToString();
		}

		private static async Task<string> GetLatestVersion()
		{
			using (HttpClient client = new HttpClient())
			{
				HttpResponseMessage response = await client.GetAsync(s_versions);
				response.EnsureSuccessStatusCode();

				string str = await response.Content.ReadAsStringAsync();
				string obj =  JsonConvert.DeserializeObject<string[]>(str)!.First();
				
				return obj;
			}
		}
	}
}
