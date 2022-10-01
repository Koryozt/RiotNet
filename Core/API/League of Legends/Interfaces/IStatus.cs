using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;

namespace RiotNet.Core.API.GamesAPI.Interfaces
{
    public interface IStatus
    {
		Task<JObject> Status();
	}
}