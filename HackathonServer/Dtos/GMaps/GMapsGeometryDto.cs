using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using HackathonServer.Dtos.GMaps;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class GMapsGeometryDto
    {
        [DataMember(Name = "location")]
        public GMapsLocationDto Location { get; set; }
    }
}