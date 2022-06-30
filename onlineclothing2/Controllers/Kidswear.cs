using Microsoft.AspNetCore.Mvc;

namespace onlineclothing2.Controllers
{
    public class Kidswear : Controller
    {
        public IActionResult KidsIndex()
        {
            return View();
        }
    }
}
