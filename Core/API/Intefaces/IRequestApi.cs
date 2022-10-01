﻿using Newtonsoft.Json.Linq;
using RiotNet.Core.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Intefaces
{
    public interface IRequestApi
    {
        Task<HttpResponseMessage> MakeRequest(string apiKey, string url);
        Task<JObject> GetResponseContent(HttpResponseMessage response);
        string CreateApiUrl(Platforms platform, string endpoint, string? version = null, string game = "lol");
    }
}