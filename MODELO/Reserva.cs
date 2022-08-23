﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Reserva
    {
        #region PROPIEDADES
        public int ID_reserva { get; set; }
        public PilotoAlumno piloto { get; set; }//piloto o usuario que realiza la reserva 
        public Aeronave aeronave { get; set; }//lista con las aeronaves disponibles
        public DateTime desde { get; set; }
        public DateTime hasta { get; set; }
        public string finalidad { get; set; }//si es para instruccion, travesia, navegacion
        #endregion

        #region METODOS
        #endregion
    }
}
