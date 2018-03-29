using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WizardTestBed.models;
using WizardTestBed.Models;

namespace WizardTestBed.Data
{
    public class EfContext : DbContext
    {
        /// <summary>
        /// Parameterized class constructor
        /// The name specified in the call to the base constructor will be the database name. 
        /// </summary>
        public EfContext() : base("Dev")
        {
            // calling DBInitializer to insert some data in the database
            Database.SetInitializer(new CreateDatabaseIfNotExists<EfContext>());
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Removing the PluralizingTableNameConvention will make sure that 
            // the table names match the model classes names.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Making the context aware of the available model classes by using 
            // the Entity<T> method on the modelBuilder object. EF code first 
            // will then figure out what tables and relations to create based 
            // on the model classes.
            modelBuilder.Entity<Organisation>();
            modelBuilder.Entity<Administration>();
            modelBuilder.Entity<Structure>();
        }
    }
}
