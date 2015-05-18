using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_citamedica.Presentacion
{
    public partial class wfTipoExamen : Form
    {
        ArrayList alDatosEntrada = new ArrayList();
        public wfTipoExamen()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtFechaCreacion.Text = dtFechaCreacion.Text;
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

        private void txtFechaCreacion_TextChanged(object sender, EventArgs e)
        {
            dtFechaCreacion.Text = txtFechaCreacion.Text;
        }

        private void dtFechaModificacion_ValueChanged(object sender, EventArgs e)
        {
            txtFechaModificacion.Text = dtFechaModificacion.Text;
        }

        private void txtFechaModificacion_TextChanged(object sender, EventArgs e)
        {
            dtFechaModificacion.Text = txtFechaModificacion.Text;
        }

        private void wfTipoExamen_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIdTipoExamen);
            alDatosEntrada.Add(txtEstado);
            alDatosEntrada.Add(txtNombre);
            alDatosEntrada.Add(txtDescripcion);
            alDatosEntrada.Add(txtFechaCreacion);
            alDatosEntrada.Add(txtFechaModificacion);

            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
        }
    }
}
