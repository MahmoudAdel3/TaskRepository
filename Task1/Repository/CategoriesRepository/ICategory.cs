using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Repository.CategoriesRepository
{
    public interface ICategory
    {
        IEnumerable<Category> Getall();
        void add(Category category);
        Category Get(int id);
        void Update(Category oldcategory);
        void Delete(int id);
    }
}
