using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Speedwagon.Models;

namespace Speedwagon.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Persona()
        {
            //Se instancia la clase Persona
            Persona persona1 = new Persona();
            persona1.nombre = Request.Form["nombre"].ToString();
            persona1.apellido = Request.Form["apellido"].ToString();
            persona1.edad = Convert.ToInt32(Request.Form["edad"]);

            return View(persona1);
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}