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
            switch (cboEstadoAmort.SelectedIndex)
            {
                case 0: txtEstadoAmort.Text = "1"; break;
                case 1: txtEstadoAmort.Text = "0"; break;
                default: txtEstadoAmort.Text = string.Empty; break;
            }
        }

        private void txtEstado_amortizacion_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoAmort.Text)
            {
                case "1": cboEstadoAmort.SelectedIndex = 0; break;
                case "0": cboEstadoAmort.SelectedIndex = 1; break;
                default: cboEstadoAmort.SelectedIndex = -1; break;
            }
        }

        private void txtCod_amortizacion_EnabledChanged(object sender, EventArgs e)
        {
            txtCodAmort.Enabled = false;
        }

        private void wfAmortizacion_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodAmort);
            alDatosEnviados.Add(txtAmort);
            alDatosEnviados.Add(txtValorAmort);
            alDatosEnviados.Add(txtEstadoAmort);
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
            sCodigo = txtCodAmort.Text;
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoAmort.SelectedIndex = 0;
            txtAmort.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtAmort.Focus();
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodAmort.Text = sCodigo;
            cboEstadoAmort.SelectedIndex = 0;
            txtAmort.Focus();
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
