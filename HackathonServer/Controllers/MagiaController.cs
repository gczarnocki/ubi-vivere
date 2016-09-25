using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HackathonServer.Dtos;
using HackathonServer.Models;

namespace HackathonServer.Controllers
{
    public class MagiaController : ApiController
    {
        // GET api/Magia
        public PointDto[] Get()
        {
            using (var context = new HackathonContext())
            {
                return context.BusStops.Select(b => new PointDto() {X = b.X, Y = b.Y}).ToArray();
            }
        }
    }
}
