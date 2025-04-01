using adminmvc.Data;
using adminmvc.Models;
using adminmvc.Repository.IRepository;

namespace adminmvc.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private GroceryDbContext _db;
        public ApplicationUserRepository(GroceryDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
