using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Web;
using HackathonServer.Dtos;
using HackathonServer.Shared;
using Newtonsoft.Json;

namespace HackathonServer.Models
{
    public static class DatabaseInitializer
    {
        public static void BusStopsSeed(HackathonContext context)
        {
            var busStops = new List<BusStopDto> {new BusStopDto() {Y = 3.3, X = 2.2}};

            foreach (var item in busStops)
            {
                context.BusStops.AddOrUpdate(item);
            }

            context.SaveChanges();
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
                }

                context.SaveChanges();
            }
        }
    }
}