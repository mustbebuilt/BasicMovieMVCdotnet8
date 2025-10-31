using Microsoft.EntityFrameworkCore;

namespace MyMVC8.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Film> Films { get; set; }
    }
}

