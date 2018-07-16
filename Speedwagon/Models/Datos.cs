using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Speedwagon.Models
{
    public class Datos
    {
        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public string apellido { get; set; }

        [Required(ErrorMessage = "El siguiente dato es requerido")]
        public string edad { get; set; }
    }
}