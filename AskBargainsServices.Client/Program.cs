using System;
using System.Collections.Generic;
using AskBargainsServices.Client.DataService;


namespace AskBargainsServices.Client
{
    class Program
    {
        static void Main(string[] args)
        {

            //Test GetDataItemById -- 20120514134959629
            DataItem dataItem = null;
            new WcfServiceProxyHelper<IDataService>().Use(serviceProxy =>
                                                                  {
                                                                      dataItem = serviceProxy.GetDataItemById(20120514134959629);
                                                                  },
                                                                  WcfEndPoints.DataFeedServiceEndPoint);


            //Test GetAllDataItems -- top 10 records will be returned. 

            IList<DataItem> dataItmes = null;
            new WcfServiceProxyHelper<IDataService>().Use(serviceProxy =>
            {
                dataItmes = serviceProxy.GetAllDataItems(20);
            },
            WcfEndPoints.DataFeedServiceEndPoint);

        }
    }
}
