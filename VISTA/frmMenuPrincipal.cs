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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }


        private void btnSocios_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frmGrillaSocios = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmGrillaSocios);

            if (frmGrillaSocios != null)
            {
                //si la instancia existe la pongo en primer plano
                frmGrillaSocios.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva y se muestra
            frmGrillaSocios = new frmGrillaSocios();
            frmGrillaSocios.Show();

        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            //se localiza el formulario buscandolo entre los forms abiertos 
            Form frmGrillaReservas = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmGrillaReservas);

            if (frmGrillaReservas != null)
            {
                //si la instancia existe la pongo en primer plano
                frmGrillaReservas.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva y se muestra
            frmGrillaReservas = new frmGrillaReservas();
            frmGrillaReservas.Show();
        }
    }
}
