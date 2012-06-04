using System;
using System.Collections.Generic;
using AskBargainsServices.Client.DataService;


namespace AskBargainsServices.Client
{
    class Program
    {
        static void Main(string[] args)
        {


            DataItem dataInfos = null;
            new WcfServiceProxyHelper<IDataService>().Use(serviceProxy =>
                                                                  {
                                                                      dataInfos = serviceProxy.GetDataItemById(20120514134959629);
                                                                  },
                                                                  WcfEndPoints.DataFeedServiceEndPoint);
            if (dataInfos != null)
            {
            }
        }
    }
}
