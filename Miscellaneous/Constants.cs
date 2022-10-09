using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.Connection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Miscellaneous
{
	public class Constants
	{
		private readonly IRequest _request = new Request();

		public async Task<JObject> GetGameConstant(string constant)
		{
			if (!constant.Contains(".json"))
				constant += ".json";

			string url = URL.GameConstRequestUrl("lol", constant);
			HttpResponseMessage response = await _request.MakeRequest(url);

			return await _request.GetContent(response);
		}
	}
}
