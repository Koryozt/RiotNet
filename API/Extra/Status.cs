﻿using Newtonsoft.Json.Linq;
using RiotNet.Core.API.Intefaces;
using RiotNet.Core.API.Interfaces;
using RiotNet.Core.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotNet.Core.API.Extra
{
    public class Status : IStatus
    {
        private readonly IRequestApi _request = new Request();

        public async Task<JObject> LoLStatus()
        {
            string url = _request.CreateApiUrl("status", "v4", endpointDetails: "platform-data");

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }

        public async Task<JObject> LoRStatus()
        {
            string url = _request.CreateApiUrl("status", "v1", "lor", "platform-data");

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }

        public async Task<JObject> TFTStatus()
        {
            string url = _request.CreateApiUrl("status", "v1", "tft", "platform-data");

            HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }
        public async Task<JObject> ValorantStatus()
        {
            string url = _request.CreateApiUrl("status", "v1", "val", "platform-data");

			HttpResponseMessage response = await _request.MakeRequest(url);

            return await _request.GetResponseContent(response);
        }
    }
}