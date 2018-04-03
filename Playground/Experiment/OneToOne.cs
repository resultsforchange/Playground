namespace Playground.Experiment
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OneToOne : DbContext
    {
        public OneToOne()
            : base("name=OneToOne")
        {
        }

        public virtual DbSet<PassportDetails> PassportDetails { get; set; }
        public virtual DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PassportDetails>()
                .Property(e => e.Passport_Number)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .Property(e => e.EmailId)
                .IsUnicode(false);

            modelBuilder.Entity<Person>()
                .HasMany(e => e.PassportDetails)
                .WithOptional(e => e.Person)
                .HasForeignKey(e => e.Fk_Person_Id);
        }
    }
}
