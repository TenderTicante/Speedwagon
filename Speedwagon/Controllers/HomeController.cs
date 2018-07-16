using Speedwagon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Speedwagon.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DatosPersonales(Datos datos)
        {
            if (ModelState.IsValid)
            {
                return View(datos);
            }
            else
            {
                return View("Index");
            }
        }
    }
}