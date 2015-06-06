using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Seguridad
{
    public partial class wfODBC : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        private string sPath = "HKEY_CURRENT_USER\\Software\\ODBC\\ODBC.INI\\SCF";

        public wfODBC()
        {
            InitializeComponent();
        }

        private void wfODBC_Load(object sender, EventArgs e)
        {
            txtBaseDatos.Text = (string)Registry.GetValue(sPath, "DATABASE", "");
            txtDriver.Text = (string)Registry.GetValue(sPath, "Driver", "");
            txtServidor.Text = (string)Registry.GetValue(sPath, "SERVER", "");
            txtPuerto.Text = (string)Registry.GetValue(sPath, "PORT", "");
            txtUsuario.Text = (string)Registry.GetValue(sPath, "UID", "");
            txtContrasena.Text = (string)Registry.GetValue(sPath, "PWD", "");
        }   

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Capas.csNegocio.bValidarTextBoxes(alDatosEnviados))
            {
                Registry.SetValue(sPath, "DATABASE", txtBaseDatos.Text);
                Registry.SetValue(sPath, "Driver", txtDriver.Text);
                Registry.SetValue(sPath, "SERVER", txtServidor.Text);
                Registry.SetValue(sPath, "PORT", txtPuerto.Text);
                Registry.SetValue(sPath, "UID", txtUsuario.Text);
                if (string.Compare(txtContrasena.Text, string.Empty) != 0)
                {
                    Registry.SetValue(sPath, "PWD", txtContrasena.Text);
                }
            }
            MessageBox.Show("Configuración actualizada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDriver_Enter(object sender, EventArgs e)
        {   
            ofdFolder.ShowDialog();
            if (string.Compare(ofdFolder.FileName.ToString(), string.Empty) != 0)
            {
                txtDriver.Text = ofdFolder.FileName.ToString();
            }
        }             
    }
}
