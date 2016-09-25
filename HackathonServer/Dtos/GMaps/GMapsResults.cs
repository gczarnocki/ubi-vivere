using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HackathonServer.Dtos.GMaps
{
    [DataContract]
    public class GMapsResults
    {
        [DataMember(Name = "results")]
        public List<GMapsInnerResult> Results { get; set; }
    }
}