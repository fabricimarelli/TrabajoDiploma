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
        public byte[] fotoPersona { get; set; }

    }   

    public class Socio : Persona
    {
        public int ID_socio { get; set; }
        public DateTime fechaAdmision { get; set; }
        public bool deudor { get; set; }//revisar

    }

    public class Piloto : Socio
    {
        public Licencia licencia { get; set; }
        public decimal horasVoladas { get; set; }
        public string claseCMA { get; set; }
        public DateTime vencimientoCMA { get; set; }

    }

    public class Alumno : Socio
    {
        public Curso curso { get; set; }
        //public decimal horasVoladas { get; set; } Estan en el curso
        public string claseCMA { get; set; }
        public DateTime vencimientoCMA { get; set; }
        
    }
}
