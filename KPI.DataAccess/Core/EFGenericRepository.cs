using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using KPI.DataAccess.Interfaces;
using System.Data.Entity;
using KPI.DataAccess.Interfaces;
namespace KPI.DataAccess.Core
{
    public class EFGenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbContext _context;
        private readonly IDbSet<T> dbset;
        public EFGenericRepository(IUnitOfWork unitOfWork)
        {
            _context = unitOfWork.GetDataContext;
            dbset = Context.Set<T>();
        }

        public DbContext Context
        {
            get { return _context ?? (_context = null); }
        }
        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            Context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(int id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(object id, string includes)
        {
            var entity = dbset.Find(id);
            Context.Entry(entity).Reference(includes).Load();
            return entity;
        }
        public virtual IQueryable<T> GetAll()
        {
            return dbset.AsQueryable();
        }

        public virtual IQueryable<T> GetAll(string includes)
        {
            return dbset.Include(includes);
        }

        public virtual IQueryable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where);
        }

        /// <summary>
        /// Return a paged list of entities
        /// </summary>
        /// <typeparam name="TOrder"></typeparam>
        /// <param name="page">Which page to retrieve</param>
        /// <param name="where">Where clause to apply</param>
        /// <param name="order">Order by to apply</param>
        /// <returns></returns>
        public virtual PageResult<T> GetPage<TOrder>(Page page, Expression<Func<T, bool>> where, Expression<Func<T, TOrder>> order)
        {
            var results = dbset.OrderBy(order).Where(where).GetPage(page).AsQueryable();
            var total = dbset.Count(where);
            return new PageResult<T>(results, page, total);
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        public void DeleteById(int id)
        {
            var entity = dbset.Find(id);
            dbset.Remove(entity);
        }
    }
}
