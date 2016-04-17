using MVC_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "CandleStore description page.";
            TempData["value"] = "Testing of Tempdata";
            ViewData["value"] = "CandleStore Temp Data";

            //candlestore db1 = new candlestore();
            return View();
           // return View("../Candles/Index", db1.Candle.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}