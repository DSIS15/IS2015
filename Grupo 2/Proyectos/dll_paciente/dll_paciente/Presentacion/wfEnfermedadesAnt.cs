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
            switch(cbEstado.SelectedIndex)
            {
                case 0: txtestado.Text = "1";
                    break;
                case 1: txtestado.Text = "0";
                    break;
                default:
                    break;
            }
        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {
            switch (txtestado.Text)
            {
                case "1": cbEstado.SelectedIndex = 0;
                    break;
                case "2": cbEstado.SelectedIndex = 1;
                    break;
                default: cbEstado.SelectedIndex = -1;
                    break;
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
    }
}
