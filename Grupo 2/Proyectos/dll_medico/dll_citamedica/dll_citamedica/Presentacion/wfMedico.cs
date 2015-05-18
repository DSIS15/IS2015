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
            alDatosEntrada.Add(txtNombreMedico);
            alDatosEntrada.Add(txtPrimerApMedico);
            alDatosEntrada.Add(txtSegundoApMedico);
            alDatosEntrada.Add(txtFechaIngreso);
            alDatosEntrada.Add(txtEstadoMedico);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
        }

        private void cboEstadoMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cboEstadoMedico.SelectedItem.Equals("Activado"))
           {
               txtEstadoMedico.Text = "1";
           }
           else
           {
           txtEstadoMedico.Text ="0";
           }
        }

        private void txtEstadoMedico_TextChanged(object sender, EventArgs e)
        {
            if (txtEstadoMedico.Text.Equals("1"))
            {
                cboEstadoMedico.Text = "Activado";
            }
            else
            {
                cboEstadoMedico.Text = "Desactivado";
            }
        }

        private void dtFechaIngreso_ValueChanged(object sender, EventArgs e)
        {
            txtFechaIngreso.Text = dtFechaIngreso.Text;
        }

        private void txtFechaIngreso_TextChanged(object sender, EventArgs e)
        {
            dtFechaIngreso.Text = txtFechaIngreso.Text;
        }
    }
}
