using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using onlineclothing2.Models;
using onlineclothing2.Helpers;
//using LearnASPNETCoreMVC5.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace onlineclothing2.Controllers
{
    public class Loginadmin : Controller
    {
        DataContext dal = new DataContext();
        // GET: /<controller>/
        public IActionResult loginadmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginCheck(LoginAdmin loginadmin)
        {
            var list = dal.Userlogins.Where(x => x.Email.Equals(loginadmin.email)).ToList();
            if (list.Count() == 1 && list[0].Email.Equals(loginadmin.email) && list[0].Password.Equals(loginadmin.password) && list[0].role.Equals("user"))
            {
               var catsession=dal.cat.ToList();

                //string hm = catsession[0].cname;

                string email = list[0].Email;
                string role = list[0].role;
                SessionHelper.SetObjectAsJson(HttpContext.Session, "products", catsession);
               // HttpContext.Session.SetString("cat", catsession);
                HttpContext.Session.SetString("email", email);
                HttpContext.Session.SetString("role", role);


                return RedirectToAction("Index", "Home");

            }else if(list.Count() == 1 && list[0].Email.Equals(loginadmin.email) && list[0].Password.Equals(loginadmin.password) && list[0].role.Equals("admin"))
            {

                string email = list[0].Email;
                string role = list[0].role;

                
                HttpContext.Session.SetString("email", email);
                HttpContext.Session.SetString("role", role);
                return RedirectToAction("AdminHome", "Home");
            }
            else
            {
                return RedirectToAction("Loginadmin", "loginadmin");
            }


            return RedirectToAction("Loginadmin", "loginadmin");
        }
    }
}

