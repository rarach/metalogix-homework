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

        /// <summary>
        /// Returns filtered list of companies
        /// </summary>
        /// <remarks>The name is a bit misleading as it can return collection of valid results</remarks>
        public IEnumerable<Company> GetCompany(int Id, string companyName, string countryCode, string companyType)
        {
            return _repository.GetCompanies(Id, companyName, countryCode, companyType);
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
