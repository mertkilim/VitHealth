using Microsoft.EntityFrameworkCore;
using System.Reflection;
using VitHealth.Entities.Concrete;

namespace VitHealth.DAL.EFCoreDbContexts
{
    public class SqlServerDbContext : DbContext
    {
        public SqlServerDbContext()
        {

        }
        public SqlServerDbContext(DbContextOptions<SqlServerDbContext> options) : base(options)
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Policlinic> Policlinics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=VitHealth;Trusted_Connection=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.Load("VitHealth.Entities"));
        }
    }
}
