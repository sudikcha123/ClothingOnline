using Microsoft.AspNetCore.Mvc;

namespace onlineclothing2.Controllers
{
    public class Login : Controller
    {
        public IActionResult login()
        {
            return View();
        }
    }
}
