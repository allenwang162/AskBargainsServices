using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AskBargainsServices.Client.DataFeedService;

namespace AskBargainsServices.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //using(var client = new DataFeedServiceClient())
            //{
            //    var result = client.GetDataInfoListByDefault();
            //}

            DataInfo[] dataInfos;
            new WcfServiceProxyHelper<IDataFeedService>().Use(serviceProxy =>
                                                                  {
                                                                      dataInfos = serviceProxy.GetDataInfoListByDefault();
                                             
                                                                  },
                                                                  WcfEndPoints.DataFeedServiceEndPoint);

        }
    }
}
