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
    public partial class wfUsuarios : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        string sCodigo = string.Empty;

        public wfUsuarios()
        {
            InitializeComponent();
        }

        private void wfUsuarios_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodUsr);
            alDatosEnviados.Add(txtCodPfl);
            alDatosEnviados.Add(txtNomUsr);
            alDatosEnviados.Add(txtContrasena);
            alDatosEnviados.Add(txtEstadoUsr);
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

        private void txtContrasena_EnabledChanged(object sender, EventArgs e)
        {
            txtConfContrasena.Enabled = txtContrasena.Enabled;
        }

        private void txtEstadoUsr_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoUsr.Enabled = txtEstadoUsr.Enabled;
        }

        private void txtCodUsr_EnabledChanged(object sender, EventArgs e)
        {
            txtCodUsr.Enabled = false;
        }

        private void txtEstadoUsr_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoUsr.Text)
            {
                case "0": cboEstadoUsr.SelectedIndex = 1; break;
                case "1": cboEstadoUsr.SelectedIndex = 0; break;
                default: cboEstadoUsr.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoUsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoUsr.SelectedIndex)
            {
                case 0: txtEstadoUsr.Text = "1"; break;
                case 1: txtEstadoUsr.Text = "0"; break;
                default: txtEstadoUsr.Text = string.Empty; break;
            }
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodUsr.Text = sCodigo;
            cboEstadoUsr.SelectedIndex = 0;            
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoUsr.SelectedIndex = 0;
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
            sCodigo = txtCodUsr.Text;
        }
    }
}
