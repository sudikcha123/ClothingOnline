using Microsoft.AspNetCore.Mvc;
using onlineclothing2.Models;

namespace onlineclothing2.Controllers
{
    public class Cart : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult cart(string username)
        {
            
            var cartlist = dal.Testcarts.Where(x=>x.username==username).ToList();
            var cartcount=cartlist.Count();
            ViewBag.cart = cartlist;
            int cc = cartcount - 1;
            int price = 0;
           for(int i = 0; i <= cc; i++)
            {
                price=price+(cartlist[i].price*cartlist[i].quantity);
            }
           ViewBag.total = price;
            /*var cartlist=dal.Testcarts.ToList();
            var cartcount = cartlist.Count();

            var productdetails=dal.pcs.ToList();

            var productcount = productdetails.Count();

            ViewBag.cartcount = cartcount;
            ViewBag.productcount = productcount;
            ViewBag.cart=cartlist;
            ViewBag.product = cartlist;*/
            return View();
        }
    }
}
