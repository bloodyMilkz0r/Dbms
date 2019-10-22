using System.Data.Entity;
namespace HospitalDB
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        {
        }
        public DbSet<Patient> Patients { get; set; }
    }
}