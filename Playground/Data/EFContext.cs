using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Playground.Models;

namespace Playground.Data
{
    public class EfContext : DbContext
    {
        public EfContext() : base("Dev")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<EfContext>());
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Organisation>();
            modelBuilder.Entity<Administration>();
            modelBuilder.Entity<Structure>();
            modelBuilder.Entity<Country>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Country> Countries { get; set; }
    }
}