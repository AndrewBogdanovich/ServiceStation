using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult IndexRepairs()
        {
            return View();
        }
        public ActionResult Repairs1()
        {
            return View();
        }
        public ActionResult Repairs2()
        {
            return View();
        }
        public ActionResult Repairs3()
        {
            return View();
        }
        public ActionResult Repairs4()
        {
            return View();
        }
        public ActionResult Repairs5()
        {
            return View();
        }
        public ActionResult Repairs6()
        {
            return View();
        }
    }
}