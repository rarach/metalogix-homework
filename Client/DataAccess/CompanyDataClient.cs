using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

using Client.CompanyServiceReference;
using Client.ViewModel;


namespace Client.DataAccess
{
    internal class CompanyDataClient
    {
        private readonly CompanyServiceClient _service;


        internal CompanyDataClient(string serviceUrl)
        {
            _service = new CompanyServiceClient("BasicHttpBinding_ICompanyService", new EndpointAddress(serviceUrl));
        }

        internal IList<CompanyTypeItem> GetCompanyTypes()
        {
            CompanyType[] types = _service.GetAllCompanyTypes();
            return types.Select(type => new CompanyTypeItem {ID = type.ID, Text = type.Name}).ToList();
        } 
    }
}
