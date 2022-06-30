using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using onlineclothing2.Models;
using System.Collections.Generic;

namespace onlineclothing2.Controllers
{
    public class PorderController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult porder()
        {
            //var dataselect = dal.check.ToList();
           // ViewBag.data = dataselect;

            //select();
            return View();

            
        }
        //[HttpPost]
        //public IActionResult Order(Checkout ck)
        //{
        //    Checkout ob = new Checkout()
        //    {
        //        Fullname= ck.Fullname,
        //        phone=ck.phone,
        //        Delivery=ck.Delivery,
        //        payment=ck.payment,
        //    };

        //    dal.check.Add(ob);
        //    dal.SaveChanges();
        //    return RedirectToAction("porder");
        //}
       [HttpPost]
       [ValidateAntiForgeryToken]
       public async Task<IActionResult> porder(Checkout chec)
        {
            List<Add> products = HttpContext.Session.Get<List<Add>>("products");
            if(products != null)
            {
                foreach(var product in products)
                {
                    Testcart orderd=new Testcart();
                    orderd.productid = product.id;
                    chec.Testcart.Add(orderd);
                }
            }
            chec.OrederNo = GetOrderNo();
            dal.check.Add(chec);
            dal.SaveChanges();
            HttpContext.Session.Set("products", new List<Add>());
            return View();
        }
        public string GetOrderNo()
        {
            int rowCount=dal.check.ToList().Count()+1;
            return rowCount.ToString("000");
        }
    }
}
