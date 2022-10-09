using Newtonsoft.Json.Linq;
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
            JObject champions = await API.Ddragon.GetAllChampions();
            string strchm = champions.ToString();
            await ContentHandler.SaveAsJson(strchm, "champions");

        }
    }
}
