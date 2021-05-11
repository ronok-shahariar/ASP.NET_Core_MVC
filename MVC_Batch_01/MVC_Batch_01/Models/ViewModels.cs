using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Batch_01.Models
{
    public class ViewModels
    {
        public virtual  Order Order { get; set; }
        public virtual  IEnumerable<Order> Orders { get; set; }

        public virtual OrderItem OrderItem { get; set; }
        public virtual IEnumerable<OrderItem> OrderItems { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual IEnumerable<Customer> Customers { get; set; }

        public virtual Product Product { get; set; }
        public virtual IEnumerable<Product> Products { get; set; }
    }
}
