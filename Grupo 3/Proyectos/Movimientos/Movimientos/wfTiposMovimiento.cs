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

namespace Movimientos
{
    public partial class wfTipoDeMovimiento : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;

        public wfTipoDeMovimiento()
        {
            InitializeComponent();
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
            sCodigo = txtCodTmov.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodTmov.Text = sCodigo;
            txtNombreTmov.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            txtNombreTmov.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtNombreTmov.Focus();
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

        private void txtCodTmov_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodTmov.Text;
        }

        private void txtEstadoTmov_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoTmov.Text)
            {
                case "0": cboEstadoTmov.SelectedIndex = 1; break;
                case "1": cboEstadoTmov.SelectedIndex = 0; break;
                default: cboEstadoTmov.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoTmov_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoTmov.SelectedIndex)
            {
                case 0: txtEstadoTmov.Text = "1"; break;
                case 1: txtEstadoTmov.Text = "0"; break;
                default: txtEstadoTmov.Text = string.Empty; break;
            }
        }

        private void txtEstadoTmov_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoTmov.Enabled = txtEstadoTmov.Enabled;
        }

        private void txtNombreTmov_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtDescripTmov_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void wfTipoDeMovimiento_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodTmov);
            alDatosEnviados.Add(txtNombreTmov);
            alDatosEnviados.Add(txtDescripTmov);
            alDatosEnviados.Add(txtEstadoTmov);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }
    }
}
