using Microsoft.EntityFrameworkCore;

namespace hospital_web_api.Models
{
    public class DoctorContext : DbContext
    {
        public DoctorContext(DbContextOptions<DoctorContext> options) : base(options) { }
        public DbSet<Doctor> Doctors { get; set; }
    }
}
