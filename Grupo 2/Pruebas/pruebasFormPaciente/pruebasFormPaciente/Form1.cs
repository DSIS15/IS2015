using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dll_paciente;
using dll_medico;
namespace pruebasFormPaciente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dll_paciente.Presentacion.wfPaciente FormularioPaciente= new dll_paciente.Presentacion.wfPaciente();
            FormularioPaciente.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dll_medico.wfMedico FormularioMedico = new dll_medico.wfMedico();
            FormularioMedico.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dll_paciente.Presentacion.wfEnfermedadesAnt FormularioEnfermedades = new dll_paciente.Presentacion.wfEnfermedadesAnt();
            FormularioEnfermedades.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dll_paciente.Presentacion.wfAntecedentesM FormularioAntecedentesM = new dll_paciente.Presentacion.wfAntecedentesM();
            FormularioAntecedentesM.Show();
        } 
    }
}
