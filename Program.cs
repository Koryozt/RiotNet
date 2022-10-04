using Newtonsoft.Json.Linq;
using RiotNet.DataDragon;
using RiotNet.Miscellaneous;

namespace RiotNet
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            RiotNetAPI API = new ("RGAPI-e43cbc7b-4a09-4764-8730-e1c7b41f618c");
            RiotNetAPI.LoLPlatform = LeaguePlatforms.LA1;

            DDragonRequest request = new();

            string v = await request.GetLatestVersion();
            Console.WriteLine(v);
        }
    }
}
