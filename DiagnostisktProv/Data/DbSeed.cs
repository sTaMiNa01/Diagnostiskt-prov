using DiagnostisktProv.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktProv.Data
{
    public class DbSeed
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.ProductCategories.Any())
            {
                var TV = new ProductCategory();
                TV.CategoryID = 1;
                TV.Name = "TV";

                var DVD = new ProductCategory();
                TV.CategoryID = 2;
                TV.Name = "DVD";

                var VHS = new ProductCategory();
                TV.CategoryID = 3;
                TV.Name = "VHS";

                context.AddRange(TV, DVD, VHS);
                context.SaveChanges();
            }

        }
    }
}
