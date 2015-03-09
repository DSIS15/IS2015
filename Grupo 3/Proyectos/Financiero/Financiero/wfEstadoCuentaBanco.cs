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

namespace Financiero
{
    public partial class wfEstadoCuentaBanco : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        string sCodigo = string.Empty;

        public wfEstadoCuentaBanco()
        {
            InitializeComponent();
        }

        private void wfEstadoCuentaBanco_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_estdocta);
            alDatosEnviados.Add(txtCod_cta);
            alDatosEnviados.Add(txtEstado_estdocta);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

        }

        private void txtCod_estdocta_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_cta.Enabled = false;
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
            sCodigo = txtCod_estdocta.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCod_estdocta.Text = sCodigo;
            txtCod_cta.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtCod_cta.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            txtCod_cta.Focus();
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
