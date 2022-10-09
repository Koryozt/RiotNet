using RiotNet.Core.API;
using RiotNet.API;
using RiotNet.API.Extra;
using RiotNet.DataDragon;
using RiotNet.Enums;
using RiotNet.Miscellaneous;

namespace RiotNet
{
    public class RiotNetAPI
    {
        public static string Apikey { get; set; } = string.Empty;
        private static string _homeDirectory = string.Empty;

        public readonly LoL LeagueOfLegends;
        public readonly LoR LegendsOfRunaterra;
        public readonly TFT TeamfightTactics;
        public readonly Valorant Valorant;
        public readonly Status Status;
        public readonly DDragon Ddragon;
        public readonly Account Account;
        public readonly Constants consts;

        public static LeaguePlatforms LoLPlatform { get; set; }
        public static RunaterraPlatforms LoRPlatform { get; set; }
        public static ValorantPlatforms ValorantPlatform { get; set; }
        public static RiotPlatforms AccountPlatform { get; set; }
        public static Languages Langs { get; set; }

		public static string HomeDirectory
		{
			get { return _homeDirectory; }
			set { _homeDirectory = value; }
		}

		public RiotNetAPI(string apiKey)
        {
            Apikey = apiKey;
            HomeDirectory = GetHomeDirectory();
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
            consts = new Constants();
		}

        public void GetSettings()
        {
            Console.WriteLine(
                $"API KEY: {Apikey}\n" +
                $"ACCOUNT PLATFORM: {AccountPlatform}\n" +
                $"LEAGUE OF LEGENDS | TFT PLATFORM: {LoLPlatform}\n" +
                $"LEGENDS OF RUNATERRA PLATFORM: {LoRPlatform}\n" +
                $"VALORANT PLATFORM: {ValorantPlatform}");
        }

		private static string GetHomeDirectory()
		{
			string path = string.Empty;
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				string homeDrive = Environment.GetEnvironmentVariable("HOMEDRIVE")!;
                
                if (!string.IsNullOrEmpty(homeDrive))
                {
                    string homePath = Environment.GetEnvironmentVariable("HOMEPATH")!;
                    path = homeDrive + homePath;
                }
			}
			if (Environment.OSVersion.Platform == PlatformID.Unix)
			{
				path = Environment.GetEnvironmentVariable("$HOME")!;
			}

			return path;
		}
	}
}
