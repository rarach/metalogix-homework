using System;
using System.Collections.Generic;
using Service.DataAccess;
using Service.Model;


namespace Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class CompanyService : ICompanyService
    {
        private readonly CompanyRepository _repository = new CompanyRepository();


        public IEnumerable<CompanyType> GetAllCompanyTypes()
        {
            return _repository.GetCompanyTypes();
        }

        public Company GetDataUsingDataContract(Company composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            return composite;
        }
    }
}
