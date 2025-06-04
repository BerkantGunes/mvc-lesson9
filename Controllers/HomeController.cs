using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ornek3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            int sayi = Convert.ToInt32(form["sayi1"]);
            int sayi2 = Convert.ToInt32(form["sayi2"]);

            int toplam = sayi + sayi2;
            ViewBag.Toplam = toplam;
            return View();
        }
    }
}