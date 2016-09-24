using System.Runtime.Serialization;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class KeyValueDto
    {
        [DataMember(Name = "key")]
        public string Key { get; set; }
        [DataMember(Name = "value")]
        public string Value { get; set; }
    }
}