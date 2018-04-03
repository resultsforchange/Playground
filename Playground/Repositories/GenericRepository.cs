using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using Playground.Data;
using Playground.Interfaces;
using System.Data.Entity;
using System.Linq;

namespace Playground.Repositories
{
    class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly EfContext _context;
        private readonly IDbSet<T> _dbSet;

        public GenericRepository(EfContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate = null)
        {
            return predicate != null ? _dbSet.Where(predicate) : _dbSet.AsEnumerable();
        }

        public T Get(Func<T, bool> predicate)
        {
            return _dbSet.First(predicate);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Attach(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _dbSet.Attach(entity);
            
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }
    }
}