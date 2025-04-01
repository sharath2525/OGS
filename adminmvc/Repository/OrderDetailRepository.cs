using adminmvc.Data;
using adminmvc.Models;
using adminmvc.Repository.IRepository;

namespace adminmvc.Repository
{
    public class OrderDetailRepository : Repository<OrderDetail>, IOrderDetailRepository
    {
        private GroceryDbContext _db;
        public OrderDetailRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OrderDetail obj)
        {
            _db.OrderDetails.Update(obj);
        }
    }
}
