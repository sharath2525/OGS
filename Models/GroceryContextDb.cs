using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace OGS.Models
{
    public class GroceryDbContext : DbContext
    {
        public GroceryDbContext(DbContextOptions<GroceryDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Register> Register { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetails> OrdersDetails { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<DeliveryDetails> DeliveryDetails { get; set; }
    }
}