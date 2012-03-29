using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using AskBargainsServices.DataContracts;

namespace AskBargainsServices.ServiceContracts
{
    // Service Contract for Loading DataFeed
    [ServiceContract]
    public interface IDataFeedService
    {
        
        [OperationContract]
        IList<string> GetAllFileList();

        [OperationContract]
        IList<DataInfo> GetDataInfoListByFileNameList(IList<string> fileNameList);

        [OperationContract]
        IList<DataInfo> GetDataInfoListByFileName(string fileName);

        [OperationContract]
        IList<DataInfo> GetDataInfoListByDefault();

        [OperationContract]
        IList<DataInfo> GetDataInfoListByDateString(string date);

        [OperationContract]
        IList<DataInfo> GetDataInfoListByDate(DateTime date);

        [OperationContract]
        IList<DataInfo> GetDataInfoListByNumberOfItems(int numberOfItems);

        [OperationContract]
        IList<DataInfo> GetAllDataInfoOrderByDesc();
        
        [OperationContract]
        IList<DataInfo> GetDataInfoListByItemIDList(List<string> itemIDList);

        [OperationContract]
        IList<DataInfo> GetDataInfoListByCompanyID(string companyID);

        [OperationContract]
        IList<DataInfo> GetDataInfoListByCompanyName(string companyName);

        [OperationContract]
        DataInfo GetDataInfoByItemID(string itemID);

        [OperationContract]
        IList<DataInfo> GetDataInfoListByBrand(string brandName);

        [OperationContract]
        IList<DataInfo> GetDataInfoListByCatagory(string catagoryName);

        [OperationContract]
        IList<CompanyInfo> GetAllCompanyInfoList();
        
        [OperationContract]
        CompanyInfo GetCompanyInfoByCompanyID(string companyID);

        [OperationContract]
        CompanyInfo GetCompanyInfoByItemID(string itemID);

    }


    
}
