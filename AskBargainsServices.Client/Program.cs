using System;
using System.Collections.Generic;
using AskBargainsServices.Client.DataService;


namespace AskBargainsServices.Client
{
    class Program
    {
        static void Main(string[] args)
        {


            IList<DataItem> dataInfos = null;
            new WcfServiceProxyHelper<IDataService>().Use(serviceProxy =>
                                                                  {
                                                                    dataInfos = serviceProxy.GetAllDataItems();
                                                                  },
                                                                  WcfEndPoints.DataFeedServiceEndPoint);
            if(dataInfos != null)
            {
                foreach (var dataInfo in dataInfos)
                {
                   
                }
            }
        }
    }
}
