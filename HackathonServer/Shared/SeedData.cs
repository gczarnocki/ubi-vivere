﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackathonServer.Dtos;
using Newtonsoft.Json;

namespace HackathonServer.Shared
{
    public static class SeedData
    {
        public static void Initialization()
        {
            var response =
                Requestor.CreateRequest(
                    "https://api.um.warszawa.pl/api/action/datastore_search/?resource_id=1cae4865-bb17-4944-a222-0d0cdc377951")
                    .Result;

            var jsonObj = JsonConvert.DeserializeObject<ResultDto>(response);
        }
    }
}
