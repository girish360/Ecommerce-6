using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.Model
{
    public abstract class AuditableEntity<T> : BaseEntity, IEntityKey<T>, IAuditable // baseEntity miras , Ientitykey and IAunditable implement dir 
    {
        public T ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
