using System;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using HackathonServer.Dtos;
using HackathonServer.Dtos.GMaps;
using HackathonServer.Properties;
using HackathonServer.Shared;
using Newtonsoft.Json;

namespace HackathonServer.Models
{
    public static class DatabaseInitializer
    {
        public static void Seed(HackathonContext context)
        {
            // BusStopsSeed(context);
            EducationFacilitiesSeed(context);
        }

        public static void BusStopsSeed(HackathonContext context)
        {
            using (var sr = new StringReader(Resources.rozklad))
            {
                while (sr.Peek() >= 0)
                {
                    var line = sr.ReadLine();
                    if (!line.Contains("Y="))
                    {
                        continue;
                    }
                    try
                    {
                        var y = double.Parse(line.Substring(line.IndexOf("Y=") + 3, 9).Replace(".", ","));
                        var x = double.Parse(line.Substring(line.IndexOf("X=") + 3, 9).Replace(".", ","));

                        context.BusStops.AddOrUpdate(new BusStopDto() { Y = y, X = x });
                    }
                    catch (Exception)
                    {
                        continue;
                    }
                }

                context.SaveChanges(); // duplicate key exception while inserting!
            }
        }

        public static void EducationFacilitiesSeed(HackathonContext context)
        {
            var url = "https://api.um.warszawa.pl/api/action/datastore_search/?resource_id=1cae4865-bb17-4944-a222-0d0cdc377951";

            var response = Requestor.CreateRequest(url).Result;
            var jsonObj = JsonConvert.DeserializeObject<ResultDto>(response);

            int total = jsonObj.InnerResult.Total;

            for (int i = 0; i < total; i += 100)
            {
                var requestUrl = url + "&offset=" + i;
                response = Requestor.CreateRequest(requestUrl).Result;
                jsonObj = JsonConvert.DeserializeObject<ResultDto>(response);

                Trace.WriteLine($"{i}: {requestUrl}");

                foreach (var item in jsonObj.InnerResult.EducationFacilityDtos)
                {
                    context.EducationFacilities.AddOrUpdate(item);

                    GMapsLocationDto location = GoogleMaps.RetrieveDataFromGoogleMaps(item);
                    item.Longitude = location.Longitude;
                    item.Latitude = location.Latitude;
                }

                context.SaveChanges();
            }
        }
    }
}