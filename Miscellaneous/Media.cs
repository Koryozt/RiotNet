using RiotNet.Connection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace RiotNet.Miscellaneous
{
	public class Media
	{
		private static readonly DDragonRequest _request = new();
		
		public static async Task Image(string url, string fileName, string? path = null)
		{
			HttpResponseMessage response = await _request.MakeRequest(url);
			string filePath = string.Empty;

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

		public static async Task Json(string content, string fileName, string? path = null)
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
	}
}
