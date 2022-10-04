using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.DataDragon.Interfaces
{
	public interface IItem
	{
		Task<JObject> GetAllItems();
		Task<JObject> GetItemByID(int id);
		Task<JObject> GetItemImage(int id);
	}
}
