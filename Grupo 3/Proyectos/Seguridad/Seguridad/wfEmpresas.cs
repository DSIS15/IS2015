using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad
{
    public partial class wfEmpresas : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;

        public wfEmpresas()
        {
            InitializeComponent();
        }

        private void wfEmpresa_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodEmpsa);
            alDatosEnviados.Add(txtRazsocial);
            alDatosEnviados.Add(txtNomcomercial_empsa);
            alDatosEnviados.Add(txtDire);
            alDatosEnviados.Add(txtNit_empsa);
            alDatosEnviados.Add(txtEstadoEmpsa);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
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

        private void txtCodEmpsa_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodEmpsa.Text;
        }

        private void txtCodEmpsa_EnabledChanged(object sender, EventArgs e)
        {
            txtCodEmpsa.Enabled = false;
        }

        private void txtEstadoEmpsa_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoEmpsa.Text)
            {
                case "0": cboEstado.SelectedIndex = 1; break;
                case "1": cboEstado.SelectedIndex = 0; break;
                default: cboEstado.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoEmpsa_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstado.SelectedIndex)
            {
                case 0: txtEstadoEmpsa.Text = "1"; break;
                case 1: txtEstadoEmpsa.Text = "0"; break;
                default: txtEstadoEmpsa.Text = string.Empty; break;
            }
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
            sCodigo = txtCodEmpsa.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodEmpsa.Text = sCodigo;
            cboEstado.SelectedIndex = 0;
            txtRazsocial.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstado.SelectedIndex = 0;
            txtRazsocial.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtRazsocial.Focus();
        }

        private void txtRazsocial_empsa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtNomcomercial_empsa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtDire_empsa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtNit_empsa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtEstadoEmpsa_EnabledChanged(object sender, EventArgs e)
        {
            cboEstado.Enabled = txtEstadoEmpsa.Enabled;
        }
    }
}
