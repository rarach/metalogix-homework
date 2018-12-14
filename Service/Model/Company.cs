using System.Runtime.Serialization;


namespace Service.Model
{
    /// <summary>
    /// Data object for a company
    /// </summary>
    /// <remarks>
    /// For sake of simplicity of this app, one DTO is used for both data layer and service interface
    /// </remarks>
    [DataContract]
    public class Company
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CountryCode { get; set; }

        [DataMember]
        public CompanyType Type { get; set; }
    }
}
