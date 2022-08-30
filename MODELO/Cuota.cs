using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Cuota
    {
        #region PROPIEDADES
        public Socio socio { get; set; }
        public int ID_cuota { get; set; }
        public DateTime cuotaDesde { get; set; }
        public DateTime cuotaHasta { get; set; }
        public decimal valorCuota { get; set; }
        public decimal total { get; set; }
        #endregion
       
        #region METODOS
        #endregion

    }
}
