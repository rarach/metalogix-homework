using System;
using System.Collections.Generic;
using Service.DataAccess;
using Service.Model;


namespace Service
{
    public class CompanyService : ICompanyService
    {
        private readonly CompanyRepository _repository = new CompanyRepository("Server=localhost\\SCBN_MARMIHA;Database=METALOGIX;Trusted_Connection=True;"/*TODO: from web.config!!!*/);


        public IEnumerable<Company> GetAllCompanies()
        {
            throw new NotImplementedException();
        }

        public Company GetCompany(int Id, string companyName, string countryCode, string companyType)
        {
            throw new NotImplementedException();
        }

        public bool CreateCompany(Company company)
        {
            return _repository.CreateCompany(company);
        }

        public IEnumerable<CompanyType> GetAllCompanyTypes()
        {
            return _repository.GetCompanyTypes();
        }
    }
}
