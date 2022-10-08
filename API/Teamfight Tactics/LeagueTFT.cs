using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.API.TeamfightTactics.Interfaces;
using RiotNet.Connection.Interfaces;
using RiotNet.Enums;
using RiotNet.Miscellaneous;

namespace RiotNet.API.TeamfightTactics
{
    public class LeagueTFT : ILeagueTFT
    {
        private readonly IRequest _request = new Request();

        public async Task<JObject> GetEntries(string summonerId)
        {
            string url = URL.RiotGamesRequestUrl("league", "v1", "tft", "entries", "by-summoner");
            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }

        public async Task<JObject> GetEntries(Tier tier, Division division)
        {
            string strTier = Convert.ToString(tier)!;
            string strDivision = Convert.ToString(division)!;
            string url = URL.RiotGamesRequestUrl("league", "v1", "tft", "entries", strTier, strDivision);

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }

        public async Task<JObject> GetLeague(AdvancedQueues queue)
        {
            string strQueue = Convert.ToString(queue)!;
            string url = URL.RiotGamesRequestUrl("league", "v1", "tft", strQueue);

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }

        public async Task<JObject> GetLeague(string leagueId)
        {
            string url = URL.RiotGamesRequestUrl("league", "v1", "tft", "leagues", leagueId);

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }

        public async Task<JObject> GetTop(Queue queue)
        {
            string strQueue = Convert.ToString(queue)!;
            string url = URL.RiotGamesRequestUrl("league", "v1", "tft", "rate-ladders", strQueue, "top");

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetContent(response);
        }
    }
}
