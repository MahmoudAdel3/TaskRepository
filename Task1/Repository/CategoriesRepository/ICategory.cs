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
        void add(Category cat);
        Category Get(int id);
        void Update(Category p);
        void Delete(int id);
    }
}
