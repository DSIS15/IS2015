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
    public partial class wfTipoDeMovimiento : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        string sCodigo = string.Empty;

        public wfTipoDeMovimiento()
        {
            InitializeComponent();
        }

        private void wfTiposDeOperaciones_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_op);
            alDatosEnviados.Add(txtNom_op);
            alDatosEnviados.Add(txtEstado_op);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

        }

        private void txtCod_op_EnabledChanged(object sender, EventArgs e)
        {
            txtCod_op.Enabled = false;
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
            sCodigo = txtCod_op.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCod_op.Text = sCodigo;
            txtNom_op.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            txtNom_op.Focus();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtNom_op.Focus();
        }

        private void txtNom_op_KeyPress(object sender, KeyPressEventArgs e)
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
