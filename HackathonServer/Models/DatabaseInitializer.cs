using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using HackathonServer.Dtos;
using HackathonServer.Properties;
using HackathonServer.Shared;
using Newtonsoft.Json;

namespace HackathonServer.Models
{
    public static class DatabaseInitializer
    {
        public static void Seed(HackathonContext context)
        {
            // BusStops
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
            }

            var response =
                Requestor.CreateRequest(
                "https://api.um.warszawa.pl/api/action/datastore_search/?resource_id=1cae4865-bb17-4944-a222-0d0cdc377951")
                .Result;

            var jsonObj = JsonConvert.DeserializeObject<ResultDto>(response);

            foreach (var item in jsonObj.InnerResult.EducationFacilityDtos)
            {
                context.EducationFacilities.AddOrUpdate(item);
            }

            context.SaveChanges();
        }
    }
}