using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PrabhjotBooks.Models.ViewModels
{
    public class ProductVM
    {
        public Product Product { get; set; }
        public string Category { get; set; } 
        public string CoverType { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> CoverTypeList { get; set; }
    }
}
