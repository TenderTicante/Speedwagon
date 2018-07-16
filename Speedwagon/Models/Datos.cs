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

        [Phone]
        [Display(Name = "Numero Telefonico")]
        [Required(ErrorMessage = "El siguiente datos es requerido")]
        public string numero { get; set; }
    }

    public class DatosEmail
    {
        [EmailAddress]
        [Required(ErrorMessage = "El e-mail es requerido")]
        [Display(Name = "Correo Electronico")]
        public string email { get; set; }

        [StringLength(100,ErrorMessage ="El numero de caracteres de {0} debe de ser al menos {2}.",MinimumLength = 6)]
        [Required(ErrorMessage = "El password es requerido")]
        [Display(Name = "Contraseña")]
        public string password { get; set; }

        [Display(Name = "Confirmar Contraseña")]
        [Compare("password", ErrorMessage = "La contraseña y la contraseña de confirmacion no coinciden")]
        public string ConfirmPassword { get; set; }

        
    }
}