using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.DataDragon;
using RiotNet.Miscellaneous;

namespace RiotNet
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            RiotNetAPI API = new("API KEY");
            RiotNetAPI.LoLPlatform = LeaguePlatforms.LA1;

            Request req = new();
            await req.MakeRequest("https://la1.api.riotgames.com/lol/platform/v3/champion-rotations");
        }
    }
}
