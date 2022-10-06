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

        public readonly LoL LeagueOfLegends;
        public readonly LoR LegendsOfRunaterra;
        public readonly TFT TeamfightTactics;
        public readonly Valorant Valorant;
        public readonly Status Status;
        public readonly DDragon Ddragon;
        public readonly Account Account;

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
			LeagueOfLegends = new LoL();
			LegendsOfRunaterra = new LoR();
			TeamfightTactics = new TFT();
			Valorant = new Valorant();
			Status = new Status();
			Ddragon = new DDragon();
			Account = new Account();
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
