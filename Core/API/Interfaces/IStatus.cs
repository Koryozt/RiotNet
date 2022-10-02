using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;

namespace RiotNet.Core.API.Interfaces
{
    public interface IStatus
    {
        Task<JObject> LoLStatus();
        Task<JObject> LoRStatus();
        Task<JObject> TFTStatus();
        Task<JObject> ValorantStatus();
    }
}