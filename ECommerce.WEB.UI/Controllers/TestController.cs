using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ECommerce.Common.DateServices;

namespace ECommerce.WEB.UI.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            ViewBag.date = DateService.GetDateInfoTurkishLongDateFormat(DateTime.Now);
            return View();
        }

    }
}