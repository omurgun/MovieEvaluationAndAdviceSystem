﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MEAAS.DataAccess.Abstract;
using MEAAS.Entities.Abstract;

namespace MEAAS.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntry = context.Entry(entity);
                addedEntry.State = EntityState.Added; 
                context.SaveChanges();
                return entity;

            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntry = context.Entry(entity);
                deletedEntry.State = EntityState.Deleted; 
                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().FirstOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
               
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntry = context.Entry(entity);
                updatedEntry.State = EntityState.Modified; 
                context.SaveChanges();
                return entity;
            }

        }
    }
}
