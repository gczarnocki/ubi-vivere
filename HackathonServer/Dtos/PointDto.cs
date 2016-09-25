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

        public override bool Equals(object obj)
        {
            var item = obj as PointDto;

            if (item == null)
            {
                return false;
            }

            return this.Y.Equals(item.Y)&& this.X.Equals(item.X);
        }

        public override int GetHashCode()
        {
            return (this.X+1000000*Y).GetHashCode();
        }
    }
}
