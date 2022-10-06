using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Exceptions
{
	public class HttpMethodException : Exception
	{
		public HttpMethodException() { }

		public HttpMethodException(int statusCode) : base($"The request has returned a [{statusCode}: {StatusCodeMessage(statusCode)}")
		{

		}

		private static string StatusCodeMessage(int statusCode)
		{
			switch(statusCode)
			{
				case 400: return "Bad request].";
				case 401: return "Unauthorized]. You don't have the enough access to see this information.";
				case 403: return "Forbidden]. Maybe your API Key has expired.";
				case 404: return "Data not found].";
				case 405: return "HTTP Method not allowed].";
				case 415: return "Unsupported media type].";
				case 429: return "Rate limit exceeded].";
				case 500: return "Internal server error].";
				case 502: return "Bad gateway].";
				case 503: return "Service unavailable].";
				case 504: return "Gateway timeout].";
				default: return "Bad request].";
			}
		}
	}
}
