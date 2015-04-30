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
    public partial class wfCuentas : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;
        public string sNomenclatura = string.Empty;
        public string sNombre = string.Empty;

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
            alDatosEnviados.Add(txtCodigoClf);
            alDatosEnviados.Add(txtNombreCta);
            alDatosEnviados.Add(txtNomencCta);
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

        private void txtNombreCta_TextChanged(object sender, EventArgs e)
        {
            sNombre = txtNombreCta.Text;
        }

        private void txtCodigoClf_Enter(object sender, EventArgs e)
        {
            wfClasificacion ClasificacionCuenta = new wfClasificacion();
            ClasificacionCuenta.ShowDialog();
            txtCodigoClf.Text = ClasificacionCuenta.sCodigo;
        }        
    }
}
