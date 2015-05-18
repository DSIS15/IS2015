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
    public partial class wfDetExamen : Form
    {
        ArrayList alDatosEntrada = new ArrayList();
        public wfDetExamen()
        {
            InitializeComponent();
        }

        private void wfDetExamen_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIdDetalle);
            alDatosEntrada.Add(txtIdPacientes);
            alDatosEntrada.Add(txtIdTipoExamen);
            alDatosEntrada.Add(txtIdMedico);
            
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
        }

        private void txtIdTipoExamen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cuDataGridD1_Load(object sender, EventArgs e)
        {
            String[,] Scadena = { 
                                {"id_pacientes","Codigo","true"},
                                {"nombre_paciente","Nombre","true"},
                                {"primer_apellido","Primer apellido","true"},
                                {"segundo_apellido","Segundo apellido","false"},
                                {"direccion_paciente","Direccion","false"},
                                {"telefono_paciente","Telefono","false"},
                                {"sexo","Sexo","false"},
                                {"identificacion_paciente","Identificacion","false"},
                                {"fecha_nacimiento_paciente","Fecha nacimiento","false"},
                                {"estado","Estado","false"}
                                };
            cuDataGridD1.AlDatosEntrada.Add(Scadena);
            cuDataGridD1.vinicializar();
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPacientes.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_Load(object sender, EventArgs e)
        {
            String[,] Scadena = {
                                {"id_tipo_examen","Codigo","true"},
                                {"nombre_tipo_examen","Nombre tipo examen","true"},
                                {"descripcion","Descripcion","false"},
                                {"fecha_creacion","Fecha creacion","false"},
                                {"fecha_modificacion","Fecha modificacion","false"},
                                {"estado","Estado","false"}
                                };
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdTipoExamen.Text = cuDataGridD2.SObtenerDato;
        }

        private void cuDataGridD3_Load(object sender, EventArgs e)
        {
            String[,] Scadena = {
                                    {"id_medico","Codigo","true"},
                                    {"nombre_medico","Nombre","true"},
                                    {"primer_apellido","Primer Apellido","false"},
                                    {"medico_segundo_apellido","Segundo Apellido","false"},
                                    {"fecha_ingreso","Fecha ingreso","false"},
                                    {"estado","Estado","false"}
                                };
            cuDataGridD3.AlDatosEntrada.Add(Scadena);
            cuDataGridD3.vinicializar();
        }

        private void cuDataGridD3_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMedico.Text = cuDataGridD3.SObtenerDato;
        }
    }
}
