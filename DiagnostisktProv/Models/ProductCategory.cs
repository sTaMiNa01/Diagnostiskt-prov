using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktProv.Models
{
    public class ProductCategory
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
