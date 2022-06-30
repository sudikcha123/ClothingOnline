using Microsoft.AspNetCore.Mvc;
using onlineclothing2.Models;

namespace onlineclothing2.Controllers
{
    public class Single : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult details()
        {
            select();
            return View();
        }
        public IActionResult select()
        {
            var data = dal.pcs.ToList();
            ViewBag.d = data[0];
            return RedirectToAction("details", "Single");

        }
        [Route("Single/Singlepics/{id}")]
        
        public IActionResult Singlepics(int id)
        {
            var data = dal.pcs.Find(id);
            ViewBag.d = data;
            return View();
        }
       public IActionResult addtocart(Testcart vm)
        {
            var data = dal.pcs.Find(vm.id);

            try
            {
                Testcart cart = new Testcart()
                {
                     
                      price=vm.price,
                      productid=vm.id,
                      name=vm.name,
                      username=vm.username,
                      category=vm.category,
                      quantity=vm.quantity


                };
                dal.Testcarts.Add(cart);
                dal.SaveChanges();

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction("cart", "Cart");
        }
    }
}
