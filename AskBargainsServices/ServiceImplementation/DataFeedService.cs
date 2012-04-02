using System;
using System.Collections.Generic;
using AskBargainsServices.DataContracts;
using AskBargainsServices.DataFeeds;
using AskBargainsServices.ServiceContracts;
using System.Linq;

namespace AskBargainsServices.ServiceImplementation
{
    public class DataFeedService :IDataFeedService
    {
        public IList<string> GetAllFileList()
        {
            return DataFeedManager.GetAllFileList();
        }

        public IList<DataInfo> GetDataInfoListByFileNameList(IList<string> fileNameList)
        {

            return DataFeedManager.LoadDataFeedsByFileNameList(fileNameList);
        }

        public IList<DataInfo> GetDataInfoListByFileName(string fileName)
        {
            return DataFeedManager.LoadDataFeedByFileName(fileName);
        }

        public IList<DataInfo> GetDataInfoListByDefault()
        {
            return DataFeedManager.LoadAllDataFeeds();
        }

        public IList<DataInfo> GetDataInfoListByDateString(string date)
        {
            return DataFeedManager.LoadAllDataFeeds().Where(d => d.PublishDate == date).ToList();
        }

        public IList<DataInfo> GetDataInfoListByDate(DateTime date)
        {
            var datestr = date.ToString("yyyy-MM-dd");
            return GetDataInfoListByDateString(datestr);
        }

        public IList<DataInfo> GetDataInfoListByNumberOfItems(int numberOfItems)
        {
            return DataFeedManager.LoadAllDataFeeds().Take(numberOfItems).ToList();
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