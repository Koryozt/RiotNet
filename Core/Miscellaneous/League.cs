using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.Miscellaneous
{
	public enum Levels
	{
		NONE,
		IRON,
		BRONZE,
		SILVER,
		GOLD,
		PLATINUM,
		DIAMON,
		MASTER,
		GRANDMASTER,
		CHALLENGER,
		HIGHEST_NOT_LEADERBOARD_ONLY,
		HIGHEST,
		LOWEST
	}

	public enum AdvancedQueues
	{
		masterleagues,
		grandmasterleagues,
		challengerleagues
	}

	public enum Queue
	{
		RANKED_SOLO_5x5,
		RANKED_FLEX_TT,
		RANKED_FLEX_SR,
	}

	public enum Tier
	{
		IRON,
		BRONZE,
		SILVER,
		GOLD,
		PLATINUM,
		DIAMON
	}

	public enum Division
	{
		I,
		II,
		III,
		IV,
		V
	}
}
