using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ECommerce.Common.StringServices;


namespace ECommerce.WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string urlr)
        {
            //WebRequest SiteyeBaglantiTalebi = HttpWebRequest.Create("http://www.gencayyildiz.com");
            //WebResponse GelenCevap = SiteyeBaglantiTalebi.GetResponse();
            //StreamReader CevapOku = new StreamReader(GelenCevap.GetResponseStream());
            //string KaynakKodlar = CevapOku.ReadToEnd();
            //int IcerikBaslangicIndex = KaynakKodlar.IndexOf("<h6>") + 4;
            //int IcerikBitisIndex = KaynakKodlar.Substring(IcerikBaslangicIndex).IndexOf("</h6>");
            //Console.WriteLine(KaynakKodlar.Substring(IcerikBaslangicIndex, IcerikBitisIndex));
            //Console.Read();
            //ViewBag.sadad = KaynakKodlar;

            ViewBag.Cap = StringService.Capitalize("tolga kurtarmış");
             return View();
        }
        public string BilgiCek(string url)
        {

            WebRequest istek = HttpWebRequest.Create("http://www.gencayyildiz.com");
            WebResponse cevap = istek.GetResponse();
            StreamReader donenBilgiler = new StreamReader(cevap.GetResponseStream());
            return donenBilgiler.ReadToEnd();
        }
    }
}