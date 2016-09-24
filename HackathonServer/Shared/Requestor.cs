using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace HackathonServer.Shared
{
    public static class Requestor
    {
        private const string DefaultDataServerAddress = "https://api.um.warszawa.pl/";

        public static async Task<string> CreateRequest(string requestAddress)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestAddress + ApiKeys.ApiKeyParam);

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(requestAddress);
                var responseString = await response.Content.ReadAsStringAsync();

                return responseString;
            }
        }
    }
}
