using RiotNet.Core.API;
using RiotNet.API;
using RiotNet.API.Extra;
using RiotNet.DataDragon;
using RiotNet.Enums;
using RiotNet.Miscellaneous;
using RiotNet.GameClient.Methods;

namespace RiotNet
{
    public class RiotNetAPI
    {
        public static string Apikey { get; set; } = string.Empty;
		public static string HomeDirectory { get; set; } = string.Empty;
		public static string RootDirectory { get; set; } = string.Empty;
		public static string CertificateFilePath { get; set; } = string.Empty;
		public static long LeguendsOfRunaterraPort { get; set; } = 21337;

		public readonly LoL LeagueOfLegends;
        public readonly LoR LegendsOfRunaterra;
        public readonly TFT TeamfightTactics;
        public readonly Valorant Valorant;
        public readonly Status Status;
        public readonly DDragon DataDragon;
        public readonly Account Account;
        public readonly Constants GameConstants;
        public readonly LiveClientData LiveClient;
       
        public static LeaguePlatforms LoLPlatform { get; set; }
        public static RunaterraPlatforms LoRPlatform { get; set; }
        public static ValorantPlatforms ValorantPlatform { get; set; }
        public static RiotPlatforms AccountPlatform { get; set; }
        public static Languages Lang { get; set; }

        public RiotNetAPI(string apiKey, string? certificateFilePath = null)
        {
            Apikey = apiKey;
            CertificateFilePath = certificateFilePath!;
            HomeDirectory = GetHomeDirectory();
            RootDirectory = GetRoot();
            LoLPlatform = LeaguePlatforms.NA1;
            LoRPlatform = RunaterraPlatforms.AMERICAS;
            ValorantPlatform = ValorantPlatforms.NA;
            AccountPlatform = RiotPlatforms.AMERICAS;
            Lang = Languages.en_US;
			LeagueOfLegends = new LoL();
			LegendsOfRunaterra = new LoR();
			TeamfightTactics = new TFT();
			Valorant = new Valorant();
			Status = new Status();
			DataDragon = new DDragon();
			Account = new Account();
            GameConstants = new Constants();
            LiveClient = new LiveClientData();
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

			return path + Path.DirectorySeparatorChar;
		}

		private static string GetRoot()
		{
			string path = string.Empty;
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				path = Environment.GetEnvironmentVariable("HOMEDRIVE")!;
			}
			if (Environment.OSVersion.Platform == PlatformID.Unix)
			{
				path = Environment.GetEnvironmentVariable("$HOME")!;
			}

			return path + Path.DirectorySeparatorChar;
		}
	}
}
