using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Models;

namespace Task1.Products
{
    public interface Iproduct
    {
         IEnumerable<product> Getall();
         product Get(int id);
         void Delete(int id);
         void Update(product oldproduct);
         void Add(product product);

    }
}
