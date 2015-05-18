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
    public partial class wfCitaMedica : Form
    {
        ArrayList alDatosEntrada = new ArrayList();
        public wfCitaMedica()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void wfCitaMedica_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIdCita);
            alDatosEntrada.Add(txtEstadoCita);
            alDatosEntrada.Add(txtIdPaciente);
            alDatosEntrada.Add(txtFecha);
            alDatosEntrada.Add(txtTipoCita);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
        }

        private void cuDataGridConBusqueda1_Load(object sender, EventArgs e)
        {
            
           

        }

        private void cuDataGridD1_Load(object sender, EventArgs e)
        {
            
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUsuario.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_Load(object sender, EventArgs e)
        {
            String[,] Scadena = {
                                    {"id_medico","Codigo","true"},
                                    {"nombre_medico","Nombre","false"},
                                    {"primer_apellido","Primer Apellido","false"},
                                    {"medico_segundo_apellido","Segundo Apellido","false"},
                                    {"fecha_ingreso","Fecha ingreso","false"},
                                    {"estado","Estado","false"}
                                };
            cuDataGridD2.AlDatosEntrada.Add(Scadena);
            cuDataGridD2.vinicializar();
        }

        private void cuDataGridD1_Load_1(object sender, EventArgs e)
        {
            String[,] Scadena ={
                                   {"id_usuario", "Codigo","true"},
                                   {"codigo_perfil","Codigo Perfil","false"},
                                   {"contrasena_usuario","Contrasena","false"},
                                   {"nombre_usuario","Nombre Usuario","true"},
                                   {"primer_apellido","Primer Apellido","false"},
                                   {"segundo_apellido","Segundo Apellido","false"},
                                   {"direccion","Direccion","false"},
                                   {"fecha_de_creacion","Fecha creacion","false"},
                                   {"fecha_de_modificacion","Fecha modificacion","false"},
                                   {"estado","Estado","false"}

                                
                               };
            cuDataGridD1.AlDatosEntrada.Add(Scadena);
            cuDataGridD1.vinicializar();
        }

        private void cuDataGridD3_Load(object sender, EventArgs e)
        {
            
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMedico.Text = cuDataGridD2.SObtenerDato;
        }

        private void cuDataGridD3_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPaciente.Text = cuDataGridD3.SObtenerDato;
        }

        private void cboEstadoCita_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstadoCita.SelectedItem.Equals("Activado"))
            {
                txtEstadoCita.Text = "1";
            }
            else
            {
                txtEstadoCita.Text = "0";
            }
        }

        private void txtEstadoCita_TextChanged(object sender, EventArgs e)
        {
            if (txtEstadoCita.Text.Equals("1"))
            {
                cboEstadoCita.Text = "Activado";
            }
            else
            {
                cboEstadoCita.Text = "Desactivado";
            }
        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            dtFecha.Text = txtFecha.Text;
        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            txtFecha.Text = dtFecha.Text;

        }

        private void cuDataGridD3_Load_1(object sender, EventArgs e)
        {
            String[,] Scadena = { 
                                {"id_pacientes","Codigo","true"},
                                {"nombre_paciente","Nombre","false"},
                                {"primer_apellido","Primer apellido","false"},
                                {"segundo_apellido","Segundo apellido","false"},
                                {"direccion_paciente","Direccion","false"},
                                {"telefono_paciente","Telefono","false"},
                                {"sexo","Sexo","false"},
                                {"identificacion_paciente","Identificacion","false"},
                                {"fecha_nacimiento_paciente","Fecha nacimiento","false"},
                                {"estado","Estado","false"}
                                };
            cuDataGridD3.AlDatosEntrada.Add(Scadena);
            cuDataGridD3.vinicializar();
        }

        private void cuDataGridD1_sdgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUsuario.Text = cuDataGridD1.SObtenerDato;
        }
    }
}

