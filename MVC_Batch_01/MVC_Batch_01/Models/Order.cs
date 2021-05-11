using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Batch_01.Models
{
    public enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Cancelled,
    }
    public class Order
    {
        public Order()
        {
            this.OrderItems = new HashSet<OrderItem>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        [ForeignKey("Customer")]
        [Display(Name = "Customer Name")]
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
