using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iceParodi.Models
{
    public class TipoReunion
    {
        public string IdReu
        {
            get;
            set;
        }

        public string Nombre
        {
            get;
            set;
        }
    }
}