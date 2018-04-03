using System;
using System.Collections.Generic;
using Playground.Models;

namespace Playground.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Func<T, bool> predicate = null);
        T Get(Func<T, bool> predicate);
        void Add(T entity);
        void Attach(T entity);
        void Delete(T entity);
        void Dispose(bool disposing);
    }
}
