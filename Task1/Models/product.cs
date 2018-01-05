using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace Task1
{
    public class product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        
        public String Name { get; set; }
        [Required]
        public int Price { get; set; }
        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
