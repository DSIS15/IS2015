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

namespace Financiero
{
    public partial class wfEstadoCuentaBanco : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;

        public wfEstadoCuentaBanco()
        {
            InitializeComponent();
        }

        private void wfEstadoCuentaBanco_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodEstcta);
            alDatosEnviados.Add(txtCodctabco);
            alDatosEnviados.Add(txtMesEstcta);
            alDatosEnviados.Add(txtAnioEstcta);
            alDatosEnviados.Add(txtUbicEstcta);
            alDatosEnviados.Add(txtEstadoEstcta);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
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
            sCodigo = txtCodEstcta.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodEstcta.Text = sCodigo;
            cboEstadoEstcta.SelectedIndex = 0;
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoEstcta.SelectedIndex = 0;
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

        private void txtCodEstcta_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodEstcta.Text;
        }

        private void txtCodEstcta_EnabledChanged(object sender, EventArgs e)
        {
            txtCodEstcta.Enabled = false;
        }

        private void txtEstadoEstcta_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoEstcta.Text)
            {
                case "0": cboEstadoEstcta.SelectedIndex = 1; break;
                case "1": cboEstadoEstcta.SelectedIndex = 0; break;
                default: cboEstadoEstcta.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoEstcta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoEstcta.SelectedIndex)
            {
                case 0: txtEstadoEstcta.Text = "1"; break;
                case 1: txtEstadoEstcta.Text = "0"; break;
                default: txtEstadoEstcta.Text = string.Empty; break;
            }
        }

        private void txtEstadoEstcta_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoEstcta.Enabled = txtEstadoEstcta.Enabled;
        }

        private void txtCodctabco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtMesEstcta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtAnioEstcta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtUbicEstcta_Enter(object sender, EventArgs e)
        {
            ofdUbic.ShowDialog();
            txtUbicEstcta.Text = ofdUbic.FileName.ToString();
        }
    }
}
