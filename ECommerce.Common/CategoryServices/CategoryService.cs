using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.BLL.BaseServices;
using ECommerce.DAL.Data.Entities;

namespace ECommerce.Common.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> _categoryRepo;


        public CategoryService(IRepository<Category> categoryRepo)
        {
            this._categoryRepo = categoryRepo;


        }

        public virtual void InsertCategory(Category category)
        {
            category.IsActive = true;
            category.IsDelete = false;

            _categoryRepo.Insert(category);
            _categoryRepo.Save();
        }

        public int Save()
        {
            return _categoryRepo.Save();

        }
    }


}
