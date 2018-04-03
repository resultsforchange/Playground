using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Playground.Interfaces;
using Playground.Repositories;

namespace Playground.Data
{
    /// <summary>
    /// The Entity Framework implementation of IUnitOfWork
    /// </summary>
    public class GenericUnitOfWork : IDisposable
    {
        /// <summary>
        /// The DbContext
        /// </summary>
        private readonly EfContext _context;

        /// <summary>
        /// Initializes a new instance of the UnitOfWork class.
        /// </summary>
        public GenericUnitOfWork()
        {
            _context = new EfContext();
        }

        public Dictionary<Type, object> Repositories = new Dictionary<Type, object>();

        public IRepository<T> Repository<T>() where T : class
        {
            if (Repositories.Keys.Contains(typeof(T)))
            {
                return Repositories[typeof(T)] as IRepository<T>;
            }

            IRepository<T> repo = new GenericRepository<T>(_context);
            Repositories.Add(typeof(T), repo);
            return repo;
        }

        /// <summary>
        /// Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        public void SaveChanges()
        {
            if (_context.ChangeTracker.HasChanges())
            {
                Debug.WriteLine(_context.ChangeTracker.Entries().ToList().ToString());
            }
            // Save changes with the default options
            _context.SaveChanges();
        }

        private bool _disposed;

        /// <summary>
        /// Disposes all external resources.
        /// </summary>
        /// <param name="disposing">The dispose indicator.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        /// <summary>
        /// Disposes the current object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}