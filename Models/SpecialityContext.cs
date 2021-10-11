using Microsoft.EntityFrameworkCore;

namespace hospital_web_api.Models
{
    public class SpecialityContext : DbContext
    {
        public SpecialityContext(DbContextOptions<SpecialityContext> options) : base(options) { }
        public DbSet<Speciality> Specialitys { get; set; }
    }
}
