using MyStay.Core.IDomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace MyStay.Infra
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly HotelDbContext Context;
        protected int Save()
        {
          return Context.SaveChanges();
        }

        public Repository(HotelDbContext context)
        {
            Context = context;
        }
        public int Add(TEntity entity)
        {
            Context.Add(entity);
           return Save();
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        public TEntity Get(int id)
        {
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
