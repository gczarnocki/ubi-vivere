using System.Runtime.Serialization;

namespace HackathonServer.Dtos.GMaps
{
    [DataContract]
    public class GMapsInnerResult
    {
        [DataMember(Name = "geometry")]
        public GMapsGeometryDto Geometry { get; set; }
    }
}