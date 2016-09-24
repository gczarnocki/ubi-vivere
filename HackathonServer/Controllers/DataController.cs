using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HackathonServer.Shared;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace HackathonServer.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {
        // GET: api/data
        [HttpGet]
        public string Get()
        {
            var response = Requestor.CreateRequest(
                    "https://api.um.warszawa.pl/api/action/dbtimetable_get/?id=e923fa0e-d96c-43f9-ae6e-60518c9f3238&busstopId=7009&busstopNr=01&line=138&apikey=48612c5b-45f9-415c-a7b2-33b6ee6015e9").Result;

            return response;
        }
    }
}