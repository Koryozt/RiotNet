using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Exceptions
{
	public class GameNotStartedException : Exception
	{
		
		public GameNotStartedException() : base($"No League of Legends game was detected or running, ensure you're currently playing to activate the port https://127.0.0.1:2999 and be able to execute requests.")
		{

		}
	}
}
