using Microsoft.AspNetCore.Mvc;
using onlineclothing2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace onlineclothing2.Controllers
{
    public class Westernclothes : Controller
    {
        DataContext dal = new DataContext();
        public IActionResult Westernwear(string category)

        {
            //var dataselect = dal.pcs.ToList();
            //var finaldata = from x in dataselect where x.scategory == "Western wear"
            //                select x;
            //ViewBag.wwdata = finaldata;
            //return View();
           

            var westerewear = dal.pcs.Where(x => x.category.Contains(category)).ToList();
            
            ViewBag.data = westerewear;

            return View();
        }

        //public IActionResult Ethnicwear()

        //{
        //    //var dataselect = dal.pcs.ToList();
        //    //var finaldata = from x in dataselect where x.scategory == "Western wear"
        //    //                select x;
        //    //ViewBag.wwdata = finaldata;
        //    //return View();

        //    var westerewear = dal.pcs.Where(x => x.category.Contains("Ethnicwear")).ToList();

        //    ViewBag.data = westerewear;


        //    return View();
      //  }
    }
}
