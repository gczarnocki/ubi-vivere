using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class InnerResultDto
    {
        [DataMember(Name = "resource_id")]
        public string ResourceId { get; set; }
        [DataMember(Name = "fields")]
        public List<FieldDto> Fields { get; set; }
        [DataMember(Name = "records")]
        public List<EducationFacilityDto> Records { get; set; }
        [DataMember(Name = "_links")]
        public List<LinkDto> Links { get; set; }
        [DataMember(Name = "offset")]
        public int Offset { get; set; }
        [DataMember(Name = "total")]
        public int Total { get; set; }
    }
}