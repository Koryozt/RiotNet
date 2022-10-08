using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.DataDragon;
using RiotNet.Enums;
using RiotNet.Miscellaneous;

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
            await Media.Json(data.ToString(), "Aatrox", Environment.CurrentDirectory);
        }
    }
}
