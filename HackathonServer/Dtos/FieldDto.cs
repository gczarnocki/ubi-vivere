using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class FieldDto
    {
        [DataMember(Name = "fields")]
        public List<KeyValueDto> KeyPairList { get; set; }
    }
}