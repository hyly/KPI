using System;
using System.Collections.Generic;
using KPI.DataAccess.Interfaces;
using System.Data.Entity;

namespace KPI.DataAccess.Core
{
    public class KPIUnitOfWork : IUnitOfWork
    {
        
        private DbContext context = null;
        public KPIUnitOfWork(DbContext context)
        {
            this.context = context;
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public DbContext GetDataContext
        {
            get { return this.context; }
        }
    }
}
