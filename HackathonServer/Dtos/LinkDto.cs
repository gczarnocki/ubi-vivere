using System.Runtime.Serialization;

namespace HackathonServer.Dtos
{
    public class LinkDto
    {
        [DataMember(Name = "start")]
        public string Start { get; set; }
        [DataMember(Name = "prev")]
        public string Prev { get; set; }
        [DataMember(Name = "next")]
        public string Next { get; set; }
    }
}