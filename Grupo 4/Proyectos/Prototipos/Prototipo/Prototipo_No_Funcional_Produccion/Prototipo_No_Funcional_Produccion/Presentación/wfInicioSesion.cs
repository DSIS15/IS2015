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
    public partial class wfInicioSesion : Form
    {
        public wfInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIniciosesion_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text != "") && (txtPass.Text != ""))
            {
                
                if(Seguridad_Producción.csValidaciones.Validar_Usuario(txtUser.Text, txtPass.Text)== 1)
                {
                    wfMenuPrincipal MenuPrincipal = new wfMenuPrincipal();
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                    MenuPrincipal.Show(this);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña invalida", "Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

        
    
}
