using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using HackathonServer.Dtos;
using HackathonServer.Shared;
using Newtonsoft.Json;

namespace HackathonServer.Models
{
    public static class DatabaseInitializer
    {
        public static void Seed(HackathonContext context)
        {
            var response =
                Requestor.CreateRequest(
                "https://api.um.warszawa.pl/api/action/datastore_search/?resource_id=1cae4865-bb17-4944-a222-0d0cdc377951")
                .Result;

            var jsonObj = JsonConvert.DeserializeObject<ResultDto>(response);

            foreach (var item in jsonObj.InnerResult.EducationFacilityDtos)
            {
                context.EducationFacilities.AddOrUpdate(item);
            }

            // BusStops

            var busStops = new List<BusStopDto> {new BusStopDto() {Y = 3.3, X = 2.2}};

            foreach (var item in busStops)
            {
                context.BusStops.AddOrUpdate(item);
            }

            context.SaveChanges();
        }
    }
}