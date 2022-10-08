using Newtonsoft.Json.Linq;
using RiotNet.API.ValorantAPI;
using RiotNet.API.ValorantAPI.Interfaces;
using RiotNet.Enums;

namespace RiotNet.Core.API
{
    public class Valorant : IMatchVal, IContent
	{
		private readonly IMatchVal _match;
		private readonly IContent _content;

		public Valorant()
		{
			_match = new MatchVal();
			_content = new Content();
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

		public Task<JObject> GetRecentMatches(Queue queue)
		{
			return _match.GetRecentMatches(queue);
		}
	}
}
