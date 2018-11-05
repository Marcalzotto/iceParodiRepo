using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace iceParodi.Models
{
    public class Mensaje
    {

        private string _NombreOrador;
        private string _ApellidoOrador;
        private string _TituloMensaje;
        private DateTime _Fecha;
        private string _EnlaceChirbit;

        [Required(ErrorMessage = "Por favor ingresa el nombre del orador")]
        [MinLength(6,ErrorMessage = "El nombre debe contener como minimo 6 caracteres")]
        [MaxLength(15,ErrorMessage = "El apellido debe contener como maximo 15 caracteres")]
        [RegularExpression("([^a-zA-z])", ErrorMessage = "El nombre solo puede contener letras")]
        public string NombreOrador {
            get { return _NombreOrador; }
            set { _NombreOrador = value; }
        }

        [Required(ErrorMessage = "Por favor ingresa el apellido del orador")]
        public string ApellidoOrador {
            get { return _ApellidoOrador; }
            set { _ApellidoOrador = value; }
        }

        [Required(ErrorMessage = "Por favor ingresa el titulo del mensaje")]
        public string TituloMensaje {
            get { return _TituloMensaje; }
            set { _TituloMensaje = value; }
        }

        [Required(ErrorMessage = "Por favor ingresa fecha del mensaje")]
        public DateTime Fecha {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        
        [Required(ErrorMessage = "Por favor elige el tipo de Reunion")]
        public int ReunionElegida { get; set; }
        public System.Web.Mvc.SelectList Reuniones { get; set; }

        [Required(ErrorMessage = "Por favor introduce el enlace")]
        public string EnlaceChirbit {
            get { return _EnlaceChirbit; }
            set { _EnlaceChirbit = value; }
        }

    }
  
}