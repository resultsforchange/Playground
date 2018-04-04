namespace Playground.Experiment
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OrgDataWithLookups : DbContext
    {
        public OrgDataWithLookups()
            : base("name=OrgDataWithLookups")
        {
        }

        public virtual DbSet<Administration> Administration { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<LearntAbout> LearntAbout { get; set; }
        public virtual DbSet<OperationalArea> OperationalArea { get; set; }
        public virtual DbSet<OperationalLocation> OperationalLocation { get; set; }
        public virtual DbSet<Organisation> Organisation { get; set; }
        public virtual DbSet<Structure> Structure { get; set; }
        public virtual DbSet<WomensRightsIssue> WomensRightsIssue { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .HasMany(e => e.Administration)
                .WithRequired(e => e.Country)
                .HasForeignKey(e => e.PhysicalCountry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.Administration1)
                .WithRequired(e => e.Country1)
                .HasForeignKey(e => e.PostalCountry)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Country>()
                .HasMany(e => e.OperationalLocation)
                .WithRequired(e => e.Country)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LearntAbout>()
                .HasMany(e => e.Administration)
                .WithRequired(e => e.LearntAbout)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationalArea>()
                .HasMany(e => e.OperationalLocation)
                .WithRequired(e => e.OperationalArea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationalArea>()
                .HasMany(e => e.Organisation)
                .WithRequired(e => e.OperationalArea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OperationalLocation>()
                .Property(e => e.Location)
                .IsFixedLength();

            modelBuilder.Entity<OperationalLocation>()
                .Property(e => e.InsertedBy)
                .IsFixedLength();

            modelBuilder.Entity<OperationalLocation>()
                .Property(e => e.ModifiedBy)
                .IsFixedLength();

            modelBuilder.Entity<Organisation>()
                .HasMany(e => e.OperationalLocation)
                .WithRequired(e => e.Organisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WomensRightsIssue>()
                .HasMany(e => e.Organisation)
                .WithRequired(e => e.WomensRightsIssue)
                .HasForeignKey(e => e.WomensRightsIssuesId)
                .WillCascadeOnDelete(false);
        }
    }
}
