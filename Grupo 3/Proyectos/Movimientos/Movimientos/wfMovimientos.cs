using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Movimientos
{
    public partial class wfMovimientos : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;

        public wfMovimientos()
        {
            InitializeComponent();
        }

        private void wfMovimientos_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodMov);
            alDatosEnviados.Add(txtCod_Emp);
            alDatosEnviados.Add(txtCod_Mon);
            alDatosEnviados.Add(txtCodTmov);
            alDatosEnviados.Add(txtCodCtabco);
            alDatosEnviados.Add(txtFechmovMov);
            alDatosEnviados.Add(txtCorrelativoMov);
            alDatosEnviados.Add(txtDescripMov);
            alDatosEnviados.Add(txtDebitoMov);
            alDatosEnviados.Add(txtCreditoMov);
            alDatosEnviados.Add(txtEstadoMov);
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

        private void txtCodMov_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodMov.Text;
        }

        private void txtCodMov_EnabledChanged(object sender, EventArgs e)
        {
            txtCodMov.Enabled = false;
        }

        private void txtEstadoMov_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoMov.Text)
            {
                case "0": cboEstadoMov.SelectedIndex = 1; break;
                case "1": cboEstadoMov.SelectedIndex = 0; break;
                default: cboEstadoMov.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoMov_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoMov.SelectedIndex)
            {
                case 0: txtEstadoMov.Text = "1"; break;
                case 1: txtEstadoMov.Text = "0"; break;
                default: txtEstadoMov.Text = string.Empty; break;
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
            sCodigo = txtCodMov.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodMov.Text = sCodigo;
            cboEstadoMov.SelectedIndex = 0;
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoMov.SelectedIndex = 0;                  
        }

        private void txtEstadoMov_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoMov.Enabled = txtEstadoMov.Enabled;
        }

        private void txtFechmovMov_TextChanged(object sender, EventArgs e)
        {
            dtpFechMov.Text = txtFechmovMov.Text;
        }
           

        private void txtCodTmov_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtCodCtabco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void dtpFechmovMov_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "-: 0123456789");
        }

        private void txtCorrelativoMov_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtDescripMov_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtDebitoMov_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, ".0123456789");
        }

        private void txtCreditoMov_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, ".0123456789");
        }

        private void navegador1_btnAfterGuardar(object sender, EventArgs e)
        {
            //POLIZAS
        }

        private void dtpFechMov_ValueChanged(object sender, EventArgs e)
        {
            txtFechmovMov.Text = dtpFechMov.Text;
        }      

        private void txtFechmovMov_EnabledChanged(object sender, EventArgs e)
        {
            dtpFechMov.Enabled = txtFechmovMov.Enabled;
        }

        private void txtCod_Emp_Enter(object sender, EventArgs e)
        {
            Seguridad.wfEmpresas Empresa = new Seguridad.wfEmpresas();
            Empresa.ShowDialog();
            txtCod_Emp.Text = Empresa.sCodigo;

        }

        private void txtCod_Mon_Enter(object sender, EventArgs e)
        {
            Seguridad.wfEmpresas Moneda = new Seguridad.wfEmpresas();
            Moneda.ShowDialog();
            txtCod_Mon.Text = Moneda.sCodigo;
        }

        private void txtCodTmov_Enter(object sender, EventArgs e)
        {
            wfTipoDeMovimiento TipoMov = new wfTipoDeMovimiento();
            TipoMov.ShowDialog();
            txtCodTmov.Text = TipoMov.sCodigo;
        }

        private void txtCodCtabco_Enter(object sender, EventArgs e)
        {
            ConciliacionBancaria.wfCuentasBancarias Cuenta = new ConciliacionBancaria.wfCuentasBancarias();
            Cuenta.ShowDialog();
            txtCodCtabco.Text = Cuenta.sCodigo;
        }       
    }
}
