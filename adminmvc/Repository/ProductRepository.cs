using adminmvc.Data;
using adminmvc.Models;
using adminmvc.Repository.IRepository;

namespace adminmvc.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private GroceryDbContext _db;
        public ProductRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }

        
    }
}
