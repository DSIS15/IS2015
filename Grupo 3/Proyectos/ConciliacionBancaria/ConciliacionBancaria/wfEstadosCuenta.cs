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
using Microsoft.Win32;
using System.Diagnostics;

namespace ConciliacionBancaria
{
    public partial class wfEstadosCuenta : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;
        private string sPathArchivo = string.Empty;
        private string sNombreArchivo = string.Empty;
        private string sServidor = string.Empty;
        private string sPathDestino = string.Empty;
        private string sPathDestino2 = string.Empty;

        public wfEstadosCuenta()
        {
            InitializeComponent();
        }

        private void wfEstadosCuenta_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodEstcta);
            alDatosEnviados.Add(txtCodctabco);
            alDatosEnviados.Add(txtMesEstcta);
            alDatosEnviados.Add(txtAnioEstcta);
            alDatosEnviados.Add(txtUbicEstcta);
            alDatosEnviados.Add(txtNombreEstcta);
            alDatosEnviados.Add(txtSaldoEstcta);
            alDatosEnviados.Add(txtEstadoEstcta);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            sServidor = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\ODBC\\ODBC.INI\\SCF", "SERVER", "");
        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            txtUbicEstcta.Text = sPathDestino2;
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
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtAnioEstcta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtUbicEstcta_Enter(object sender, EventArgs e)
        {
            ofdUbic.ShowDialog();
            sPathArchivo = ofdUbic.FileName.ToString();
            sNombreArchivo = ofdUbic.SafeFileName.ToString();
            sPathDestino = @"\\" + sServidor + "\\scf\\" + sNombreArchivo;
            sPathDestino2 = @"\\\\" + sServidor + "\\\\scf\\\\" + sNombreArchivo;
            txtUbicEstcta.Text = sPathArchivo;
            txtNombreEstcta.Text = sNombreArchivo;
        }

        private void txtSaldoEstcta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, ".0123456789");
        }

        private void txtCodctabco_Enter(object sender, EventArgs e)
        {
            wfCuentasBancarias CuentaBancaria = new wfCuentasBancarias();
            CuentaBancaria.ShowDialog();
            txtCodctabco.Text = CuentaBancaria.sCodigo;
        }

        private void navegador1_btnAfterGuardar(object sender, EventArgs e)
        {
            System.IO.File.Copy(sPathArchivo, sPathDestino, true);
        }

        private void txtUbicEstcta_TextChanged(object sender, EventArgs e)
        {
            if (string.Compare(txtUbicEstcta.Text, string.Empty) != 0)
            {
                VisorPDF.LoadFile(txtUbicEstcta.Text);
                VisorPDF.src = txtUbicEstcta.Text;
            }
            else
            {
                VisorPDF.LoadFile("pdf.pdf");
                VisorPDF.src = "pdf.pdf";
            }
        }

        private void wfEstadosCuenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            VisorPDF.Dispose();
        }   
    }
}