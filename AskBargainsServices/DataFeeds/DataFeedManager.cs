using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AskBargainsServices.DataContracts;
using System.IO;

namespace AskBargainsServices.DataFeeds
{
    public class DataFeedManager
    {
        public static IList<DataInfo> LoadAllDataFeeds()
        {
            var path = Environment.CurrentDirectory;
            var info = Directory.EnumerateFiles("","*xml",SearchOption.TopDirectoryOnly);

            return null;
        }
    }
}