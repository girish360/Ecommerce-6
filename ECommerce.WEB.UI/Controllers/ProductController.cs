using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.BLL.DataServices;
using ECommerce.DAL.Data.Entities;
using ECommerce.WEB.UI.Models;

namespace ECommerce.WEB.UI.Controllers
{
    public class ProductController : Controller // *
    {
        private ProductRepository productRepo;
        private CategoryRepository categoryRepo;

        public ProductController()
        {
            productRepo = new ProductRepository();
            categoryRepo = new CategoryRepository();

        }

        public IEnumerable<Category> GetAllCategories
        {
            get { return categoryRepo.GetList(); }
        }
        public ActionResult Filter()
        {


            ViewBag.Filterable = false;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Filter(ProductFilterVM model)
        {
            ViewBag.Filterable = true;
            ViewBag.FilterProduct =
                productRepo.GetList(x => x.Stock <= model.MaxStock && x.Stock >= model.MinStock &&
                                         x.UnitPrice <= model.MaxPrice && x.UnitPrice >= model.MinPrice);

            return View();
        }


        public ActionResult Index()
        {
            var model = productRepo.GetList();

            return View(model);
        }
        public ActionResult Add()
        {
            ViewBag.Categories = GetAllCategories;

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(Product model)
        {
            ViewBag.Categories = GetAllCategories;

            model.CreatedDate = DateTime.Now;
            productRepo.Insert(model);
            ViewBag.IsSuccess = productRepo.Save() > 0 ? true : false;


            return View();
        }
        protected override void Dispose(bool disposing)
        {
            productRepo.Dispose(disposing);

        }

    }
}