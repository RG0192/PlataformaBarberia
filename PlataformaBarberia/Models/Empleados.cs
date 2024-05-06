using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaBarberia.Models
{
    public class Empleados
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO_PATERNO { get; set; }

        public string APELLIDO_MATERNO { get; set; }
        public string TELEFONO { get; set; }
        public string RFC { get; set; }
        public string NSS { get; set; }
        public string REGIMEN { get; set; }
        public int DIRECCION { get; set; }

    }
}