using Microsoft.EntityFrameworkCore;

namespace CategoryService.Models
{
    public class GroceryDbContext:DbContext
    {
        public GroceryDbContext(DbContextOptions<GroceryDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

    }
}
