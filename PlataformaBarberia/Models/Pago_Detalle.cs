using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaBarberia.Models
{
    public class Pago_Detalle
    {
        public int PAGO_ID { get; set; }
        public int ID_SERVICIO { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal PRECIO_UNITARIO { get; set; }
        public decimal TOTAL {  get; set; }

    }
}