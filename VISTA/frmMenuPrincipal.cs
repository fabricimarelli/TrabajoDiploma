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


        private void button1_Click(object sender, EventArgs e)
        {

            //se localiza el formulario buscandolo entre los forms abiertos 
            Form formularioSocios = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmSocios);

            if (formularioSocios != null)
            {
                //si la instancia existe la pongo en primer plano
                formularioSocios.BringToFront();
                return;
            }

            //sino existe la instancia se crea una nueva y se muestra
            formularioSocios = new frmSocios();
            formularioSocios.Show();

        }
    }
}
