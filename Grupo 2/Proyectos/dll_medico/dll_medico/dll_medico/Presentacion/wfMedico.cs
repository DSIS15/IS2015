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
    public partial class wfMedico : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfMedico()
        {
            InitializeComponent();
        }

        private void wfMedico_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIdMedico);
            alDatosEntrada.Add(txtNombre);
            alDatosEntrada.Add(txtPrimerApellido);
            alDatosEntrada.Add(txtSegundoApellido);
            alDatosEntrada.Add(txtFechaIngreso);
            alDatosEntrada.Add(txtEstado);
           
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();

        }

        private void dtpFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            txtFechaIngreso.Text = dtpFechaIngreso.Text;
        }

        private void txtFechaIngreso_TextChanged(object sender, EventArgs e)
        {
            dtpFechaIngreso.Text = txtFechaIngreso.Text;
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
