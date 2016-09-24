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
        [Column(Order = 0), DataMember(Name = "Y"), Key]
        public double Y { get; set; }
        [Column(Order = 1), DataMember(Name = "X"), Key]
        public double X { get; set; }
    }
}
