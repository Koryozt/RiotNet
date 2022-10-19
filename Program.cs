using Newtonsoft.Json.Linq;
using RiotNet.DataDragon;
using RiotNet.Enums;
using RiotNet.GameClient.Methods;
using RiotNet.Miscellaneous;

namespace RiotNet
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            string certpath = Path.Combine(RiotNetAPI.HomeDirectory, "Downloads", "riotgames.pem");
			RiotNetAPI API = new RiotNetAPI("YOUR API KEY", certpath);
        }
    }
}
