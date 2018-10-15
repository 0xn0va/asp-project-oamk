using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using asp_project_oamk.Models;

namespace asp_project_oamk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Our awesome team consists of:";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You can reach us at:";

            return View();
        }
    }
}