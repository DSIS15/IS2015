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
            alDatosEntrada.Add(txtEstatura);
            alDatosEntrada.Add(txtpeso);
            alDatosEntrada.Add(txtsangre);
            alDatosEntrada.Add(txtidentificacion);
            alDatosEntrada.Add(txtfecha);
            alDatosEntrada.Add(txtestado);
            navegador1.alDatosEntrada=alDatosEntrada;
            navegador1.vIniciarNavegador();
        }

        private void cbSangre_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtsangre.Text = cbSangre.Text;
        }

        private void txtsangre_TextChanged(object sender, EventArgs e)
        {
           cbSangre.Text  = txtsangre.Text;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedItem.Equals("Activado"))
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
                cbEstado.Text = "Activado";
            }
            else
            {
                cbEstado.Text = "Desactivado";
            }
            
        }
    }
}
