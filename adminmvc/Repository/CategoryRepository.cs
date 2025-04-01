using adminmvc.Data;
using adminmvc.Models;
using adminmvc.Repository.IRepository;

namespace adminmvc.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private GroceryDbContext _db;
        public CategoryRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
