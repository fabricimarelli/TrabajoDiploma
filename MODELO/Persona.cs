using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public abstract class Persona
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int DNI { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string domicilio { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
    }

    //SocioPileta

    public class Socio : Persona
    {
        public int ID_socio { get; set; }
        public DateTime fechaAdmision { get; set; }
        public bool deudor { get; set; }
        public DateTime vencimientoCMA { get; set; }

    }

    public class Piloto : Socio
    {
        public string licencia { get; set; }
        public bool instructor { get; set; }
    }

    public class Alumno : Socio
    {
        //tipo de curso que esta realizando sacado de la lista cursos
        public decimal horasVoladas { get; set; }
    }
}
