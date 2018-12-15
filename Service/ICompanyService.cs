using System.Collections.Generic;
using System.ServiceModel;
using Service.Model;


namespace Service
{
    [ServiceContract]
    public interface ICompanyService
    {
        [OperationContract]
        IEnumerable<Company> GetAllCompanies();

        [OperationContract]
        Company GetCompany(int Id, string companyName, string countryCode, string companyType);

        [OperationContract]
        bool CreateCompany(Company company);

        [OperationContract]
        IEnumerable<CompanyType> GetAllCompanyTypes();
    }
}
