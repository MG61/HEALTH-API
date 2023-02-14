using Microsoft.EntityFrameworkCore;

namespace API_Health.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option) : base(option)
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}
