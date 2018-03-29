using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Playground.Data;
using Playground.Interfaces;
using Playground.Models;

namespace Playground.Repositories
{
    public class CountryRepositoryWithUow : IRepository<Country>
    {
        private readonly EfContext _context;

        public CountryRepositoryWithUow(EfContext context)
        {
            _context = context;
        }

        public IEnumerable<Country> GetAll(Func<Country, bool> predicate = null)
        {
            if (predicate != null)
            {
                return _context.Countries.Where(predicate);
            }
            return _context.Countries;
        }

        public Country Get(Func<Country, bool> predicate)
        {
            return _context.Countries.FirstOrDefault(predicate);
        }

        public void Add(Country entity)
        {
            _context.Countries.Add(entity);
        }

        public void Attach(Country entity)
        {
            _context.Countries.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(Country entity)
        {
            _context.Countries.Remove(entity);
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