using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Batch_01.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [ForeignKey("Category")]        //one to many relationship
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }

        [DataType(DataType.MultilineText)]
        public string ProductDetails { get; set; }
        public string ProductImage { get; set; }
        public bool isActive { get; set; }

        //relationship
        public virtual Category Category { get; set; }

    }
}
