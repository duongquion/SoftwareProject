using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ProjectSWT.EF
{
    public partial class ProjectSWTDbContext : DbContext
    {
        public ProjectSWTDbContext()
            : base("name=ProjectSWTDbContext")
        {
        }

        public virtual DbSet<CateSpecialization> CateSpecializations { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Guide> Guides { get; set; }
        public virtual DbSet<Level> Levels { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<Program> Programs { get; set; }
        public virtual DbSet<Schoolaship> Schoolaships { get; set; }
        public virtual DbSet<Specialization> Specializations { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<Program>()
                .Property(e => e.Images)
                .IsUnicode(false);

            modelBuilder.Entity<Program>()
                .Property(e => e.Prices)
                .HasPrecision(8, 2);

            modelBuilder.Entity<Schoolaship>()
                .Property(e => e.Prices)
                .HasPrecision(8, 2);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Role)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Images)
                .IsUnicode(false);
        }
    }
}
