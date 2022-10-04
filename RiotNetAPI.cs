using RiotNet.Core.API;
using RiotNet.API;
using RiotNet.Miscellaneous;
using RiotNet.API.Extra;

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
        public readonly Account Account = new Account();

        public static LeaguePlatforms LoLPlatform { get; set; }
        public static RunaterraPlatforms LoRPlatform { get; set; }
        public static ValorantPlatforms ValorantPlatform { get; set; }
        public static RiotPlatforms AccountPlatform { get; set; }

        public RiotNetAPI(string apiKey, LeaguePlatforms lolPlatform, RunaterraPlatforms lorPlatform, ValorantPlatforms valorantPlatform,
        RiotPlatforms accountPlatform)
        {
            s_apikey = apiKey;
            LoLPlatform = lolPlatform;
            LoRPlatform = lorPlatform;
            ValorantPlatform = valorantPlatform;
            AccountPlatform = accountPlatform;
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
