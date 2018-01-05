using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Models;
using Task1.Products;
using Task1.Repository;
using Task1.Repository.CategoriesRepository;
namespace Task1.Controllers
{
    [System.Runtime.InteropServices.GuidAttribute("388411CC-D390-41F0-BCDF-7FC53A2DBB12")]
    public class HomeController : Controller
    {
       private Iproduct product;
     
       
        public HomeController(Iproduct Repository)
        {
            this.product = Repository;
            
        }
        public ActionResult index()
        {
            return View(product.Getall());
        }
        
       
    }
}