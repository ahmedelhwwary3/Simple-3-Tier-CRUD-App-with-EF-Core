using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
namespace RepositoryLayer
{
    public class ClinicContext:DbContext
    {
        //{ConfigurationManager.ConnectionStrings["ClinicDB"].ConnectionString}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder?.UseSqlServer($"Data Source=.;\r\n\t\t\t Initial Catalog=ClinicEx1;Integrated Security=true;\r\n\t\t\t TrustServerCertificate=true;Multiple Active Result Sets=true;")
            .UseLazyLoadingProxies(true);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonDomain>(p=>
            {
                p.HasKey(p=>p.PersonID);
                p.HasOne(p => p.Doctor).WithOne(d=>d.Person);
            });
            modelBuilder.Entity<DoctorDomain>(d =>
            {
                d.HasKey(d=>d.DoctorID);
                d.HasOne(d=>d.Person).WithOne(p=>p.Doctor);
            });










            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<PersonDomain>People { get; set; }
        public virtual DbSet<DoctorDomain>Doctors { get; set; }






    }
}
