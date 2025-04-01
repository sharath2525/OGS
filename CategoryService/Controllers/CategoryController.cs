using CategoryService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CategoryService.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly GroceryDbContext _db;

        public CategoryController(GroceryDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = _db.Categories.ToList();
            if(categories.Count == 0)
            {
                return NotFound("Categories Not Found");
            }
            else
            {
                return Ok(categories);
            }
        }

        [HttpPost]
        public IActionResult CreateCategories(Category obj)
        {
            _db.Categories.Add(obj);
            _db.SaveChanges();
            return Ok("Category Added Successfully");
        }

        [HttpPut]
        public IActionResult EditCategories(Category obj)
        {
            _db.Categories.Update(obj);
            _db.SaveChanges();
            return Ok("Category Updated Successfully");

        }

        [HttpDelete]
        public IActionResult DeleteCategories(int CategoryId)
        {
            var cat = _db.Categories.Find(CategoryId);
            _db.Categories.Remove(cat);
            _db.SaveChanges();
            return Ok("Category Deleted Successfully");

        }
    }
}
