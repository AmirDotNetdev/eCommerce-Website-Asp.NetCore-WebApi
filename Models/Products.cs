using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tamrin2.Models
{
    public class Products
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int SupplierId { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsDiscontinued { get; set; }
    }
}