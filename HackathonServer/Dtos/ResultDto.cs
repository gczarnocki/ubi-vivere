using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class ResultDto
    {
        [DataMember(Name = "result")]
        public List<InnerResultDto> InnerResult { get; set; }
    }
}
