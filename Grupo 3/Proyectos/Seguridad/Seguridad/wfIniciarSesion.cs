using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad
{
    public partial class wfIniciarSesion : Form
    {
        BindingSource bsEmpresas = new BindingSource();
        BindingSource bsMonedas = new BindingSource();
        DataTable dtEmpresas = new DataTable();
        DataTable dtMonedas = new DataTable();
        csNegocio Negocio = new csNegocio();
        private Form wfMenuPrincipal = new Form();
        
        public wfIniciarSesion(Form wfMenu)
        {
            wfMenuPrincipal = wfMenu;
            InitializeComponent();
        }

        private void wfIniciarSesion_Load(object sender, EventArgs e)
        {
            tmrRelojEntrada.Start();
        }

        private void tmrRelojEntrada_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.25;
            if (this.Opacity == 1)
            {
                tmrRelojEntrada.Stop();
            }
        }

        private void tmrRelojSalida_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.25;
            if (this.Opacity == 0)
            {
                tmrRelojSalida.Stop();
                Application.Exit();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                btnIniciarSesion_Click(this, e);
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Negocio.bValidarCredenciales(txtUsuario.Text, txtPassword.Text))
            {
                Capas.csParametros.vObtenerPrivelegios();
                this.Hide();
                wfMenuPrincipal.Show();                
            }
            else
            {
                txtUsuario.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            tmrRelojSalida.Start();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789");
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789");
        }

        private void btnConfigBaseDatos_Click(object sender, EventArgs e)
        {
            if (Negocio.bValidarCredenciales(txtUsuario.Text, txtPassword.Text))
            {
                if (string.Compare(Capas.csParametros.AlUsuario[3].ToString(), "Administrador") == 0)
                {
                    wfODBC ODBC = new wfODBC();
                    ODBC.ShowDialog();
                    txtUsuario.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                    txtUsuario.Focus();
                }
            }
        }
    }
}
