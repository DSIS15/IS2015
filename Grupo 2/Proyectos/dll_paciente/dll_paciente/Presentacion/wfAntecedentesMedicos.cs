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

namespace dll_paciente
{
    public partial class wfAntecedentesMedicos : Form
    {
        ArrayList alDatosEntrada = new ArrayList();
        public wfAntecedentesMedicos()
        {
            InitializeComponent();
        }

        private void wfAntecedentesMedicos_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtidantecedente);
            alDatosEntrada.Add(txtidpaciente);
            alDatosEntrada.Add(txtidenfermedad);
            alDatosEntrada.Add(txtdescripcion);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();

            ///////////////////////////////////////
            //Datos Grid Modulo
            String[,] Scaden ={
                              {"id_pacientes","Codigo","true"},
                              {"nombre_paciente","Nombre","true"},
                              {"primer_apellido","Apellido","true"},
                              {"segundo_apellido","Segundo apellido","false"},
                              {"direccion_paciente","Direccion","true"},
                              {"telefono_paciente","Telefono","true"},
                              {"sexo","Sexo","true"},
                              {"identificacion_paciente","Identificacion","true"}, 
                              {"fecha_nacimiento_paciente","Fecha de nacimiento","true",},
                              {"estado","Estado","true",},
                              };
            cuDataGridD1.AlDatosEntrada.Add(Scaden);
            cuDataGridD1.vinicializar();
            ///////////////////////////////////

            //Datos Grid Enfermedad
            //Datos Grid Perfil
            String[,] Scadena ={{"id_enfermedad","Codigo","true"},
                                {"nombre_enfermedad","Nombre","true"},
                                {"estado","Estado","true",}, 
                              };
            cuDataGridD2.AlDatosEntrada.Add(Scadena);
            cuDataGridD2.vinicializar();
            ///////////////////////////////////////////
        }

        private void cuDataGridD1_Load(object sender, EventArgs e)
        {
            
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidpaciente.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidenfermedad.Text = cuDataGridD2.SObtenerDato;
        }
    }
}
