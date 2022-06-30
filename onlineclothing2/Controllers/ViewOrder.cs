using Microsoft.AspNetCore.Mvc;

namespace onlineclothing2.Controllers
{
    public class ViewOrder : Controller
    {
        public IActionResult vieworder()
        {
            return View();
        }
    }
}
