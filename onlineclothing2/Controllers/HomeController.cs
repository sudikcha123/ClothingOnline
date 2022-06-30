using Microsoft.AspNetCore.Mvc;
using onlineclothing2.Models;
using onlineclothing2.ViewModel;
using System.Diagnostics;

namespace onlineclothing2.Controllers
{
    public class HomeController : Controller
    {
        DataContext dal = new DataContext();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(search search)
        {
            Display(search);
            return View();
        }
        public IActionResult Display(search search)
        {
            if (search.name == null)
            {
                var data = dal.pcs.ToList();
                ViewBag.d = data;
                return RedirectToAction("Index","Home");
            }
            else
            {
                var user = dal.pcs.Where(x => x.name.Contains(search.name)).ToList();
                if (user != null)
                {
                    var dataselect = user;
                    ViewBag.d = dataselect;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    var dataselect = dal.pcs.ToList();
                    ViewBag.d = dataselect;
                    return RedirectToAction("Index", "Home");
                }
            }
        
        }
        public IActionResult search()
        {
            return View();
        }
        public IActionResult Adminhome()
        {

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}