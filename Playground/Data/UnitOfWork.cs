using System;
using Playground.Interfaces;
using Playground.Models;
using Playground.Repositories;

namespace Playground.Data
{
    public class UnitOfWork : IDisposable
    {
        private readonly EfContext _context;

        public UnitOfWork()
        {
            _context = new EfContext();
        }

        // Add all the repository handles here
        IRepository<Country> _countryRepository;

        // Add all the repository getters here
        public IRepository<Country> CountryRepository
        {
            get
            {
                if (_countryRepository == null)
                {
                    _countryRepository = new CountryRepositoryWithUow(_context);
                }
                return _countryRepository;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        private bool _disposed;

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

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}