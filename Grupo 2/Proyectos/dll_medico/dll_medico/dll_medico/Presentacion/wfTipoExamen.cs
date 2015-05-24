using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_medico.Presentacion
{
    public partial class wfTipoExamen : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfTipoExamen()
        {
            InitializeComponent();
        }

        private void wfTipoExamen_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIdTipoExamen);
            alDatosEntrada.Add(txtNombre);
            alDatosEntrada.Add(txtDescripcion);
            alDatosEntrada.Add(txtFechaCreacion);
            alDatosEntrada.Add(txtFechaModificacion);
            alDatosEntrada.Add(txtEstado);
            
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
        }

        private void dtpFechaCreacion_ValueChanged(object sender, EventArgs e)
        {
            txtFechaCreacion.Text = dtpFechaCreacion.Text;
        }

        private void txtFechaCreacion_TextChanged(object sender, EventArgs e)
        {
            dtpFechaCreacion.Text = txtFechaCreacion.Text;
        }

        private void dtpFechaModificacion_ValueChanged(object sender, EventArgs e)
        {
            txtFechaModificacion.Text = dtpFechaModificacion.Text;
        }

        private void txtFechaModificacion_TextChanged(object sender, EventArgs e)
        {
            dtpFechaModificacion.Text = txtFechaModificacion.Text;
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstado.SelectedItem.Equals("Activado"))
            {
                txtEstado.Text = "1";
            }
            else
            {
                txtEstado.Text = "0";
            }
            
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals("1"))
            {
                cboEstado.Text = "Activado";
            }
            else
            {
                cboEstado.Text = "Desactivado";
            }
        }
    }
}
