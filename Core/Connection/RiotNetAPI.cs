using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.Connection
{
	public class RiotNetAPI
	{
		public static string apikey = string.Empty;
		public static Platforms platform;
		public static Region region;

		public RiotNetAPI(string apiKey, Platforms platforms, Region nregion = Region.AMERICAS)
		{

			// Region is just for LoR, if you're not going to use it then it's not necessary to add it.

			apikey = apiKey;
			platform = platforms;
			region = nregion;
		}
	}
}
