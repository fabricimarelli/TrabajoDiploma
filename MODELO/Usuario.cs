﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Usuario
    {
        public int ID_usuario { get; set; }
        public string nombreUsuario { get; set; }
        public string password { get; set; }
        public Persona perosna { get; set; }
    }
}
