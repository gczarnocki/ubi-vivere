using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using HackathonServer.Dtos;
using HackathonServer.Dtos.GMaps;
using HackathonServer.Models;
using Newtonsoft.Json;

namespace HackathonServer.Shared
{
    public class GoogleMaps
    {
        public static GMapsLocationDto RetrieveDataFromGoogleMaps(EducationFacility facility)
        {
            var url = $"{ApiKeys.googleMapsUrl}{facility.Street.Replace(' ', '+')}+{facility.StreetNumber.Replace(' ', '+')},+{facility.City.Replace(' ', '+')}{ApiKeys.GoogleMapsApiKeyParam}";
            var response = Requestor.CreateRequest(url).Result;
            var jsonObj = JsonConvert.DeserializeObject<GMapsResults>(response);

            return jsonObj.Results.Count > 0 ? jsonObj.Results[0].Geometry.Location : null;
        }
    }
}