using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktProv.Services
{
    public class ProductCategoryService
    {
        public SelectList GetSelectList()
        {
            SelectList selectList = new SelectList(new List<SelectListItem> {
                new SelectListItem { Text = "TV", Value = ((int)1).ToString() },
                new SelectListItem { Text = "DVD", Value = ((int)2).ToString() },
                new SelectListItem { Text = "VHS", Value = ((int)3).ToString() },
            }, "Value", "Text");

            return (selectList);
        }
    }
}
