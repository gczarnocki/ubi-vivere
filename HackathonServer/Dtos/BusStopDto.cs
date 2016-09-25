using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class BusStopDto
    {
        [DataMember(Name = "_id")]
        public int Id { get; set; }
        [DataMember(Name = "Y")]
        public double Y { get; set; }
        [DataMember(Name = "X")]
        public double X { get; set; }
    }
}
