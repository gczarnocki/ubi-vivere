using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class ValuesDto
    {
        [DataMember(Name = "values")]
        public List<KeyValueDto> KeyValueList { get; set; }
    }
}