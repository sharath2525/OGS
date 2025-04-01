using adminmvc.Data;
using adminmvc.Models;
using adminmvc.Repository.IRepository;

namespace adminmvc.Repository
{
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private GroceryDbContext _db;
        public ShoppingCartRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
