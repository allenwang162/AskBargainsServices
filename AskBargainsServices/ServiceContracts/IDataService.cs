using System.Collections.Generic;
using System.ServiceModel;
using AskBargains.DataEF.Models;

namespace AskBargainsServices.ServiceContracts
{
    [ServiceContract]
    public interface IDataService
    {

        [OperationContract]
        IList<DataItem> GetAllDataItems();

        [OperationContract]
        DataItem GetDataItemById(long dataItmeId);


    }
}