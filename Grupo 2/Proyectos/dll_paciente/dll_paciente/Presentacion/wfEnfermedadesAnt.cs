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

namespace dll_paciente.Presentacion
{
    public partial class wfEnfermedadesAnt : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfEnfermedadesAnt()
        {
            InitializeComponent();
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEstado.SelectedItem.Equals("Activado"))
            {
                txtestado.Text = "1";
            }
            else
            {
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

        private void wfEnfermedadesAnt_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtidenfermedad);
            alDatosEntrada.Add(txtnomenfer);
            alDatosEntrada.Add(txtestado);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtidenfermedad.Enabled = false;
        }
    }
}
