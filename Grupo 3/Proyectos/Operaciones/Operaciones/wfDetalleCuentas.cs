using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class wfDetalleCuentas : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public wfDetalleCuentas()
        {
            InitializeComponent();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoDcta.Text)
            {
                case "1": cboEstadoDcta.SelectedIndex = 0; break;
                case "0": cboEstadoDcta.SelectedIndex = 1; break;
                default: cboEstadoDcta.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoDcta.SelectedIndex)
            {
                case 0: txtEstadoDcta.Text = "1"; break;
                case 1: txtEstadoDcta.Text = "0"; break;
                default: txtEstadoDcta.Text = string.Empty; break;
            }
        }

        private void wfDetalleCuentas_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodigoDcta);
            alDatosEnviados.Add(txtEmpresa);
            alDatosEnviados.Add(txtMoneda);
            alDatosEnviados.Add(txtTipoCuenta);
            alDatosEnviados.Add(txtMesDcta);
            alDatosEnviados.Add(txtAnioDcta);
            alDatosEnviados.Add(txtDebeDcta);
            alDatosEnviados.Add(txtHaberDcta);
            alDatosEnviados.Add(txtPerdidaDcta);
            alDatosEnviados.Add(txtGananciaDcta);
            alDatosEnviados.Add(txtActivoDcta);
            alDatosEnviados.Add(txtPasivoDcta);
            alDatosEnviados.Add(txtEstadoDcta);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void cboMesDcta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboMesDcta.SelectedIndex)
            {
                case 0: txtMesDcta.Text = "1"; break;
                case 1: txtMesDcta.Text = "2"; break;
                case 2: txtMesDcta.Text = "3"; break;
                case 3: txtMesDcta.Text = "4"; break;
                case 4: txtMesDcta.Text = "5"; break;
                case 5: txtMesDcta.Text = "6"; break;
                case 6: txtMesDcta.Text = "7"; break;
                case 7: txtMesDcta.Text = "8"; break;
                case 8: txtMesDcta.Text = "9"; break;
                case 9: txtMesDcta.Text = "10"; break;
                case 10: txtMesDcta.Text = "11"; break;
                case 11: txtMesDcta.Text = "12"; break;
                default: txtMesDcta.Text = string.Empty; break;
            }
        }

        private void txtMesDcta_TextChanged(object sender, EventArgs e)
        {
            switch (txtMesDcta.Text)
            {
                case "1": cboMesDcta.SelectedIndex = 0; break;
                case "2": cboMesDcta.SelectedIndex = 1; break;
                case "3": cboMesDcta.SelectedIndex = 2; break;
                case "4": cboMesDcta.SelectedIndex = 3; break;
                case "5": cboMesDcta.SelectedIndex = 4; break;
                case "6": cboMesDcta.SelectedIndex = 5; break;
                case "7": cboMesDcta.SelectedIndex = 6; break;
                case "8": cboMesDcta.SelectedIndex = 7; break;
                case "9": cboMesDcta.SelectedIndex = 8; break;
                case "10": cboMesDcta.SelectedIndex = 9; break;
                case "11": cboMesDcta.SelectedIndex = 10; break;
                case "12": cboMesDcta.SelectedIndex = 11; break;
                default: cboMesDcta.SelectedIndex = -1; break;
            }
        }

        
        private void btnAgregarDcta_Click(object sender, EventArgs e)
        {
            
        }

    }
}
