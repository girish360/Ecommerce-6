using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Model
{
   public class BaseEntity
    {
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }


    }
}
