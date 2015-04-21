using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConciliacionBancaria
{
    public partial class wfCuentasBancarias : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;

        public wfCuentasBancarias()
        {
            InitializeComponent();
        }

        private void wfCuentasBancarias_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodCtabco);
            alDatosEnviados.Add(txtCodEmpsa);
            alDatosEnviados.Add(txtCodMda);
            alDatosEnviados.Add(txtNumctaCtabco);
            alDatosEnviados.Add(txtNombreCtabco);
            alDatosEnviados.Add(txtBancoCtabco);
            alDatosEnviados.Add(txtSaldoCtabco);
            alDatosEnviados.Add(txtEstadoCtabco);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!navegador1.bValidarTeclasFuncion(ref msg, keyData))
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
            else
            {
                return true;
            }
        }

        private void txtCodCtabco_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodCtabco.Text;
        }

        private void txtCodCtabco_EnabledChanged(object sender, EventArgs e)
        {
            txtCodCtabco.Enabled = false;
        }

        private void txtEstadoCtabco_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoCtabco.Text)
            {
                case "0": cboEstadoCtabco.SelectedIndex = 1; break;
                case "1": cboEstadoCtabco.SelectedIndex = 0; break;
                default: cboEstadoCtabco.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoCtabco_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoCtabco.SelectedIndex)
            {
                case 0: txtEstadoCtabco.Text = "1"; break;
                case 1: txtEstadoCtabco.Text = "0"; break;
                default: txtEstadoCtabco.Text = string.Empty; break;
            }
        }

        private void txtEstadoCtabco_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoCtabco.Enabled = txtEstadoCtabco.Enabled;
        }

        private void txtNumctaCtabco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtNombreCtabco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtBancoCtabco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtSaldoCtabco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, ".0123456789");
        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            if (!Capas.csNegocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void navegador1_btnBeforeLimpiar(object sender, EventArgs e)
        {
            sCodigo = txtCodCtabco.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodCtabco.Text = sCodigo;
            cboEstadoCtabco.SelectedIndex = 0;
            txtCodEmpsa.Text = Capas.csParametros.AlEmpresa[0].ToString();
            txtCodMda.Text = Capas.csParametros.AlMoneda[0].ToString();
            txtNumctaCtabco.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoCtabco.SelectedIndex = 0;
            txtCodEmpsa.Text = Capas.csParametros.AlEmpresa[0].ToString();
            txtCodMda.Text = Capas.csParametros.AlMoneda[0].ToString();
            txtNumctaCtabco.Focus();
        }

        private void txtCodEmpsa_EnabledChanged(object sender, EventArgs e)
        {
            txtCodEmpsa.Enabled = false;
        }

        private void txtCodMda_EnabledChanged(object sender, EventArgs e)
        {
            txtCodMda.Enabled = false;
        }
    }
}
