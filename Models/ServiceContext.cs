using Microsoft.EntityFrameworkCore;

namespace hospital_web_api.Models
{
    public class ServiceContext : DbContext
    {
        public ServiceContext(DbContextOptions<ServiceContext> options) : base(options) { }
        public DbSet<Service> Services { get; set; }
    }
}
