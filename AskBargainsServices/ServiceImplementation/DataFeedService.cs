using System;
using System.Collections.Generic;
using AskBargainsServices.DataContracts;
using AskBargainsServices.DataFeeds;
using AskBargainsServices.ServiceContracts;

namespace AskBargainsServices.ServiceImplementation
{
    public class DataFeedService :IDataFeedService
    {
        public IList<string> GetAllFileList()
        {

            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByFileNameList(IList<string> fileNameList)
        {
            return DataFeedManager.LoadAllDataFeeds();
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByFileName(string fileName)
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByDefault()
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByDateString(string date)
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByNumberOfItems(int numberOfItems)
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetAllDataInfoOrderByDesc()
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByItemIDList(List<string> itemIDList)
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByCompanyID(string companyID)
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByCompanyName(string companyName)
        {
            throw new NotImplementedException();
        }

        public DataInfo GetDataInfoByItemID(string itemID)
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByBrand(string brandName)
        {
            throw new NotImplementedException();
        }

        public IList<DataInfo> GetDataInfoListByCatagory(string catagoryName)
        {
            throw new NotImplementedException();
        }

        public IList<CompanyInfo> GetAllCompanyInfoList()
        {
            throw new NotImplementedException();
        }

        public CompanyInfo GetCompanyInfoByCompanyID(string companyID)
        {
            throw new NotImplementedException();
        }

        public CompanyInfo GetCompanyInfoByItemID(string itemID)
        {
            throw new NotImplementedException();
        }
    }
}