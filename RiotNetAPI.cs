using RiotNet.Core.API;
using RiotNet.API;
using RiotNet.Miscellaneous;
using RiotNet.API.Extra;
using RiotNet.DataDragon;

namespace RiotNet
{
    public class RiotNetAPI
    {
        public static string s_apikey = string.Empty;

        public readonly LoL LeagueOfLegends = new LoL();
        public readonly LoR LegendsOfRunaterra = new LoR();
        public readonly TFT TeamfightTactics = new TFT();
        public readonly Valorant Valorant = new Valorant();
        public readonly Status Status = new Status();
        public readonly DDragon Ddragon = new DDragon();
        public readonly Account Account = new Account();

        public static LeaguePlatforms LoLPlatform { get; set; }
        public static RunaterraPlatforms LoRPlatform { get; set; }
        public static ValorantPlatforms ValorantPlatform { get; set; }
        public static RiotPlatforms AccountPlatform { get; set; }
        public static Languages Langs { get; set; }

        public RiotNetAPI(string apiKey)
        {
            s_apikey = apiKey;
            LoLPlatform = LeaguePlatforms.NA1;
            LoRPlatform = RunaterraPlatforms.AMERICAS;
            ValorantPlatform = ValorantPlatforms.NA;
            AccountPlatform = RiotPlatforms.AMERICAS;
            Langs = Languages.en_US;
        }

        public void GetSettings()
        {
            Console.WriteLine(
                $"API KEY: {s_apikey}\n" +
                $"ACCOUNT PLATFORM: {AccountPlatform}\n" +
                $"LEAGUE OF LEGENDS | TFT PLATFORM: {LoLPlatform}\n" +
                $"LEGENDS OF RUNATERRA PLATFORM: {LoRPlatform}\n" +
                $"VALORANT PLATFORM: {ValorantPlatform}");
        }
    }
}
