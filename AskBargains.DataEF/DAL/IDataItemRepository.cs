using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AskBargains.DataEF.Models;

namespace AskBargains.DataEF.DAL
{
    public interface IDataItemRepository : IDisposable
    {
        IList<DataItem> GetDataItems();
        DataItem GetDataItemtById(long dataItemId);
        void InsertDataItem(DataItem dataItem);
        void DeleteDataItem(int dataItemId);
        void UpdateDataItem(DataItem dataItem);
        void Save();
    }
}
