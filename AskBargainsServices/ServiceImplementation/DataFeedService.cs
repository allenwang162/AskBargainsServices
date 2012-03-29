using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AskBargainsServices.ServiceContracts;

namespace AskBargainsServices.ServiceImplementation
{
    public class DataFeedService : IDataFeedService
    {
        public IList<string> GetAllFileList()
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByFileNameList(IList<string> fileNameList)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByFileName(string fileName)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByDefault()
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByDateString(string date)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByNumberOfItems(int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetAllDataInfoOrderByDesc()
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByItemIDList(List<string> itemIDList)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByCompanyID(string companyID)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByCompanyName(string companyName)
        {
            throw new NotImplementedException();
        }

        public DataContracts.DataInfo GetDataInfoByItemID(string itemID)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByBrand(string brandName)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.DataInfo> GetDataInfoListByCatagory(string catagoryName)
        {
            throw new NotImplementedException();
        }

        public IList<DataContracts.CompanyInfo> GetAllCompanyInfoList()
        {
            throw new NotImplementedException();
        }

        public DataContracts.CompanyInfo GetCompanyInfoByCompanyID(string companyID)
        {
            throw new NotImplementedException();
        }

        public DataContracts.CompanyInfo GetCompanyInfoByItemID(string itemID)
        {
            throw new NotImplementedException();
        }
    }
}