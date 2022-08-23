using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class Vuelo
    {
        #region PROPIEDADES
        Aeronave aeronave { get; set; }
        PilotoAlumno piloto { get; set; }
        //int ID_socio (me lo trae automaticamente cunado selecciono el piloto?)?????
        int ID_vuelo { get; set; }
        int nroFactura { get; set; }
        DateTime fechaHoraSalida { get; set; }
        DateTime fechaHoraLlegada { get; set; }
        decimal taquimSalida { get; set; }
        decimal taquimLlegada { get; set; }
        decimal tiempo { get; set; }//metodo que lo calcule a partir del taquimetro salida/llegada
        string desdeLugar { get; set; }
        string hastaLugar { get; set; }
        int aterrizajes { get; set; }
        string finalidad { get; set; }
        bool diurno { get; set; }
        bool nocturno { get; set; }//metodo que lo autocomplete calculando las horas de salida/llegada
        decimal tarifa { get; set; }//metodo que calcule la tarifa a partir del costo de hora de vuelo (tarifaHora-clase Aeronave) y tiempo volado
        string observaciones { get; set; }
        #endregion

        #region METODOS
        #endregion

    }

    public class Instruccion : Vuelo
    {
        #region PROPIEDADES
        PilotoAlumno alumno { get; set; }
        
        //ID_SocioAlum
        

        //agregar metodo nuevo para calular tarifa (sumar costo de instruccion)
        #endregion

        #region METODOS
        #endregion
    }


}
