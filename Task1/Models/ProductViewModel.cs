using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Task1.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            Category = new List<Category>();
        }
        public int ID { get; set; } 
        [Required]
        public String Name { get; set; }
        [Required]
        public int Price { get; set; }
        [DisplayName("Category")]
        public int CategoryID { get; set; }
        public Category cat { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}