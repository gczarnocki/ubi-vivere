using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class PointDto
    {
        [DataMember(Name = "y")]
        public double Y { get; set; }
        [DataMember(Name = "x")]
        public double X { get; set; }
    }
}
