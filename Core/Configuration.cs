using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core
{
	public static class Configuration
	{
		public static string s_baseUrl = "https://.api.riotgames.com/";
		public static HttpClient client = new HttpClient();


	}
}
