using Microsoft.AspNetCore.Mvc;

namespace OGS.Controllers
{
    public class loginController : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
