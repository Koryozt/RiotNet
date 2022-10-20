using Newtonsoft.Json.Linq;
using RiotNet.API.Valorant_API;
using RiotNet.API.Valorant_API.Interfaces;
using RiotNet.API.ValorantAPI;
using RiotNet.API.ValorantAPI.Interfaces;
using RiotNet.Enums;

namespace RiotNet.Core.API
{
    public class Valorant : IMatchVal, IContent, IValRanked
	{
		private readonly IMatchVal _match;
		private readonly IContent _content;
		private readonly IValRanked _ranked;

		public Valorant()
		{
			_match = new MatchVal();
			_content = new Content();
			_ranked = new ValRanked();
		}

		public Task<JObject> GetContent()
		{
			return _content.GetContent();
		}

		public Task<JObject> GetMatch(string matchId)
		{
			return _match.GetMatch(matchId);
		}

		public Task<JObject> GetMatchList(string puuid)
		{
			return _match.GetMatchList(puuid);
		}

		public Task<JObject> GetQueueLeaderboard(string actId, int? size = 200, int? startIndex = 0)
		{
			return _ranked.GetQueueLeaderboard(actId, size, startIndex);
		}

		public Task<JObject> GetRecentMatches(Queue queue)
		{
			return _match.GetRecentMatches(queue);
		}
	}
}
