using System;
using System.Data.Entity;
using System.Linq;

namespace WizardTestBed.data
{
    public class Repository : IDisposable
    {
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        private IDbSet<TEntity> GetEntities<TEntity>() where TEntity : class
        {
            return _context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll<TEntity>() where TEntity : class
        {
            return GetEntities<TEntity>().AsQueryable();
        }

        public void Insert<TEntity>(TEntity entity) where TEntity : class
        {
            GetEntities<TEntity>().Add(entity);
        }

        public void Delete<TEntity>(TEntity entity) where TEntity : class
        {
            GetEntities<TEntity>().Remove(entity);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            // if _context != null then _context.Dispose()
            _context?.Dispose();
        }
    }
}
