using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad_Producción
{
    public partial class wfEmpresa : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        private string vNom_empsa = string.Empty;

        public string VNom_empsa
        {
            get { return vNom_empsa; }
            set { vNom_empsa = value; }
        }
        public wfEmpresa()
        {
            InitializeComponent();
        }

        private void wfEmpresa_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_empsa);
            alDatosEnviados.Add(txtNom_empsa);
            alDatosEnviados.Add(txtDire_empsa);
            alDatosEnviados.Add(txtNit_empsa);
            alDatosEnviados.Add(txtEstado_empsa);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void cboEstado_empsa_TextChanged(object sender, EventArgs e)
        {
            switch (cboEstado_empsa.SelectedIndex)
            {
                case 0: txtEstado_empsa.Text = "1"; break;
                case 1: txtEstado_empsa.Text = "0"; break;
                default: txtEstado_empsa.Text = string.Empty; break;
            }
        }

        private void txtEstado_empsa_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_empsa.Text)
            {
                case "1": cboEstado_empsa.SelectedIndex = 0; break;
                case "0": cboEstado_empsa.SelectedIndex = 1; break;
                default: cboEstado_empsa.SelectedIndex = -1; break;
            }
        }

        private void txtNom_empsa_TextChanged(object sender, EventArgs e)
        {
            VNom_empsa = txtNom_empsa.Text;
        }

        private void txtNom_empsa_EnabledChanged(object sender, EventArgs e)
        {
            txtNom_empsa.Enabled = false;
        }

    }
}
