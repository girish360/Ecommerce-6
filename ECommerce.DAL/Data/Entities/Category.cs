using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.DAL.Model;

namespace ECommerce.DAL.Data.Entities
{
   public class Category:Entity<int>
    {
        public string CategoryName { get; set; }
        public string Description { get; set; } // açıklama
        public string ImagePath { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}
