using System;
using System.Data.Entity;
using System.Linq;

namespace CONTEXTO
{
    public class Aeroclub : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'Aeroclub' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'CONTEXTO.Aeroclub' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'Aeroclub'  en el archivo de configuración de la aplicación.
        public static Aeroclub instancia;
        public static Aeroclub Obtener_Instnacia()
        {
            if(instancia == null)
            {
                instancia = new Aeroclub();
            }
            return instancia;
        }
        
        public Aeroclub()
            : base("name=Aeroclub")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<MODELO.Socio> Socios { get; set; }
        public virtual DbSet<MODELO.Aeronave> Aeronaves { get; set; }
        public virtual DbSet<MODELO.Reserva> Reservas { get; set; }
        public virtual DbSet<MODELO.Cuota> Cuotas { get; set; } 
        public virtual DbSet<MODELO.Curso> Cursos { get; set; }
        public virtual DbSet<MODELO.Licencia> Licencias { get; set; }
        public virtual DbSet<MODELO.Usuario> Usuarios { get; set; }
        public virtual DbSet<MODELO.Vuelo> Vuelos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MODELO.Socio>()
                .HasKey(c => c.ID_socio);
            modelBuilder.Entity<MODELO.Aeronave>()
                .HasKey(c => c.ID_aeronave);
            modelBuilder.Entity<MODELO.Reserva>()
                .HasKey(c => c.ID_reserva);
            modelBuilder.Entity<MODELO.Cuota>()
                .HasKey(c => c.ID_cuota);
            modelBuilder.Entity<MODELO.Curso>()
                .HasKey(c => c.ID_curso);
            modelBuilder.Entity<MODELO.Licencia>()
                .HasKey(c => c.ID_Licencia);
            modelBuilder.Entity<MODELO.Usuario>()
                .HasKey(c => c.ID_usuario);
            modelBuilder.Entity<MODELO.Vuelo>()
                .HasKey(c => c.ID_vuelo);
        }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}