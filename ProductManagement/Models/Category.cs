using System;
using System.Collections.Generic;

#nullable disable

namespace ProductManagement.Models
{
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
