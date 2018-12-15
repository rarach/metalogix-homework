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
            return types.Select(type => new CompanyTypeItem {ID = type.ID, Text = type.Name})
                        .ToList();
        }

        internal IList<CompanyItem> GetCompanies(int id, string name, string countryCode, string type)
        {
            Company[] companies = new[]     //TODO: _service of course
            {
                new Company
                {
                    ID = 5552604,
                    Name = "Mikro Korp",
                    CountryCode = "ARG",
                    Type = new CompanyType {Name = "SAles"}
                }
            };
            return
                companies.Select(
                    c =>
                        new CompanyItem
                        {
                            ID = c.ID,
                            Name = c.Name,
                            CountryCode = c.CountryCode,
                            CompanyType = c.Type.Name
                        }).ToList();
        }

        internal void CreateCompany(Company company)
        {
            _service.CreateCompany(company);
        }
    }
}
