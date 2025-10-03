using Microsoft.EntityFrameworkCore;
using ProvidersAPI.Models;

namespace ProvidersAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Provider> Providers { get; set; }
    }
}
