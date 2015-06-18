using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Produccion_EnterpriseSolution
{
    public partial class wfUsuario : Form
    {
        wfMenuPrincipal wfm = new wfMenuPrincipal();
        private static int opb;
        public wfUsuario(int permiso)
        {
            InitializeComponent();
            opb = permiso;
        }

        private void wfUsuario_Load(object sender, EventArgs e)
        {
            h();
        }

        public void h()
        {

            //MessageBox.Show(" " + opb);
            switch (opb)
            {

                case 2:
                    {

                        navegador1.btnEliminar.Enabled = false;
                        navegador1.btnModificar.Enabled = false;

                    } break;
                case 3:
                    {
                        navegador1.btnNuevo.Enabled = false;
                        navegador1.btnEliminar.Enabled = false;
                        navegador1.btnModificar.Enabled = false;
                    } break;
                case 4:
                    {
                        navegador1.btnEliminar.Enabled = false;
                        navegador1.btnModificar.Enabled = false;
                    } break;


            }

        }


    }////
}
