using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.BLL.BaseServices;
using ECommerce.DAL.Data.Entities;

namespace ECommerce.Common.CategoryServices
{
    public interface ICategoryService
    {
        void InsertCategory(Category category);
        int Save();

    }
}
