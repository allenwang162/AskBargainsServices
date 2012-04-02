using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Xml.Linq;
using AskBargainsServices.DataContracts;
using System.IO;

namespace AskBargainsServices.DataFeeds
{
    public class DataFeedManager
    {
        //private static readonly string DataFeedPath = HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data");

        public static IList<DataInfo> LoadAllDataFeeds()
        {
            var path = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data");
            var dataFeedNames = Directory.EnumerateFiles(path, "*xml", SearchOption.TopDirectoryOnly);


            var list = new List<DataInfo>();
            foreach (var fileName in dataFeedNames)
                list.AddRange(XDocument.Load(fileName).Element("Data").Descendants("DataInfo").Select(da => LoadDataInfoFromXML(da)));
            return list;
        }

        private static DataInfo LoadDataInfoFromXML(XContainer xml)
        {
            var dataInfo = new DataInfo();

            var element = xml.Element("BrandName");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.BrandName = element.Value;

            element = xml.Element("CONDITION");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.CONDITION = element.Value;

            element = xml.Element("CompanyName");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.CompanyName = element.Value;

            element = xml.Element("Content");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.Content = element.Value;

            element = xml.Element("CouponCode");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.CouponCode = element.Value;

            element = xml.Element("ExpireDate");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.ExpireDate = element.Value;

            element = xml.Element("ForwardLink");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.ForwardLink = element.Value;

            element = xml.Element("ImgPath");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.ImgPath = element.Value;

            element = xml.Element("ItemCategory");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.ItemCategory = element.Value;

            element = xml.Element("ItemDescription");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.ItemDescription = element.Value;

            element = xml.Element("ItemID");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.ItemID = element.Value;

            element = xml.Element("ItemName");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.ItemName = element.Value;

            element = xml.Element("ItemPrice");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.ItemPrice = element.Value;

            element = xml.Element("OriginalPrice");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.OriginalPrice = element.Value;

            element = xml.Element("Promotion");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.Promotion = element.Value;

            element = xml.Element("PublishDate");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.PublishDate = element.Value;

            element = xml.Element("Rebate");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.Rebate = element.Value;

            element = xml.Element("SKU");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.SKU = element.Value;

            element = xml.Element("Save");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.Save = element.Value;

            element = xml.Element("Shipping");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.Shipping = element.Value;

            element = xml.Element("ShowCoupons");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.ShowCoupons = element.Value;

            element = xml.Element("SubCategory");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.SubCategory = element.Value;

            element = xml.Element("Today");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.Today = element.Value;

            element = xml.Element("UserRated");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.UserRated = element.Value;

            element = xml.Element("WARRANTY");
            if (element != null && !string.IsNullOrEmpty(element.Value)) dataInfo.WARRANTY = element.Value;

            return dataInfo;
        }
    }
}