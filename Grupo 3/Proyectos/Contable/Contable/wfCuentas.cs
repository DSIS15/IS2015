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
    public partial class wfCuentas : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;

        public wfCuentas()
        {
            InitializeComponent();
        }

        private void txtEstadoCta_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoCta.Text)
            {
                case "1": cboEstadoCta.SelectedIndex = 0; break;
                case "0": cboEstadoCta.SelectedIndex = 1; break;
                default: cboEstadoCta.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoCta_SelectedIndexChanged(object sender, EventArgs e)
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
            alDatosEnviados.Add(txtCodCta);
            alDatosEnviados.Add(txtCodTCta);
            alDatosEnviados.Add(txtCuentaCta);
            alDatosEnviados.Add(txtDescripCta);
            alDatosEnviados.Add(txtEstadoCta);
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
            sCodigo = txtCodCta.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodCta.Text = sCodigo;
            cboEstadoCta.SelectedIndex = 0;
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoCta.SelectedIndex = 0;
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtCuentaCta.Focus();
        }

        private void txtCodTCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtDescrip_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
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

        private void txtCodCta_EnabledChanged(object sender, EventArgs e)
        {
            txtCodCta.Enabled = false;
        }

        private void txtEstadoCta_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoCta.Enabled = txtEstadoCta.Enabled;
        }

        private void txtCodCta_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodCta.Text;
        }
    }
}
