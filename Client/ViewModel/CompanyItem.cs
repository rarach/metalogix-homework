
namespace Client.ViewModel
{
    /// <summary>
    /// View-model for Company
    /// </summary>
    public class CompanyItem
    {
        public int ID { get; internal set; }
        public string Name { get; internal set; }
        public string CountryCode { get; internal set; }
        public string CompanyType { get; internal set; }
    }
}
