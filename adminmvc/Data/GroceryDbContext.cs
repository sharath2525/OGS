using adminmvc.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace adminmvc.Data
{
    public class GroceryDbContext : IdentityDbContext<IdentityUser>
    {
        public GroceryDbContext(DbContextOptions<GroceryDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Order> Orders {  get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Fruits&Vegetables", DisplayOrder = 1},
                new Category { CategoryId = 2, CategoryName = "DairyProducts", DisplayOrder = 2 },
                new Category { CategoryId = 3, CategoryName = "KitchenEssentials", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "Apples",
                    Price = 80,
                    Quantity = "1kg",
                    ImageUrl = "wrfwsvs",
                    Description = "Apples are good for health",
                    CategoryId = 1
                }
            );
        }
    }
}
