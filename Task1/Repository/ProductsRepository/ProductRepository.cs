using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task1.Models;

namespace Task1.Products
{
    public class ProductRepository:Iproduct
    {
        private DefaultConnection db = new DefaultConnection();

        public IEnumerable<product> Getall()
        {
            return ((from p in db.Product select new { ID = p.ID, Name = p.Name, Price = p.Price, Category = p.Category }).ToList().
                Select(x => new product { ID = x.ID, Name = x.Name, Price = x.Price, Category = x.Category }).ToList()); 
                
        }

        public product Get(int id)
        {
            return (db.Product.Find(id));
        }

        public void Delete(int id)
        {
            var product = db.Product.Find(id);
            if(product!=null)
            {
                db.Product.Remove(product);
                db.SaveChanges();
            }

        }

        public void Update(product oldproduct)
        {
            var product=db.Product.Find(oldproduct.ID);
            product.Name = oldproduct.Name;
            product.Price = oldproduct.Price;
           
            db.SaveChanges();
        }

        public void Add(product product)
        {
            db.Product.Add(product);
            db.SaveChanges();
        }
    }
}