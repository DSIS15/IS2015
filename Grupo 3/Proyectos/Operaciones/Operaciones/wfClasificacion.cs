using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class wfClasificacion : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;
        public wfClasificacion()
        {
            InitializeComponent();
        }

        private void wfClasificacion_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodigoClf);
            alDatosEnviados.Add(txtNombreClf);
            alDatosEnviados.Add(txtNomencClf);
            alDatosEnviados.Add(txtDescripClf);
            alDatosEnviados.Add(txtEstadoClf);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void cboEstadoClf_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboEstadoClf.SelectedIndex)
            {
                case 0: txtEstadoClf.Text = "1"; break;
                case 1: txtEstadoClf.Text = "0"; break;
                default: txtEstadoClf.Text = string.Empty; break;
            }
        }

        private void txtEstadoClf_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoClf.Text)
            {
                case "1": cboEstadoClf.SelectedIndex = 0; break;
                case "0": cboEstadoClf.SelectedIndex = 1; break;
                default: cboEstadoClf.SelectedIndex = -1; break;
            }
        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            if (!Capas.csNegocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void txtCodigoClf_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodigoClf.Text;
        }
    }
}
