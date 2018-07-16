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

        public ActionResult DatosPersonales(DatosEmail datos)
        {
            if (ModelState.IsValid)
            {
                String email = datos.email;
                String password = datos.password;

                if (email == "tenderticante@gmail.com" && password=="1234")
                {
                    return View();
                }
                else
                {
                    return View("Index");
                }
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult MostrarDatos(Datos datos)
        {
            if (ModelState.IsValid)
            {
                return View(datos);
            }
            else
            {
                return View("DatosPersonales");
            }
        }
    }
}