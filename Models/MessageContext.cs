using Microsoft.EntityFrameworkCore;

namespace hospital_web_api.Models
{
    public class MessageContext : DbContext
    {
        public MessageContext(DbContextOptions<MessageContext> options) : base(options) { }
        public DbSet<Message> Messages { get; set; }
    }
}
