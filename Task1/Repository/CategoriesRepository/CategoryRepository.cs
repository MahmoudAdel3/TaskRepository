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
        public void add(Category category)
        {
            db.Category.Add(category);
            db.SaveChanges();

        }
        public Category Get(int id)
        {
            return (db.Category.Find(id));
        }

        public void Update(Category oldcategory)
        {
            var category = db.Category.Find(oldcategory.ID);
            category.Name = oldcategory.Name;
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