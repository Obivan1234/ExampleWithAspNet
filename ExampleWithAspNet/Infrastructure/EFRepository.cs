using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
            this.context.Entry(item).State = EntityState.Modified;
            context.SaveChanges();

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