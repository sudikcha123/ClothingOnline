using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using onlineclothing2.Helpers;
using onlineclothing2.Models;
using System.Collections.Generic;

namespace onlineclothing2.Controllers
{
    public class PorderController : Controller
    {
        DataContext dal = new DataContext();
      
        public IActionResult porder()
        {

            return View();
        }


        public IActionResult checkMeout()
        {
            /*//var dataselect = dal.check.ToList();
            // ViewBag.data = dataselect;
            var sessionusername = HttpContext.Session.GetString("email");
            List<Testcart> carts = dal.Testcarts.Where(x => x.username.Equals(sessionusername)).ToList();
            foreach(var cart in carts)
            {
                var checkout = new Checkout()
                {
                    category = cart.category,
                    quantity = cart.,
                    fullname = ,
                    delivery = ,
                    phone =  ,
                    name = cart.name,
                    price = cart.price,
                };
                dal.check.Add(checkout);
            }*/
            /* HttpContext.Session.SetString("product", JsonConvert.SerializeObject(carts));*/
            /* for (int i = 0; i < carts.Count; i++)
             {
                 checkout.name = carts[i].name;
                 checkout.quantity = carts[i].quantity;
                 checkout.price = carts[i].price;
                 checkout.category = carts[i].category;

             }*/


            return View();
        }
        public IActionResult orderplaced(Checkout checkout)
        {
             var carts = JsonConvert.DeserializeObject<Testcart>(HttpContext.Session.GetString("product"));
            //List<Checkout> cas = carts.
          /* List<Checkout> ch = carts.Select(x => new Checkout()
            {
                           price = x.price,

            }).ToList()*/;

            return Redirect("porder");
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
        //   [HttpPost]
        //   [ValidateAntiForgeryToken]
        //   public async Task<IActionResult> porder(Checkout chec)
        //    {
        //       // List<Add> products = HttpContext.Session.Get<List<Add>>("products");
        //        if(products != null)
        //        {
        //            foreach(var product in products)
        //            {
        //                Testcart orderd=new Testcart();
        //                orderd.productid = product.id;
        //                chec.Testcart.Add(orderd);
        //            }
        //        }
        //        chec.OrederNo = GetOrderNo();
        //        dal.check.Add(chec);
        //        dal.SaveChanges();
        //       // HttpContext.Session.Set("products", new List<Add>());
        //        return View();
        //    }
        //    public string GetOrderNo()
        //    {
        //        int rowCount=dal.check.ToList().Count()+1;
        //        return rowCount.ToString("000");
        //    }
    }
}
