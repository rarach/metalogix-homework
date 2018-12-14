using System.Runtime.Serialization;


namespace Service.Model
{
    /// <summary>
    /// Company type
    /// </summary>
    [DataContract]
    public class CompanyType
    {
        [DataMember]
        public int ID { get; set; }

        [DataMember]
        public string Name { get; set; }
    }
}
