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
        string sCodigo = string.Empty;

        public wfCuentas()
        {
            InitializeComponent();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoCuenta.Text)
            {
                case "1": cboEstadoCuenta.SelectedIndex = 0; break;
                case "0": cboEstadoCuenta.SelectedIndex = 1; break;
                default: cboEstadoCuenta.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoCuenta.SelectedIndex)
            {
                case 0: txtEstadoCuenta.Text = "1"; break;
                case 1: txtEstadoCuenta.Text = "0"; break;
                default: txtEstadoCuenta.Text = string.Empty; break;
            }
        }

        private void wfCuenta_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodigo);
            alDatosEnviados.Add(txtTipoCuenta);
            alDatosEnviados.Add(txtNombre);
            alDatosEnviados.Add(txtDescripcion);
            alDatosEnviados.Add(txtEstadoCuenta);
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
            sCodigo = txtCodigo.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodigo.Text = sCodigo;
            cboEstadoCuenta.SelectedIndex = 0;
            txtTipoCuenta.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoCuenta.SelectedIndex = 0;
            txtTipoCuenta.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtTipoCuenta.Focus();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
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

    }
}
