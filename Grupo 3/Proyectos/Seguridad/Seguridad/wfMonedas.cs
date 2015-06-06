using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seguridad
{
    public partial class wfMonedas : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;

        public wfMonedas()
        {
            InitializeComponent();
        }

        private void wfMoneda_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodMda);
            alDatosEnviados.Add(txtMonedaMda);
            alDatosEnviados.Add(txtAbrevMda);
            alDatosEnviados.Add(txtTipoCambioMda);
            alDatosEnviados.Add(txtEstadoMda);
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

        private void txtCodMda_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodMda.Text;
        }

        private void txtCodMda_EnabledChanged(object sender, EventArgs e)
        {
            txtCodMda.Enabled = false;
        }

        private void txtEstadoMda_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoMda.Enabled = txtCodMda.Enabled;
        }

        private void txtEstadoMda_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoMda.Text)
            {
                case "0": cboEstadoMda.SelectedIndex = 1; break;
                case "1": cboEstadoMda.SelectedIndex = 0; break;
                default: cboEstadoMda.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoMda_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoMda.SelectedIndex)
            {
                case 0: txtEstadoMda.Text = "1"; break;
                case 1: txtEstadoMda.Text = "0"; break;
                default: txtEstadoMda.Text = string.Empty; break;
            }
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
            sCodigo = txtCodMda.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodMda.Text = sCodigo;
            cboEstadoMda.SelectedIndex = 0;
            txtMonedaMda.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtMonedaMda.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoMda.SelectedIndex = 0;
            txtMonedaMda.Focus();
        }

        private void txtMonedaMda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtAbrevMda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtTipoCambioMda_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, ".0123456789");
        }
    }
}
