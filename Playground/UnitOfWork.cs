
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Objects;
using System.Linq;
using System.Transactions;


namespace RepositoryFramework
{
    [Export(typeof (IUnitOfWork))]
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope tx;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <param name="orm">The orm.</param>
        public UnitOfWork(DbContext orm)
        {
            this.Orm = orm;
        }

        #region IUnitOfWork Members

        public object Orm { get; private set; }


        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">The entity.</param>
        public void Add<T>(T entity) where T : class
        {
            ((DbContext)Orm).Set<T>().Add(entity);
        }

        /// <summary>
        /// Updates the specified entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">The entity.</param>
        public void Update<T>(T entity) where T : class
        {
            ((DbContext)Orm).Set<T>().Attach(entity);
            ((DbContext)Orm).Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="entity">The entity.</param>
        public void Delete<T>(T entity) where T : class
        {
            ((DbContext)Orm).Set<T>().Remove(entity);
        }

        /// <summary>
        /// Begins the transaction.
        /// </summary>
        public void BeginTransaction()
        {
            tx = new TransactionScope();
        }

        /// <summary>
        /// Commits the transaction.
        /// </summary>
        public void CommitTransaction()
        {
            try
            {
                if (tx == null)
                {
                    throw new TransactionException("The current transaction is not started!");
                }
                ((DbContext)Orm).SaveChanges();
                tx.Complete();
            }         
            finally
            {
                tx.Dispose();
            }
        }

        /// <summary>
        /// Rollbacks the transaction.
        /// </summary>
        public void RollbackTransaction()
        {
            if (tx != null)
            {
                tx.Dispose();
            }
        }

        public List<String> GetValidationErrors()
        {
            return (from ert in ((DbContext) Orm).GetValidationErrors() from err in ert.ValidationErrors select err.ErrorMessage).ToList();
        }
        #endregion

        private static string EntitySetName<T>()
        {
            return String.Format(@"{0}s", typeof (T).Name);
        }
    }
}