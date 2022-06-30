using Microsoft.AspNetCore.Mvc;

namespace onlineclothing2.Controllers
{
    public class Mencoart : Controller
    {
        public IActionResult MencoartIndex()
        {
            return View();
        }
    }
}
