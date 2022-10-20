using Newtonsoft.Json.Linq;
using RiotNet.API.Connection;
using RiotNet.Connection;
using RiotNet.Connection.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace RiotNet.Miscellaneous
{
	public static class ContentHandler
	{
		private static readonly IRequest _request = new Request();
		
		public static async Task SaveAsImage(string url, string fileName, string? path = null)
		{
			HttpResponseMessage response = await _request.MakeRequest(url);
			string filePath;

			if (path is null)
			{
				filePath = Path.Combine(RiotNetAPI.HomeDirectory, fileName);
			}
			else
			{
				filePath = Path.Combine(path!, $"{fileName}");
			}

			using (FileStream fs = new FileStream(filePath, FileMode.Create))
			{
				await response.Content.CopyToAsync(fs);
				Console.WriteLine("File created at: " + filePath);
			}
		}

		public static async Task SaveAsJson(string content, string fileName, string? path = null)
		{
			string filePath; 

			if (path is null)
				filePath = Path.Combine(Directory.GetCurrentDirectory(), $"{fileName}.json");
			else
				filePath = Path.Combine(path!, $"{fileName}.json");
			
			if (File.Exists(filePath))
			{
				throw new Exception("File already exists");
			}

			using (StreamWriter writer = new StreamWriter(filePath, true))
			{
				await writer.WriteLineAsync(content);
				writer.Close();
				Console.WriteLine("File created at: " + filePath);
			}
		}

		public static async Task SaveAsTxt(string content, string fileName, string? path = null)
		{
			string filePath;

			if (path is null)
				filePath = Path.Combine(Directory.GetCurrentDirectory(), $"{fileName}.txt");
			else
				filePath = Path.Combine(path!, $"{fileName}.txt");

			if (File.Exists(filePath))
			{
				throw new Exception("File already exists");
			}

			using (StreamWriter writer = new StreamWriter(filePath, true))
			{
				await writer.WriteLineAsync(content);
				writer.Close();
				Console.WriteLine("File created at: " + filePath);
			}
		}

		public static IDictionary<string, object> ToDictionary(this JObject json)
		{
			var propertyValuePairs = json.ToObject<Dictionary<string, object>>();
			ProcessJObjectProperties(propertyValuePairs!);
			ProcessJArrayProperties(propertyValuePairs!);
			return propertyValuePairs!;
		}

		private static void ProcessJObjectProperties(IDictionary<string, object> propertyValuePairs)
		{
			var objectPropertyNames = (from property in propertyValuePairs
									   let propertyName = property.Key
									   let value = property.Value
									   where value is JObject
									   select propertyName).ToList();

			objectPropertyNames.ForEach(propertyName => propertyValuePairs[propertyName] = ToDictionary((JObject)propertyValuePairs[propertyName]));
		}

		private static void ProcessJArrayProperties(IDictionary<string, object> propertyValuePairs)
		{
			var arrayPropertyNames = (from property in propertyValuePairs
									  let propertyName = property.Key
									  let value = property.Value
									  where value is JArray
									  select propertyName).ToList();

			arrayPropertyNames.ForEach(propertyName => propertyValuePairs[propertyName] = ToArray((JArray)propertyValuePairs[propertyName]));
		}

		public static object[] ToArray(this JArray array)
		{
			return array.ToObject<object[]>()!.Select(ProcessArrayEntry).ToArray();
		}

		private static object ProcessArrayEntry(object value)
		{
			if (value is JObject)
				return ToDictionary((JObject)value);
			
			if (value is JArray)
				return ToArray((JArray)value);
			
			return value;
		}
	}
}
