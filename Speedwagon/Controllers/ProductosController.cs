using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Speedwagon.Controllers
{
    public class ProductosController : Controller
    {
        public ActionResult Buscar()
        {
            string nombreProducto = RouteData.Values["nombreProducto"].ToString();
            //Se ttransforma el texto plano en html
            nombreProducto = Server.HtmlEncode(nombreProducto);
            //variable para mostrar el resultado
            String resultado = String.Empty;

            //Se evalua la variable nombre producto
            switch(nombreProducto){
                case "PC":
                    {
                        resultado = "Disponible 4 unidades";
                        break;
                    }
                case "RAM":
                    {
                        resultado = "Disponible 2 unidades";
                        break;
                    }
                default:
                    {
                        resultado = String.Format("El producto {0} no existe en stock",nombreProducto);
                        break;
                    }
            }

            //En lugarde invocar la vista Buscar, se devuelve directamente el codigo Html
            //Para ello se devuelve una invocacion al metodo content pasandole directamente como parametro
            //el texto HTML (o texto plano a renderizar) 
            return Content("<p>"+resultado+"</p>");
        }
        // GET: Productos
        public ActionResult Index()
        {
            return View();
        }
    }
}