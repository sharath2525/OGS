using Microsoft.AspNetCore.Mvc;

namespace OGS.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
