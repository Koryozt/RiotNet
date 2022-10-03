using Newtonsoft.Json.Linq;

namespace RiotNet.API.ValorantAPI.Interfaces
{
	public interface IContent
	{
		Task<JObject> GetContent();
	}
}
