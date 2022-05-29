using Microsoft.AspNetCore.Mvc;

namespace onlineclothing2.Controllers
{
    public class Register : Controller
    {
        public IActionResult Userregister()
        {
            return View();
        }
        public IActionResult Loginuser()
        {
            return View();
        }
    }
}
