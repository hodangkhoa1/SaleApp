using System;
using System.Collections.Generic;

#nullable disable

namespace ProductManagement.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public DateTime? PayTime { get; set; }
        public double? Amount { get; set; }
        public string PayType { get; set; }
    }
}
