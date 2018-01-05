using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Repository.CategoriesRepository;

namespace Task1.Controllers
{
    [Authorize]
    public class CategoryController : Controller
    {
        private ICategory category;

        public CategoryController(ICategory c)
        {
            
            this.category = c;
        }

        
        public ActionResult index()
        {
            return View(category.Getall());
        }

        
        public ActionResult addcategory()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addcategory(Category cat)
        {
            category.add(cat);
            return RedirectToAction("all_categories");
        }

        public ActionResult Details(int id)
        {
            return View(category.Get(id));
        }
        public ActionResult Update(int id)
        {
            return View(category.Get(id));
        }
        
        [HttpPost]
        public ActionResult Update(Category Category)
        {
            category.Update(Category);
            return RedirectToAction("index");
        }

        public ActionResult delete(int id)
        {
            category.Delete(id);
            return RedirectToAction("index");
        }



	}
}