using System;
using System.Collections.Generic;
using AskBargains.DataEF.DAL;
using AskBargains.DataEF.Models;
using AskBargainsServices.ServiceContracts;
using System.Linq;

namespace AskBargainsServices.ServiceImplementation
{
    public class DataService :IDataService
    {

        #region Constructor
        private readonly IDataItemRepository dataItemRepository;

        public DataService()
        {
            dataItemRepository = new DataItemRepository( new DataItemContext());
        }
        public DataService(IDataItemRepository repository)
        {
            dataItemRepository = repository;
        }

        #endregion

        #region IDataService



        public IList<DataItem> GetAllDataItems()
        {
            var test = dataItemRepository.GetDataItems().ToList();
            return test;
        }

     

        #endregion

        //public void Dispose()
        //{
        //    dataItemRepository.Dispose();
        //}
    }
}