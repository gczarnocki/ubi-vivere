using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Management;

namespace HackathonServer.Shared
{
    public static class Requestor
    {
        private const string DefaultDataServerAddress = "https://api.um.warszawa.pl/";

        public static async Task<string> CreateRequest(string requestAddress)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestAddress + ApiKeys.ApiKeyParam);
            request.Proxy = null;
            request.AutomaticDecompression = DecompressionMethods.GZip;

            var result = string.Empty;

            using (var stream = request.GetResponse().GetResponseStream())
            {
                if (stream != null)
                {
                    using (var reader = new StreamReader(stream))
                    {
                        result = reader.ReadToEnd();
                    }
                }
            }

            return result;
        }
    }
}