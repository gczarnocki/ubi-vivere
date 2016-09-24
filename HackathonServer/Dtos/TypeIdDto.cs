using System.Runtime.Serialization;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class TypeIdDto
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }
        [DataMember(Name = "id")]
        public string Id { get; set; }
    }
}