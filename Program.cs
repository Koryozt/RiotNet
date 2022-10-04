using Newtonsoft.Json.Linq;
using RiotNet.Miscellaneous;

namespace RiotNet
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            RiotNetAPI API = new ("YOUR API KEY", LeaguePlatforms.LA1, RunaterraPlatforms.AMERICAS, ValorantPlatforms.LATAM, RiotPlatforms.AMERICAS);

            JObject summoner = await API.LeagueOfLegends.GetSummonerByAccountName("Zette");
            Console.WriteLine(summoner);
        }
    }
}
