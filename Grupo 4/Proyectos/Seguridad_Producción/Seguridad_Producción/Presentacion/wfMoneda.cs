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
    public partial class wfMoneda : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        private string vMoneda_mda = string.Empty;

        public string VMoneda_mda
        {
            get { return vMoneda_mda; }
            set { vMoneda_mda = value; }
        }
        public wfMoneda()
        {
            InitializeComponent();
        }

        private void wfMoneda_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_mda);
            alDatosEnviados.Add(txtMoneda_mda);
            alDatosEnviados.Add(txtAbrev_mda);
            alDatosEnviados.Add(txtCambio_mda);
            alDatosEnviados.Add(txtEstado_mda);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void txtEstado_mda_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_mda.Text)
            {
                case "1": cboEstado_mda.SelectedIndex = 0; break;
                case "0": cboEstado_mda.SelectedIndex = 1; break;
                default: cboEstado_mda.SelectedIndex = -1; break;
            }
        }

        private void cboEstado_mda_TextChanged(object sender, EventArgs e)
        {
            switch (cboEstado_mda.SelectedIndex)
            {
                case 0: txtEstado_mda.Text = "1"; break;
                case 1: txtEstado_mda.Text = "0"; break;
                default: txtEstado_mda.Text = string.Empty; break;
            }
        }

        
        private void txtMoneda_mda_TextChanged(object sender, EventArgs e)
        {
            VMoneda_mda = txtMoneda_mda.Text;
            
        }
    }
}
