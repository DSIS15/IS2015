using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_seguridad.Presentacion
{
    public partial class wfInicioSesion : Form
    {
        Negocio.csN_InicioSesion csn_inicio = new Negocio.csN_InicioSesion();
        public wfInicioSesion(Form wfFormulario)
        {
            if (wfFormulario != null) csn_inicio.Wfformulario = wfFormulario;

            InitializeComponent();
        }

        private void wfInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            csn_inicio.vIninicio(txtUsuario.Text, txtContraseña.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
