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
            return DataFeedManager.LoadAllDataFeeds().OrderBy(d => d.ItemDescription).ToList();
        }

        public IList<DataInfo> GetDataInfoListByItemIDList(List<string> itemIDList)
        {
            return DataFeedManager.LoadAllDataFeeds().Where(d => itemIDList.Contains(d.ItemID)).ToList();
        }

        public IList<DataInfo> GetDataInfoListByCompanyID(string companyID)
        {
            return DataFeedManager.LoadAllDataFeeds().Where(d => d.CompanyName == companyID).ToList();
        }

        public IList<DataInfo> GetDataInfoListByCompanyName(string companyName)
        {
            return DataFeedManager.LoadAllDataFeeds().Where(d => d.CompanyName == companyName).ToList();
        }

        public DataInfo GetDataInfoByItemID(string itemID)
        {
            return DataFeedManager.LoadAllDataFeeds().FirstOrDefault(d => d.ItemID == itemID);
        }

        public IList<DataInfo> GetDataInfoListByBrand(string brandName)
        {
            return DataFeedManager.LoadAllDataFeeds().Where(d => d.BrandName == brandName).ToList();
        }

        public IList<DataInfo> GetDataInfoListByCatagory(string catagoryName)
        {
            return DataFeedManager.LoadAllDataFeeds().Where(d => d.ItemCategory == catagoryName).ToList();
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