using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _7_11_Slack.Controllers
{
    public class EMDController : Controller
    {
        // GET: EMD
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Biologicos()
        {
            return View();
        }
        public ActionResult Hidrologicos()
        {
            return View();
        }
        public ActionResult Metereologicos()
        {
            return View();
        }
        public ActionResult Geologicos()
        {
            return View();
        }
        public ActionResult Inudaciones()
        {
            return View();
        }
    }
}