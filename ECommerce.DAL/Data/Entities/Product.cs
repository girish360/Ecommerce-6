using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DAL.Model;

namespace ECommerce.DAL.Data.Entities
{
   public  class Product:AuditableEntity<long>
    {
        public string ProductName { get; set; }
        public short Stock { get; set; }
        public decimal UnitPrice { get; set; }
        public int IsDisCountinued { get; set; } // biten bir ürün mü , devamı var mı

        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
