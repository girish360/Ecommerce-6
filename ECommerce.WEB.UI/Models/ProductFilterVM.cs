using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerce.WEB.UI.Models
{
    public class ProductFilterVM
    {
        public decimal MaxPrice { get; set; }
        public decimal MinPrice { get; set; }
        public short MaxStock { get; set; }
        public short MinStock { get; set; }

    }
}