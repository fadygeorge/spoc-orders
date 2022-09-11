using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spoc1.Data
{
    public class Repository<TEntity> where TEntity : class
    {
        private readonly Context dbcontext;

        public Repository(Context context)
        {
            dbcontext = context;
        }

        // List
        protected virtual IQueryable<TEntity> AsQueryable()
        {
            return dbcontext.Set<TEntity>();
        }

        // Insert
        protected virtual void Insert(TEntity entity)
        {
            //dbcontext.Set<TEntity>().AddAsync(entity);
            dbcontext.Set<TEntity>().Add(entity);
        }

        // Edit
        protected virtual void Update(TEntity entity)
        {
            dbcontext.Entry(entity).State = EntityState.Modified;
        }

        // Delete
        protected virtual void Delete(TEntity entity)
        {
            dbcontext.Set<TEntity>().Remove(entity);
        }

    }
}
