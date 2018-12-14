using System.Collections.Generic;
using System.ServiceModel;
using Service.Model;


namespace Service
{
    [ServiceContract]
    public interface ICompanyService
    {
        [OperationContract]
        IEnumerable<CompanyType> GetAllCompanyTypes();

        [OperationContract]
        Company GetDataUsingDataContract(Company composite);

        // TODO: Add your service operations here
    }


    //TODO: move

}
