using System;
using System.Collections.Generic;
using System.ServiceModel;
using System.Threading;

namespace AskBargainsServices.Client
{
    /// <summary>
    /// List all the wcfEndpoint configuration binding names
    /// </summary>
    public class WcfEndPoints
    {
        public const string DataFeedServiceEndPoint = "BasicHttpBinding_IDataFeedService";
    }
 
    /// <summary>
    /// Wcf Service Proxy Call Helper
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public  class WcfServiceProxyHelper<T>
    {
        /// <summary>
        /// This is the channel proxy
        /// </summary>
        IClientChannel proxy;
        /// <summary>
        /// This is the callback method for an async call back.
        /// </summary>
        AsyncCallback callBack;
        /// <summary>
        /// This is the method to be executed.
        /// </summary>
        Action<T> codeBlock;

        /// <summary>
        /// This is the store of the channel.
        /// </summary>
        private static readonly IDictionary<string, ChannelFactory<T>> ChannelPool = new Dictionary<string, ChannelFactory<T>>();


        
        /// <summary>
        /// Returns an instance of the channel object. The channel is not yet open.
        /// </summary>
        /// <param name="wcfEndPoint">This is the end point</param>
        /// <returns>Return List of all the invoked proxies</returns>
        private static ChannelFactory<T> GetChannelFactory(string wcfEndPoint)
        {
            ChannelFactory<T> channelFactory;
            //Check if the channel factory exists
            //Create and return an instance of the channel            
            if (! ChannelPool.TryGetValue(wcfEndPoint,out channelFactory))
            {
                channelFactory = new ChannelFactory<T>(wcfEndPoint);
                ChannelPool.Add(wcfEndPoint, channelFactory);
            }
            return channelFactory;
        }

        /// <summary>
        /// Invokes the method on the WCF interface with the given end point to 
        /// create a channel
        /// Usage
        /// new ProxyHelper<InterfaceName>().Use(serviceProxy =>
        ///         {
        ///             value = serviceProxy.MethodName(params....);
        ///         }, "WCFEndPoint");
        /// </summary>
        /// <param name="codeBlockAction">The WCF interface method of interface of type T
        /// </param>
        /// <param name="wcfEndPoint">The end point.</param>
        public  void Use(Action<T> codeBlockAction, string wcfEndPoint)
        {            
            try
            {
                //Create an instance of proxy
                proxy = GetChannelFactory(wcfEndPoint).CreateChannel() as IClientChannel;
                if (proxy != null)
                {
                    //open the proxy
                    proxy.Open();
                    //Call the method
                    codeBlockAction((T)proxy);
                    
                    proxy.Close();
                }
            }
            catch (FaultException)
            {
                if (proxy != null) proxy.Abort();
                throw;
            }
            catch (CommunicationException)
            {
                if (proxy != null)proxy.Abort();
                throw;
            }
            catch (TimeoutException)
            {
                if (proxy != null)proxy.Abort();
                throw;
            }
            catch (Exception)
            {
                if (proxy != null)proxy.Abort();
                throw;
            }
        }

        /// <summary>
        /// This method is called when the proxy is called using an async method
        /// </summary>
        /// <param name="ar">The result</param>
        private void AsyncResult(IAsyncResult ar)
        {
            //end the invocation
            codeBlock.EndInvoke(ar);      
            //close the proxy
            proxy.Close();
            //callback the method
            callBack(ar);
        }

        /// <summary>
        /// Invokes the method on the WCF interface with the given end point to create a channel
        /// </summary>
        /// <param name="codeBlockCallAction">The WCF interface method of interface of type T
        /// </param>
        /// <param name="wcfEndPoint">The end point.</param>
        /// <param name="callBackMethod"> </param>
        /// <param name="obj">The object instance used to identify in callback</param>
        public  void UseAsync(Action<T> codeBlockCallAction, string wcfEndPoint,AsyncCallback callBackMethod,object obj)
        {
            try
            {
                proxy = GetChannelFactory(wcfEndPoint).CreateChannel() as IClientChannel;
                if (proxy != null)
                {
                    
                    proxy.Open();
                    callBack = callBackMethod;
                    codeBlock = codeBlockCallAction;
                    if (codeBlockCallAction != null) codeBlockCallAction.BeginInvoke((T)proxy, AsyncResult, obj);
                }
            }
            catch (FaultException)
            {
                if (proxy != null) proxy.Abort();
                throw;
            }
            catch (CommunicationException)
            {
                if (proxy != null) proxy.Abort();
                throw;
            }
            catch (TimeoutException)
            {
                if (proxy != null) proxy.Abort();
                throw;
            }
            catch (Exception)
            {
                if (proxy != null) proxy.Abort();
                throw;
            }
        }
        
        /// <summary>
        /// This method calls the WCF Service in a new thread. The calling of other method for result is the 
        /// responsibility of the client code
        /// </summary>
        /// <param name="codeBlockAction">The method on the WCF service to be called</param>
        /// <param name="wcfEndPoint">This is the WCF end point</param>
        /// <param name="obj">This is any object which may help in exeution of the async parameters</param>
        public void UseAsyncWithReturnValue(Action<T,object> codeBlockAction, string wcfEndPoint, object obj)
        {
            try
            {
                proxy = GetChannelFactory(wcfEndPoint).CreateChannel() as IClientChannel;
                if (proxy != null)
                {
                    new Thread(() =>
                    {   //Create a new thread and on the new thread call the methos
                        codeBlockAction((T)proxy,obj);
                        proxy.Close();
                    }).Start();
                    
                }
            }
            catch (CommunicationException)
            {
                if (proxy != null)
                {
                    proxy.Abort();
                }
                throw;
            }
            catch (TimeoutException)
            {
                if (proxy != null)
                {
                    proxy.Abort();
                }
                throw;
            }
            catch (Exception)
            {
                if (proxy != null)
                {
                    proxy.Abort();
                }
                throw;
            }

        }
    }


}
