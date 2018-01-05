using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using Microsoft.Practices.Unity.InterceptionExtension;
using System.ComponentModel;
namespace Task1
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [DisplayName("Category Name")]
        public String Name { get; set; }
        public ICollection<product> Products { get; set; }
    }
}
