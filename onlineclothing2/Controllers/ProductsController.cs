using onlineclothing2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace onlineclothing2.Controllers
{
    public class ProductsController : Controller {
        private IWebHostEnvironment IWebHost;

        public ProductsController(IWebHostEnvironment _iwebhhost) {
            IWebHost = _iwebhhost;
        }
        DataContext dal = new DataContext();

        public IActionResult Product()
        {
            var dataselect = dal.pcs.ToList();
            ViewBag.data = dataselect;
            var category = dal.cat.ToList();
            ViewBag.category = category;

            select();
            return View();
        }
  
            public async Task<string> UploadImage(string folderPath, IFormFile file)
            {
                folderPath += Guid.NewGuid().ToString() + "_" + file.FileName;
                string serverFolder = Path.Combine(IWebHost.WebRootPath, folderPath);
                await file.CopyToAsync(new FileStream(serverFolder, FileMode.Create));
                return "/" + folderPath;
            }
         


    [HttpPost]
        public async Task<IActionResult> Insert(Add p,IFormFile imgpath)
        {
            string folder = "images/productimage/";
            Add obj = new Add()
            {
                id = p.id,
                name = p.name,
                category = p.category,
                status = p.status,
                Description = p.Description,
                size = p.size,
                oprice=p.oprice,
                price = p.price,
                stock = p.stock,
                imgpath = await UploadImage(folder,imgpath),
            };
            dal.pcs.Add(obj);
            dal.SaveChanges();
            TempData["Message"] = "Your product added!";
            return RedirectToAction("Product");

        }
        public IActionResult select()
        {
            var data = dal.pcs.ToList();
            ViewBag.d = data;
            return RedirectToAction("category");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var data = dal.pcs.Find(id);
            dal.pcs.Remove(data);
            dal.SaveChanges();

            return RedirectToAction("Product");
        }

        public IActionResult Update(int id)
        {
            var data = dal.pcs.Find(id);
            ViewBag.d = data;
            return View();

        }
        public IActionResult up(Add a)
        {
            Add oj = new Add() {

                id = a.id,
                name = a.name,
                category = a.category,
           
                status = a.status,
                Description = a.Description,
                size = a.size,
                price = a.price,
                stock = a.stock,
            };
            dal.pcs.Update(oj);
            dal.SaveChanges();
            return RedirectToAction("Product");
        }
    }
}
