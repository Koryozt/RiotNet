using Newtonsoft.Json.Linq;
using RiotNet.DataDragon;
using RiotNet.Enums;

namespace RiotNet
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            RiotNetAPI API = new RiotNetAPI("YOUR API KEY");
            RiotNetAPI.LoLPlatform = LeaguePlatforms.LA1;
            Champion champ = new Champion();
            JObject data = await champ.GetChampionByName("Aatrox");

        }
    }
}
