﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PlataformaBarberia.Models
{
    public class Usuario
    {
        public int ID { get; set; }

        public string CORREO { get; set; }

        public string CLAVE { get; set; }

        public int ID_ROL_USUARIO { get; set; }
    }
}