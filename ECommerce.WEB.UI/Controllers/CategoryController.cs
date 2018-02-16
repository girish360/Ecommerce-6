using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECommerce.BLL.DataServices;
using ECommerce.Common.CategoryServices;
using ECommerce.DAL.Data.Entities;

namespace ECommerce.WEB.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {

            _categoryService = categoryService;

        }

        public ActionResult Index()
        {
            //Genellikle filtreleme işlemleriiçin kullanılır
            //IQueryable<Category> query = categoryRepo.GetListQueryable();

            //var Clist = query.Where(x => x.CategoryName.StartsWith("g")).ToList();

            //// 2. Örnek =  2 tane tabloyu birleştirdi
            //var productCategory = productRepo.GetListQueryable().Select(a => new {Product = a, Category = a.Category})
            //    .ToList();
            //string value = query.ToString();

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Category category)
        {


            _categoryService.InsertCategory(category);

            ViewBag.IsSuccess = _categoryService.Save() > 0 ? true : false;

            return View();
        }

        public ActionResult Delete()
        {
            //ViewBag.Categories = categoryRepo.GetList();
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int id)
        {
            //categoryRepo.Delete(id);
            //categoryRepo.Save();
            return View();


        }
        protected override void Dispose(bool disposing)
        {
            //categoryRepo.Dispose(disposing);

        }
       
    }
}