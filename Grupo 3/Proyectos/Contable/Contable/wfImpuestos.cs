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
    public partial class wfImpuesto : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        string sCodigo = string.Empty;

        public wfImpuesto()
        {
            InitializeComponent();
        }

        private void cboEstado_imp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado_imp.SelectedIndex)
            {
                case 0: txtEstado_imp.Text = "1"; break;
                case 1: txtEstado_imp.Text = "0"; break;
                default: txtEstado_imp.Text = string.Empty; break;
            }
        }

        private void txtEstado_imp_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado_imp.Text)
            {
                case "1": cboEstado_imp.SelectedIndex = 0; break;
                case "0": cboEstado_imp.SelectedIndex = 1; break;
                default: cboEstado_imp.SelectedIndex = -1; break;
            }
        }

        private void txtCod_imp_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_imp.Enabled = false;
        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            if (!Capas.csNegocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void wfImpuesto_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_imp);
            alDatosEnviados.Add(txtNom_imp);
            alDatosEnviados.Add(txtValor_imp);
            alDatosEnviados.Add(txtEstado_imp);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

        }

        private void navegador1_btnBeforeLimpiar(object sender, EventArgs e) 
        {
            sCodigo = txtCod_imp.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCod_imp.Text = sCodigo;
            cboEstado_imp.SelectedIndex = 0;
            txtNom_imp.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstado_imp.SelectedIndex = 0;
            txtNom_imp.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtNom_imp.Focus();
        }

        private void txtNom_imp_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtValor_imp_KeyPress(object sender, KeyPressEventArgs e)
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
