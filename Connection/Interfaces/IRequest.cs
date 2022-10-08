using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Connection.Interfaces
{
	internal interface IRequest
	{
		Task<HttpResponseMessage> MakeRequest(string url);
		Task<HttpResponseMessage> MakeRequestWithoutHeaders(string url);
		Task<JObject> GetContent(HttpResponseMessage response);
	}
}
