using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktProv.Models
{
    public class Product
    {
        public Guid ProductID { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(5,1000)]
        public Decimal Price { get; set; }
    }
}
