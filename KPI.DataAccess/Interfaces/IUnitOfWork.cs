using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace KPI.DataAccess.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext GetDataContext { get; }
        void SaveChanges();
    }
}
