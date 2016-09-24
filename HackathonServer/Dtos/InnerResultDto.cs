using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class InnerResultDto
    {
        [DataMember(Name = "resource_id")]
        public string ResourceId { get; set; }
        [DataMember(Name = "fields")]
        public List<TypeIdDto> Fields { get; set; }
        [DataMember(Name = "records")]
        public List<EducationFacilityDto> EducationFacilityDtos { get; set; }
        [DataMember(Name = "_links")]
        public LinkDto Links { get; set; }
        [DataMember(Name = "total")]
        public int Total { get; set; }
    }
}