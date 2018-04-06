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

        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<WomensRightsIssue> WomensRightsIssue { get; set; }
        public virtual DbSet<OperationalArea> OperationalArea { get; set; }
        public virtual DbSet<OperationalLocation> OperationalLocation { get; set; }
        public virtual DbSet<LearntAbout> LearntAbout { get; set; }
        public virtual DbSet<PreviousGrantsInformation> PreviousGrantsInformation { get; set; }
        public virtual DbSet<Organisation> Organisation { get; set; }
        public virtual DbSet<Administration> Administration { get; set; }   
        public virtual DbSet<Structure> Structure { get; set; }
        public virtual DbSet<File> File { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Entity<Country>()
                .HasMany(e => e.AdministrationPhysical)
                .WithRequired(e => e.PhysicalCountryId)
                .HasForeignKey(e => e.PhysicalCountry);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.AdministrationPostal)
                .WithRequired(e => e.PostalCountryId)
                .HasForeignKey(e => e.PostalCountry);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.OperationalLocations)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LearntAbout>()
                .HasMany(e => e.Administration)
                .WithRequired(e => e.LearntAbout)
                //.HasForeignKey(e => e.LearntAboutId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationalArea>()
                .HasMany(e => e.OperationalLocations)
                .WithRequired(e => e.OperationalArea)
                //.HasForeignKey(e => e.OperationalAreaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationalArea>()
                .HasMany(e => e.Organisations)
                .WithRequired(e => e.OperationalArea)
                //.HasForeignKey(e => e.OperationalAreaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Administration)
                .WithOptional(e => e.Organisation)
                .HasForeignKey(e => e.OrganisationId);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.Structure)
                .WithOptional(e => e.Organisation)
                .HasForeignKey(e => e.OrganisationId);

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.OperationalLocations)
                .WithRequired(e => e.Organisation)
                //.HasForeignKey(e => e.OrganisationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WomensRightsIssue>()
                .HasMany(e => e.Organisations)
                .WithRequired(e => e.WomensRightsIssue)
                .HasForeignKey(e => e.WomensRightsIssuesId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Administration>();
            modelBuilder.Entity<Administration>()
                .Property(p => p.OrganisationId).IsOptional();

            modelBuilder.Entity<Administration>()
                .HasMany(e => e.PreviousGrants)
                .WithRequired(e => e.Administration)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Structure>();
            modelBuilder.Entity<Structure>()
                .Property(p => p.OrganisationId).IsOptional();

            modelBuilder.Entity<Structure>()
                .HasMany(e => e.Files)
                .WithRequired(e => e.Structure)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }

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