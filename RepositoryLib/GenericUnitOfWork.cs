﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLib
{
    public class GenericUnitOfWork : IDisposable
    {
        DbContext context;
        public GenericUnitOfWork(DbContext context)
        {
            this.context = context;
        }
        public Dictionary<Type, object> repositories = new Dictionary<Type, object>();
        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (repositories.Keys.Contains(typeof(TEntity)) == true)
            {
                return repositories[typeof(TEntity)] as IGenericRepository<TEntity>;
            }
            IGenericRepository<TEntity> repo = new EFGenericRepository<TEntity>(context);
            repositories.Add(typeof(TEntity), repo);
            return repo;
        }
        public void SaveChanges()
        {
            context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
