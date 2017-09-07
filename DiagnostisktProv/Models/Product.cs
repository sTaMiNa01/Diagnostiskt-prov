using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktProv.Models
{
    public class Product
    {
        public Guid ProductID { get; set; }
        public string Name { get; set; }
        public Decimal Price { get; set; }
    }
}
