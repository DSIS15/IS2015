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
    public partial class wfAmortizacion : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        string sCodigo = string.Empty;

        public wfAmortizacion()
        {
            InitializeComponent();
        }

        private void cboEstado_amortizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_amortizacion.SelectedIndex)
            {
                case 0: txtEstado_amortizacion.Text = "1"; break;
                case 1: txtEstado_amortizacion.Text = "0"; break;
                default: txtEstado_amortizacion.Text = string.Empty; break;
            }
        }

        private void txtEstado_amortizacion_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_amortizacion.Text)
            {
                case "1": cboEstado_amortizacion.SelectedIndex = 0; break;
                case "0": cboEstado_amortizacion.SelectedIndex = 1; break;
                default: cboEstado_amortizacion.SelectedIndex = -1; break;
            }
        }

        private void txtCod_amortizacion_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_amortizacion.Enabled = false;
        }

        private void wfAmortizacion_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_amortizacion);
            alDatosEnviados.Add(txtNom_amortizacion);
            alDatosEnviados.Add(txtValor_amortizacion);
            alDatosEnviados.Add(txtEstado_amortizacion);
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
            sCodigo = txtCod_amortizacion.Text;
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstado_amortizacion.SelectedIndex = 0;
            txtNom_amortizacion.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtNom_amortizacion.Focus();
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCod_amortizacion.Text = sCodigo;
            cboEstado_amortizacion.SelectedIndex = 0;
            txtNom_amortizacion.Focus();
        }

        private void txtNom_amortizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtValor_amortizacion_KeyPress(object sender, KeyPressEventArgs e)
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
