
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Task1
{
    public class DefaultConnection : DbContext
    {
       
        public DbSet<product> Product{ get; set; }
        public DbSet<Category> Category { get; set; }

        public System.Data.Entity.DbSet<Task1.Models.ProductViewModel> ProductViewModels { get; set; }
    }
}