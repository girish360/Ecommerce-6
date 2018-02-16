using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.BLL.DataServices;
using ECommerce.Common.CryptoServices;
using ECommerce.DAL.Data.Entities;

namespace ECommerce.WEB.UI.Controllers
{
    public class AppUserController : Controller
    {
        private AppUserRepository appUserRepo;

        public AppUserController()
        {
            appUserRepo = new AppUserRepository();
        }

        // GET: AppUser
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(AppUser model)
        {
            var EncypePassword = CryptoService.PasswordHash(model.PasswordHash);
            var dataBasePassword = appUserRepo.FirstOrDefault(x => x.ID == 4).PasswordHash;
            if (EncypePassword == dataBasePassword)
            {
                // kullanıcı şifreyi değiştirebilir
            }
            appUserRepo.Insert(model);
            ViewBag.IsSuccess = appUserRepo.Save() > 0 ? true : false;

            return View();
        }

        protected override void Dispose(bool disposing)
        {
            appUserRepo.Dispose(disposing);

        }

    }
}