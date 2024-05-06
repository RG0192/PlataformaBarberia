using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaBarberia.Models
{
    public class Pagos
    {
        public int ID { get; set; }
        public int ID_CLIENTE { get; set; }
        public string TIPO_DE_PAGO { get; set; }
        public DateTime FECHA_DE_PAGO { get; set; }
        public int ID_CITA { get; set; }
        public decimal PAGO {  get; set; }

    }
}