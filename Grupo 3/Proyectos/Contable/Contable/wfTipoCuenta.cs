using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contable
{
    public partial class wfTipoCuenta : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        string sCodigo = string.Empty;

        public wfTipoCuenta()
        {
            InitializeComponent();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoTipoC.Text)
            {
                case "1": cboEstadoTipoC.SelectedIndex = 0; break;
                case "0": cboEstadoTipoC.SelectedIndex = 1; break;
                default: cboEstadoTipoC.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoTipoC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoTipoC.SelectedIndex)
            {
                case 0: txtEstadoTipoC.Text = "1"; break;
                case 1: txtEstadoTipoC.Text = "0"; break;
                default: txtEstadoTipoC.Text = string.Empty; break;
            }
        }

        private void wfTipoCuenta_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodigo_tcuenta);
            alDatosEnviados.Add(txtNombre);
            alDatosEnviados.Add(txtDescripcion);
            alDatosEnviados.Add(cboEstadoTipoC);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

        }

        private void wfTipoCuenta_EnabledChanged(object sender, EventArgs e)
        {
            txtCodigo_tcuenta.Enabled = false;
        }

        private void txtCodigo_EnabledChanged(object sender, EventArgs e)
        {
            txtCodigo_tcuenta.Enabled = false;
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
            sCodigo = txtCodigo_tcuenta.Text;
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoTipoC.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodigo_tcuenta.Text = sCodigo;
            cboEstadoTipoC.SelectedIndex = 0;
            txtNombre.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, ".0123456789");
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

    }
}
