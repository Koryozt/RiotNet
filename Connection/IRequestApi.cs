using Newtonsoft.Json.Linq;

namespace RiotNet.API.Connection
{
    public interface IRequestApi
    {
        Task<HttpResponseMessage> MakeRequest(string url);
        Task<JObject> GetResponseContent(HttpResponseMessage response);
        string CreateApiUrl(string coreEndpoint, string version, string initial, params string[] endpointDetails);
    }
}
