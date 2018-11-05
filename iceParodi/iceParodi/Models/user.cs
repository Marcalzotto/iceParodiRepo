using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//permite agregar etiquetas de validacion para datos de formulario
using System.Linq;
using System.Web;

namespace iceParodi.Models
{
    public class User
    {
        private string _Nombre;
        private string _Pass;
        private int _Rol;

        [Required(ErrorMessage = "Por favor introduce el nombre")]
        [MinLength(8, ErrorMessage = "El nombre debe tener 8 caracteres como minimo")]
        [MaxLength(20, ErrorMessage = "El nombre debe tener 20 caracteres como maximo")]
        public string Nombre {
            get {return _Nombre;}
            set {_Nombre = value;}
        }
        

        [Required(ErrorMessage = "Por favor introduce el password")]
        [MinLength(10,ErrorMessage = "El password debe tener 10 caracteres como minimo")]
        [MaxLength(20,ErrorMessage = "El password debe tener 20 caracteres como maximo")]
        public string Pass{
            get { return _Pass; }
            set { _Pass = value; }
        }

        [Required(ErrorMessage = "Por favor introduce el rol")]
        //[Range(1,3 ,ErrorMessage = "El rol introducido no es correcto")]
        public int Rol {
            get { return _Rol; }
            set { _Rol = value;}
        }
    }
}