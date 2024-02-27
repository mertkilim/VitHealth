using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VitHealth.Entities.Concrete;

namespace VitHealth.DAL.EFCoreDbContexts
{
    public class PgSqlContext : DbContext
    {
        public PgSqlContext()
        {

        }
        public PgSqlContext(DbContextOptions<PgSqlContext> options) : base(options)
        {

        }


        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Policlinic> Policlinics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"User ID=postgres;Password=Eyup2006;Host=localhost;Port=5432;Database=VitHealth;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("VitHealth.Entities"));
        }
    }
}
