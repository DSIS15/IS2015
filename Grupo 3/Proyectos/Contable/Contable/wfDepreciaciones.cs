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
    public partial class wfDepreciacion : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        string sCodigo = string.Empty;

        public wfDepreciacion()
        {
            InitializeComponent();
        }

        private void cboEstado_depreciacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_depreciacion.SelectedIndex)
            {
                case 0: txtEstado_depreciacion.Text = "1"; break;
                case 1: txtEstado_depreciacion.Text = "0"; break;
                default: txtEstado_depreciacion.Text = string.Empty; break;
            }
        }

        private void txtEstado_depreciacion_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_depreciacion.Text)
            {
                case "1": cboEstado_depreciacion.SelectedIndex = 0; break;
                case "0": cboEstado_depreciacion.SelectedIndex = 1; break;
                default: cboEstado_depreciacion.SelectedIndex = -1; break;
            }
        }

        private void txtCod_depreciacion_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_depreciacion.Enabled = false;
        }

        private void wfDepreciacion_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_depreciacion);
            alDatosEnviados.Add(txtNom_depreciacion);
            alDatosEnviados.Add(txtValor_depreciacion);
            alDatosEnviados.Add(txtEstado_depreciacion);
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
            sCodigo = txtCod_depreciacion.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCod_depreciacion.Text = sCodigo;
            cboEstado_depreciacion.SelectedIndex = 0;
            txtNom_depreciacion.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstado_depreciacion.SelectedIndex = 0;
            txtNom_depreciacion.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtNom_depreciacion.Focus();
        }

        private void txtNom_depreciacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtValor_depreciacion_KeyPress(object sender, KeyPressEventArgs e)
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
