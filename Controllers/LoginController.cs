using Microsoft.AspNetCore.Mvc;

namespace OGS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
