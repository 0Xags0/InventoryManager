using Microsoft.EntityFrameworkCore;
using InventoryManager.Models;

namespace InventoryManager.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> setting) 
            : base(setting) 
        {
            
        }

        public DbSet<Product> Products { get; set; }
    }

}
