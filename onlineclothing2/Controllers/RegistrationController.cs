using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using onlineclothing2.Models;

namespace onlineclothing2.Controllers
{
    public class RegistrationController : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult registration()
        {
            return View();
        }
        //public IActionResult SubmitRegistation(Userregister userregister)
        //{
        //    dal.register.Add(userregister);
        //    dal.SaveChanges();
        //    //return Redirect("/Login/login");
        //    return RedirectToAction("login");
        //}

        [HttpPost]
        public IActionResult SubmitRegistation(usersignup vm)
        {

            try
            {
                Userlogin login = new Userlogin()
                {
                   Email=vm.email,
                   Password=vm.password,
                  role="user"
                  
                };

                Userregister register = new Userregister()
                {

                    username = vm.username,
                    email = vm.email,
                    phone=vm.phone,
                    password = vm.password


                };

                dal.Userlogins.Add(login);
                dal.userregisters.Add(register);
                dal.SaveChanges();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            //chage accordingly to login page followed by controller aand view page
            return Redirect("/Loginadmin/loginadmin");


            //return Redirect("/Login/login");
            //return RedirectToAction("login");
        }
    }

}
