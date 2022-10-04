using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.DataDragon.Interfaces
{
	public interface IDDragonRequest
	{
		Task<string> CreateURL(params string[] endpoint);
		Task<HttpResponseMessage> MakeRequest(string url);
		Task<JObject> GetContent(HttpResponseMessage response);
	}
}
