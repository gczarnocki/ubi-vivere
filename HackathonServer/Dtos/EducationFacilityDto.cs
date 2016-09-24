using System.Runtime.Serialization;

namespace HackathonServer.Dtos
{
    [DataContract]
    public class EducationFacilityDto
    {
        [DataMember(Name = "_id")]
        public int Id { get; set; }
        [DataMember(Name = "Typ placówki")]
        public string Type { get; set; }
        [DataMember(Name = "Nazwa placówki")]
        public string Name { get; set; }
        [DataMember(Name = "Miejscowość")]
        public string City { get; set; }
        [DataMember(Name = "Ulica")]
        public string Street { get; set; }
        [DataMember(Name = "Nr domu")]
        public string StreetNumber { get; set; }
        [DataMember(Name = "Nr mieszkania")]
        public string HomeNumber { get; set; }
        [DataMember(Name = "Kod pocztowy")]
        public string Postcode { get; set; }
        [DataMember(Name = "Telefon")]
        public string Telephone { get; set; }
        [DataMember(Name = "Rodzaj placówki")]
        public string FacilityType { get; set; }
    }
}