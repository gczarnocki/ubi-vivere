using System.Runtime.Serialization;

namespace HackathonServer.Dtos.GMaps
{
    [DataContract]
    public class GMapsLocationDto
    {
        [DataMember(Name = "lat")]
        public double Latitude { get; set; }
        [DataMember(Name = "lng")]
        public double Longitude { get; set; }
    }
}