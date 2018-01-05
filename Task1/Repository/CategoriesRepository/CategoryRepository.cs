using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Task1.Repository.CategoriesRepository;

namespace Task1.Repository
{
    public class CategoryRepository:ICategory
    {
        private DefaultConnection db = new DefaultConnection();
        public IEnumerable<Category> Getall()
        {
            return (db.Category.ToList());

        }
        public void add(Category cat)
        {
            db.Category.Add(cat);
            db.SaveChanges();

        }
        public Category Get(int id)
        {
            return (db.Category.Find(id));
        }

        public void Update(Category p)
        {
            var category = db.Category.Find(p.ID);
            category.Name = p.Name;
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var Category = db.Category.Find(id);
            if (Category != null)
            {
                db.Category.Remove(Category);
                db.SaveChanges();
            }
        }
    }
}