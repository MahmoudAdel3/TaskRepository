using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;
using Task1.Products;
using Task1.Repository.CategoriesRepository;

namespace Task1.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private Iproduct product;
        private ICategory category;

        public ProductController(Iproduct ProductRepository,ICategory CategoryRepository)
        {
            this.product = ProductRepository;
            this.category = CategoryRepository;
        }

        public ActionResult index()
        {
            return View(product.Getall());
        }
        public ActionResult Add()
        {

            ProductViewModel pvm = new ProductViewModel();
            pvm.Category = category.Getall();
            return View(pvm);
        }

        [HttpPost]
        public ActionResult Add(product Product)
        {
            if (ModelState.IsValid)
            {
                product.Add(Product);
                return RedirectToAction("index","Product");
            }
            return View();
        }

        
        public ActionResult Details(int id)
        {
            return View(product.Get(id));
        }

        
        public ActionResult Delete(int id)
        {
            product.Delete(id);
            return RedirectToAction("index");
        }

        
        public ActionResult Update(int id)
        {
            return View(product.Get(id));
        }
        
        [HttpPost]
        public ActionResult Update(product oldproduct)
        {
            product.Update(oldproduct);
            return RedirectToAction("index");
        }
	}
}