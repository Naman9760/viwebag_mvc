using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace viwebag_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.mssg1 = " That is viwebag masg";

            ViewData["masg2"] = "that is viwedata";

            ViewBag.curent = DateTime.Now.ToString();

            ViewData["curent2date"] = DateTime.Now.ToString();

            string[] cars = { "honda", "marutti", "bmw", "ford" };
            ViewBag.cars = cars;
            ViewData["car"] = cars;



            return View();
        }
    }
}