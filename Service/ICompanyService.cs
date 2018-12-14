using System.ServiceModel;
using Service.Model;


namespace Service
{
    [ServiceContract]
    public interface ICompanyService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        Company GetDataUsingDataContract(Company composite);

        // TODO: Add your service operations here
    }


    //TODO: move

}
