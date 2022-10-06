using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.DataDragon;
using RiotNet.Miscellaneous;

namespace RiotNet
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            RiotNetAPI API = new RiotNetAPI("API KEY");
           
            DDragon dataDragon = new DDragon();
            string champImgUrl = await dataDragon.GetChampionImage("Zed");

            await dataDragon.SaveImage(champImgUrl, "Zed");
        }
    }
}
