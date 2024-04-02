using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tamrin2.Models
{
    public class Orders
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customers? Customer { get; set; }
        public decimal TotalAmount { get; set; }
        public ICollection<OrderItems?> OrderItems { get; set; }
    }
}