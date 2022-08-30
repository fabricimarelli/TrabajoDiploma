using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VISTA
{
    public partial class frmGrillaSocios : Form
    {
        public frmGrillaSocios()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frmDatosSocio = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDatosSocio);

            if (frmDatosSocio != null)
            {
                //si la instancia existe la pongo en primer plano
                frmDatosSocio.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva y se muestra
            frmDatosSocio = new frmDatosSocio();
            frmDatosSocio.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frmDatosSocioM = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmDatosSocio);

            if (frmDatosSocioM != null)
            {
                //si la instancia existe la pongo en primer plano
                frmDatosSocioM.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva y se muestra
            frmDatosSocioM = new frmDatosSocio();
            frmDatosSocioM.Show();
        }
    }
}
