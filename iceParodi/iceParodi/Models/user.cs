using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//permite agregar etiquetas de validacion para datos de formulario
using System.Linq;
using System.Web;

namespace iceParodi.Models
{
    public class User
    {   
        [Required(ErrorMessage = "Por favor introduce el nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Por favor introduce el password")]
        public string Pass { get; set; }

        [Required(ErrorMessage = "Por favor introduce el rol")]
        public int Rol { get; set; }
    }
}