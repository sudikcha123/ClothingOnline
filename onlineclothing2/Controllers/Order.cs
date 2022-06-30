using Microsoft.AspNetCore.Mvc;

namespace onlineclothing2.Controllers
{
    public class Order : Controller
    {
        public IActionResult order()
        {
            return View();
        }
    }
}
