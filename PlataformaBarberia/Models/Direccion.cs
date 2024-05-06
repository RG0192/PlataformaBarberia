using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlataformaBarberia.Models
{
    public class Direccion
    {
        public int ID { get; set; }

        public string CALLE {  get; set; }
        public string NUMERO_EXTERIOR {  get; set; }
        public string NUMERO_INTERIOR { get; set; }
        public string CP {  get; set; }
        public int ID_LOC { get; set; }
        public string REFERENCIAS { get; set; }
            

    }
}