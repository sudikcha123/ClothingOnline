using Microsoft.AspNetCore.Mvc;
using onlineclothing2.Models;

namespace onlineclothing2.Controllers
{
    public class TopsController : Controller
    {
        DataContext db = new DataContext();
        public IActionResult Index()
        {
          
            return View();
        }
    }
}
