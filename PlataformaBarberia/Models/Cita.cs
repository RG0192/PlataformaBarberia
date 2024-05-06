using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaBarberia.Models
{
    public class Cita
    {
        public int ID { get; set; }
        public DateTime FECHA { get; set; }
        public DateTime HORA { get; set; }
        public int ID_CLIENTE { get; set; }
        public string DESCRIPCION { get; set; }
        public string CITA_ESTADO { get; set; }
    }
}