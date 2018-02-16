using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Model
{
   public abstract class Entity<T>:BaseEntity,IEntityKey<T>
    {
        public T ID { get; set; }
    }
}
