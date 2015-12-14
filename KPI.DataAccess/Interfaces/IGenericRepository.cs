using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using KPI.DataAccess.Core;
namespace KPI.DataAccess.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void DeleteById(int id);
        void Delete(Expression<Func<T, bool>> where);
        T GetById(long id);
        T GetById(string id);
        T GetById(int id);
        T GetById(object id, string includes);
        T Get(Expression<Func<T, bool>> where);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(string includes);
        IQueryable<T> GetMany(Expression<Func<T, bool>> where);
        PageResult<T> GetPage<TOrder>(Page page, Expression<Func<T, bool>> where, Expression<Func<T, TOrder>> order);
    }
}
