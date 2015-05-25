using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_paciente.Presentacion
{
    public partial class wfPaciente : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfPaciente()
        {
            InitializeComponent();
        }

        private void wfPaciente_Load(object sender, EventArgs e)
        {
       
            alDatosEntrada.Add(txtIDP);
            alDatosEntrada.Add(txtNom);
            alDatosEntrada.Add(txtprimerAp);
            alDatosEntrada.Add(txtSegundoApe);
            alDatosEntrada.Add(txtdireccion);
            alDatosEntrada.Add(txttel);            
            alDatosEntrada.Add(txtSexo);
            alDatosEntrada.Add(txtidentificacion);
            alDatosEntrada.Add(txtFecha);
            alDatosEntrada.Add(txtestado);
            navegador1.alDatosEntrada=alDatosEntrada;
            navegador1.vIniciarNavegador();
        }

        private void cbSangre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSexo.Text = cbSexo.Text;
        }

        private void txtsangre_TextChanged(object sender, EventArgs e)
        {
           cbSexo.Text  = txtSexo.Text;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstado.SelectedItem.Equals("Activado"))
            {
                txtestado.Text = "1";
            }
            else {
                txtestado.Text = "0";
            }
            
        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {
            if (txtestado.Text.Equals("1"))
            {
                cboEstado.Text = "Activado";
            }
            else
            {
                cboEstado.Text = "Desactivado";
            }
            
        }

        private void dtpfecha_ValueChanged(object sender, EventArgs e)
        {
            txtFecha.Text = dtpfecha.Text;
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            dtpfecha.Text = txtFecha.Text;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtIDP.Enabled = false;
        }
    }
}
