using cruddbfa.Models;
using Microsoft.EntityFrameworkCore;

namespace cruddbfa.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options){}
        public DbSet<Product> Product { get; set; }

    }
}



