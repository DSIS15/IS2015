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
    public partial class wfCuentas : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public wfCuentas()
        {
            InitializeComponent();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoCta.Text)
            {
                case "1": cboEstadoCta.SelectedIndex = 0; break;
                case "0": cboEstadoCta.SelectedIndex = 1; break;
                default: cboEstadoCta.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoCta.SelectedIndex)
            {
                case 0: txtEstadoCta.Text = "1"; break;
                case 1: txtEstadoCta.Text = "0"; break;
                default: txtEstadoCta.Text = string.Empty; break;
            }
        }

        private void wfCuenta_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodigoCta);
            alDatosEnviados.Add(txtTipoCuenta);
            alDatosEnviados.Add(txtCuentaCta);
            alDatosEnviados.Add(txtDescripcionCta);
            alDatosEnviados.Add(txtEstadoCta);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void txtTipoCuenta_Enter(object sender, EventArgs e)
        {
            wfTipoCuenta TipoCuenta = new wfTipoCuenta();
            TipoCuenta.ShowDialog();
        }

        
    }
}
