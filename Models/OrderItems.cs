using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tamrin2.Models
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

    }
}