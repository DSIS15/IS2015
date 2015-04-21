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

namespace Operaciones
{
    public partial class wfTipoCuenta : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;

        public wfTipoCuenta()
        {
            InitializeComponent();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoTcta.Text)
            {
                case "1": cboEstadoTcta.SelectedIndex = 0; break;
                case "0": cboEstadoTcta.SelectedIndex = 1; break;
                default: cboEstadoTcta.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoTipoC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoTcta.SelectedIndex)
            {
                case 0: txtEstadoTcta.Text = "1"; break;
                case 1: txtEstadoTcta.Text = "0"; break;
                default: txtEstadoTcta.Text = string.Empty; break;
            }
        }

        private void wfTipoCuenta_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodTcta);
            alDatosEnviados.Add(txtNombreTcta);
            alDatosEnviados.Add(txtDescripTcta);
            alDatosEnviados.Add(txtEstadoTcta);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            //navegador1.vIniciarNavegador();
        }

        private void txtCodTcta_EnabledChanged(object sender, EventArgs e)
        {
            txtCodTcta.Enabled = false;
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
            sCodigo = txtCodTcta.Text;
            txtNombreTcta.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoTcta.SelectedIndex = 0;
            txtNombreTcta.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtNombreTcta.Focus();
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodTcta.Text = sCodigo;
            cboEstadoTcta.SelectedIndex = 0;
            txtNombreTcta.Focus();
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

        private void txtCodTcta_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodTcta.Text;
        }

        private void txtEstadoTcta_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoTcta.Enabled = txtEstadoTcta.Enabled;
        }

    }
}
