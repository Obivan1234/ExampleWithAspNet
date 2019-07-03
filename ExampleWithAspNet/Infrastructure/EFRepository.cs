using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ExampleWithAspNet.Infrastructure
{
    public class EFRepository<T> : IRepository<T> where T : BaseEntity
    {
        private IDbSet<T> dbSet;
        private DbContext context;

        public EFRepository(DbContext dbContext)
        {
            context = dbContext;
        }

        public void Create(T item)
        {
            this._entity.Add(item);
            this.context.SaveChanges();
        }

        public void Delete(T item)
        {
            this._entity.Remove(item);
            this.context.SaveChanges();
        }

        public T FindById(int id)
        {
            //return this._entity.AsNoTracking().Where(w=>w.Id == id).FirstOrDefault();

            //var item  = this._entity.Find(id);
            //var temp = this.context.Entry(item).State;
            return this._entity.Find(id);
        }

        public IEnumerable<T> Get()
        {
            return this._entity.AsNoTracking().ToList();
        }

        public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return this._entity.AsNoTracking().Where(predicate).ToList();
        }

        public void Update(T item)
        {
        //    var temp = this.context.Entry(item).State;
            this.context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();

        }

        public IEnumerable<T> GetWithInclude(params Expression<Func<T, object>>[] includeProperties)
        {
            return Include(includeProperties).ToList();
        }

        public IEnumerable<T> GetWithInclude(Func<T, bool> predicate,
            params Expression<Func<T, object>>[] includeProperties)
        {
            var query = Include(includeProperties);
            return query.Where(predicate).ToList();
        }

        private IQueryable<T> Include(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = this._entity.AsNoTracking();
            return includeProperties
                .Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
        }

        protected IDbSet<T> _entity
        {
            get
            {
                if (dbSet == null)
                    dbSet = context.Set<T>();
                return dbSet;
            }
        }
    }
}