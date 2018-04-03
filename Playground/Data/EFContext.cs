using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Playground.Interfaces;
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

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Administration)
                .WithOptional(e => e.Organisation)
                .HasForeignKey(e => e.OrganisationId);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Structure)
                .WithOptional(e => e.Organisation)
                .HasForeignKey(e => e.OrganisationId);

            modelBuilder.Entity<Administration>();
            modelBuilder.Entity<Administration>()
                .Property(p => p.OrganisationId).IsOptional();

            modelBuilder.Entity<Structure>();
            modelBuilder.Entity<Structure>()
                .Property(p => p.OrganisationId).IsOptional();

            modelBuilder.Entity<Country>();

            modelBuilder.Entity<WomensRightsIssue>();

            modelBuilder.Entity<OperationalArea>();

            modelBuilder.Entity<LearntAbout>();

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<WomensRightsIssue> WomensRightsIssue { get; set; }
        public virtual DbSet<OperationalArea> OperationalArea { get; set; }
        public virtual DbSet<LearntAbout> LearntAbout { get; set; }
        public virtual DbSet<Organisation> Organisation { get; set; }
        public virtual DbSet<Administration> Administration { get; set; }
        public virtual DbSet<Structure> Structure { get; set; }

        /// <summary>
        ///  Set audit column values by overriding SaveChanges method
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
             .Where(x => x.Entity is IAuditableEntity
                 && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entry in modifiedEntries)
            {
                var entity = entry.Entity as IAuditableEntity;

                if (entity == null) continue;

                var identityName = Thread.CurrentPrincipal.Identity.Name;
                var now = DateTime.UtcNow;

                if (entry.State == EntityState.Added)
                {
                    entity.InsertedBy = identityName;
                    entity.InsertedDateTime = now;
                }
                else
                {
                    base.Entry(entity).Property(x => x.InsertedBy).IsModified = false;
                    base.Entry(entity).Property(x => x.InsertedDateTime).IsModified = false;
                }

                entity.ModifiedBy = identityName;
                entity.ModifiedDateTime = now;

                Debug.WriteLine("change = {0}",entity.ModifiedDateTime);
            }

            return base.SaveChanges();
        }
    }
}