using Microsoft.AspNetCore.Mvc;

namespace onlineclothing2.Controllers
{
    public class Customers : Controller
    {
        public IActionResult customer()
        {
            return View();
        }
    }
}
