using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _7_11_Slack;
using _7_11_Slack.Models;

namespace _7_11_Slack.Controllers
{
    public class HomeController : Controller
    {
        private sl_baseEntities db = new sl_baseEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string usuarioi, string clavei)
        {
            var usuario = (from a in db.Usuarios where a.correo == usuarioi && a.clave == clavei select a.IdUsuario).FirstOrDefault();

            var datos = Convert.ToInt32(usuario);

            if (datos >= 1)
            {
                return RedirectToAction("Index", "Categorias");
            }

            return View();
        }

        public ActionResult Vista()
        {
            return View();
        }
    }
}