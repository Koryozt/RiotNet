using Newtonsoft.Json.Linq;

namespace RiotNet.API.Interfaces
{
    public interface IStatus
    {
        Task<JObject> LoLStatus();
        Task<JObject> LoRStatus();
        Task<JObject> TFTStatus();
        Task<JObject> ValorantStatus();
    }
}