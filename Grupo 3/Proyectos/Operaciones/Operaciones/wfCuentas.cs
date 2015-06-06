/* Autor:       Andrea Gabriela Pérez Quiacain
 * Módulo:      Operaciones
 * Formulario:  Cuentas
 * Fecha:       20/05/2015 última actualización
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class wfCuentas : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;
        public string sNomenclatura = string.Empty;

        public wfCuentas()
        {
            InitializeComponent();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoCta.Text)
            {
                case "1": cboEstadoCta.SelectedIndex = 0; break;
                case "0": cboEstadoCta.SelectedIndex = 1; break;
                default: cboEstadoCta.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoCuenta_SelectedIndexChanged(object sender, EventArgs e)
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
            alDatosEnviados.Add(txtCodigoCta);
            alDatosEnviados.Add(txtCodEmpsa);
            alDatosEnviados.Add(txtMoneda);
            alDatosEnviados.Add(txtNomencCta);
            alDatosEnviados.Add(txtPredecesor);
            alDatosEnviados.Add(txtNivelCta);
            alDatosEnviados.Add(txtNombreCta);
            alDatosEnviados.Add(txtSanteriorCta);
            alDatosEnviados.Add(txtCargoCta);
            alDatosEnviados.Add(txtAbonoCta);
            alDatosEnviados.Add(txtSactualCta);
            alDatosEnviados.Add(txtCargosAcumCta);
            alDatosEnviados.Add(txtAbonosAcumCta);
            alDatosEnviados.Add(txtDebeCta);
            alDatosEnviados.Add(txtHaberCta);
            alDatosEnviados.Add(txtPerdidaCta);
            alDatosEnviados.Add(txtGananciaCta);
            alDatosEnviados.Add(txtActivoCta);
            alDatosEnviados.Add(txtPasivoCta);
            alDatosEnviados.Add(txtEstadoCta);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            if(!Capas.csNegocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void txtCodigoCta_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodigoCta.Text;
        }

        private void txtNomencCta_TextChanged(object sender, EventArgs e)
        {
            sNomenclatura = txtNomencCta.Text;
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            txtCodEmpsa.Text = Capas.csParametros.AlEmpresa[0].ToString();
            txtMoneda.Text = Capas.csParametros.AlEmpresa[0].ToString();
            txtPredecesor.Focus();
            cboDebeCta.SelectedIndex = 0;
            cboHaberCta.SelectedIndex = 0;
            cboPerdidaCta.SelectedIndex = 0;
            cboGananciaCta.SelectedIndex = 0;
            cboActivoCta.SelectedIndex = 0;
            cboPasivoCta.SelectedIndex = 0;
            cboEstadoCta.SelectedIndex = 0;
        }

        private void txtNomencCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }

        private void txtNombreCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ 0123456789");
        }

        private void txtSactualCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }

        private void txtPredecesor_Enter(object sender, EventArgs e)
        {
            wfCuentas Cuenta = new wfCuentas();
            Cuenta.ShowDialog();
            txtPredecesor.Text = Cuenta.sNomenclatura;
            txtNomencCta.Text = Cuenta.sNomenclatura + ".";
        }

        private void cboDebeCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDebeCta.SelectedIndex == 0)
            {
                txtDebeCta.Text = "1";
                cboHaberCta.SelectedIndex = 1;
                cboPerdidaCta.SelectedIndex = 1;
                cboGananciaCta.SelectedIndex = 1;
                cboActivoCta.SelectedIndex = 1;
                cboPasivoCta.SelectedIndex = 1;
            }
        }
        
        private void cboHaberCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHaberCta.SelectedIndex == 0)
            {
                txtHaberCta.Text = "1";
                cboDebeCta.SelectedIndex = 1;
                cboPerdidaCta.SelectedIndex = 1;
                cboGananciaCta.SelectedIndex = 1;
                cboActivoCta.SelectedIndex = 1;
                cboPasivoCta.SelectedIndex = 1;
            }
        }

        private void cboPerdidaCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPerdidaCta.SelectedIndex == 0)
            {
                txtPerdidaCta.Text = "1";
                cboDebeCta.SelectedIndex = 1;
                cboHaberCta.SelectedIndex = 1;
                cboGananciaCta.SelectedIndex = 1;
                cboActivoCta.SelectedIndex = 1;
                cboPasivoCta.SelectedIndex = 1;
            }
        }

        private void cboGananciaCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGananciaCta.SelectedIndex == 0)
            {
                txtGananciaCta.Text = "1";
                cboDebeCta.SelectedIndex = 1;
                cboHaberCta.SelectedIndex = 1;
                cboPerdidaCta.SelectedIndex = 1;
                cboActivoCta.SelectedIndex = 1;
                cboPasivoCta.SelectedIndex = 1;
            }
        }

        private void cboActivoCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboActivoCta.SelectedIndex == 0)
            {
                txtActivoCta.Text = "1";
                cboDebeCta.SelectedIndex = 1;
                cboHaberCta.SelectedIndex = 1;
                cboPerdidaCta.SelectedIndex = 1;
                cboGananciaCta.SelectedIndex = 1;
                cboPasivoCta.SelectedIndex = 1;
            }
        }

        private void cboPasivoCta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPasivoCta.SelectedIndex == 0)
            {
                txtPasivoCta.Text = "1";
                cboDebeCta.SelectedIndex = 1;
                cboHaberCta.SelectedIndex = 1;
                cboPerdidaCta.SelectedIndex = 1;
                cboGananciaCta.SelectedIndex = 1;
                cboActivoCta.SelectedIndex = 1;
            }
        }

        private void txtDebeCta_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txtDebeCta.Text, "1") == 0)
            {
                cboDebeCta.SelectedIndex = 0;
                txtHaberCta.Text = "0";
                txtPerdidaCta.Text = "0";
                txtGananciaCta.Text = "0";
                txtActivoCta.Text = "0";
                txtPasivoCta.Text = "0";
            }
        }

        private void txtHaberCta_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txtHaberCta.Text, "1") == 0)
            {
                cboHaberCta.SelectedIndex = 0;
                txtDebeCta.Text = "0";
                txtPerdidaCta.Text = "0";
                txtGananciaCta.Text = "0";
                txtActivoCta.Text = "0";
                txtPasivoCta.Text = "0";
            }
        }

        private void txtPerdidaCta_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txtPerdidaCta.Text, "1") == 0)
            {
                cboPerdidaCta.SelectedIndex = 0;
                txtDebeCta.Text = "0";
                txtHaberCta.Text = "0";
                txtGananciaCta.Text = "0";
                txtActivoCta.Text = "0";
                txtPasivoCta.Text = "0";
            }
        }

        private void txtGananciaCta_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txtGananciaCta.Text, "1") == 0)
            {
                cboGananciaCta.SelectedIndex = 0;
                txtDebeCta.Text = "0";
                txtHaberCta.Text = "0";
                txtPerdidaCta.Text = "0";
                txtActivoCta.Text = "0";
                txtPasivoCta.Text = "0";
            }
        }

        private void txtActivoCta_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txtActivoCta.Text, "1") == 0)
            {
                cboActivoCta.SelectedIndex = 0;
                txtDebeCta.Text = "0";
                txtHaberCta.Text = "0";
                txtPerdidaCta.Text = "0";
                txtGananciaCta.Text = "0";
                txtPasivoCta.Text = "0";
            }
        }

        private void txtPasivoCta_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txtPasivoCta.Text, "1") == 0)
            {
                cboPasivoCta.SelectedIndex = 0;
                txtDebeCta.Text = "0";
                txtHaberCta.Text = "0";
                txtPerdidaCta.Text = "0";
                txtGananciaCta.Text = "0";
                txtActivoCta.Text = "0";
            }
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodEmpsa.Text = Capas.csParametros.AlEmpresa[0].ToString();
            txtMoneda.Text = Capas.csParametros.AlEmpresa[0].ToString();
            cboDebeCta.SelectedIndex = 0;
            cboHaberCta.SelectedIndex = 0;
            cboPerdidaCta.SelectedIndex = 0;
            cboGananciaCta.SelectedIndex = 0;
            cboActivoCta.SelectedIndex = 0;
            cboPasivoCta.SelectedIndex = 0;
            cboEstadoCta.SelectedIndex = 0;
        }

        private void txtDebeCta_EnabledChanged(object sender, EventArgs e)
        {
            cboDebeCta.Enabled = txtDebeCta.Enabled;
        }

        private void txtHaberCta_EnabledChanged(object sender, EventArgs e)
        {
            cboHaberCta.Enabled = txtHaberCta.Enabled;
        }

        private void txtPerdidaCta_DockChanged(object sender, EventArgs e)
        {
            cboPerdidaCta.Enabled = txtPerdidaCta.Enabled;
        }

        private void txtGananciaCta_EnabledChanged(object sender, EventArgs e)
        {
            cboGananciaCta.Enabled = txtGananciaCta.Enabled;
        }

        private void txtPasivoCta_EnabledChanged(object sender, EventArgs e)
        {
            cboPasivoCta.Enabled = txtPasivoCta.Enabled;
        }

        private void txtEstadoCta_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoCta.Enabled = txtEstadoCta.Enabled;
        }

        private void txtPerdidaCta_EnabledChanged(object sender, EventArgs e)
        {
            cboPerdidaCta.Enabled = txtPerdidaCta.Enabled;
        }

        private void txtActivoCta_EnabledChanged(object sender, EventArgs e)
        {
            cboActivoCta.Enabled = txtActivoCta.Enabled;
        }

        private void txtNivelCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtSanteriorCta_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e,"0123456789.");
        }

        private void txtCargoCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }

        private void txtAbonoCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }

        private void txtCargosAcumCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }

        private void txtAbonosAcumCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }


    }
}
