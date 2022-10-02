using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Valorant_API;
using RiotNet.Core.API.Valorant_API.Interfaces;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public Task<JObject> RecentMatches(Queue queue)
		{
			return _match.RecentMatches(queue);
		}
	}
}
