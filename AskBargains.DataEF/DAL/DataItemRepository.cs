using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using AskBargains.DataEF.Models;

namespace AskBargains.DataEF.DAL
{
    public class DataItemRepository : IDataItemRepository
    {
        private readonly DataItemContext context;

        #region ctor
        public DataItemRepository(DataItemContext ctxt)
        {
            context = ctxt;
            context.Configuration.ProxyCreationEnabled = false;
            context.Configuration.LazyLoadingEnabled = false;
        }
        #endregion
        
        #region IDataItemRepository
        public IList<DataItem> GetDataItems()
        {
            return context.DataItems.Include(d=>d.Comments).ToList();
        }

        public DataItem GetDataItemtById(long dataItemId)
        {
            return context.DataItems.Where(d=>d.DataItemId == dataItemId).Include(d=>d.Comments).FirstOrDefault();
        }

        public void InsertDataItem(DataItem dataItem)
        {
            context.DataItems.Add(dataItem);
        }

        public void DeleteDataItem(int dataItemId)
        {
            var dataItem = context.DataItems.Find(dataItemId);
            context.DataItems.Remove(dataItem);
        }

        public void UpdateDataItem(DataItem dataItem)
        {
            context.Entry(dataItem).State = EntityState.Modified;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        #endregion

        #region IDisposable

        private bool disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}
