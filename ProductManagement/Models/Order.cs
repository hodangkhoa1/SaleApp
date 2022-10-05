using System;
using System.Collections.Generic;

#nullable disable

namespace ProductManagement.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string OrderAddress { get; set; }
        public double? Price { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
