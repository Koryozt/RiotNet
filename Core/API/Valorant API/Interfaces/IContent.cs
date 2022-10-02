using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Valorant_API.Interfaces
{
	public interface IContent
	{
		Task<JObject> GetContent();
	}
}
