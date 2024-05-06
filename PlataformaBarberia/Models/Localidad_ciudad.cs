using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaBarberia.Models
{
    public class Localidad_ciudad
    {
        public int ID {  get; set; }
        public string NOMBRE { get; set; }
        public string CP { get; set; }
        public int ID_MUNICIPIO { get; set; }
    }
}