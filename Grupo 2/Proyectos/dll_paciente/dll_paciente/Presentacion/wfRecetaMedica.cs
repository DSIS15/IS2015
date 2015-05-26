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
    public partial class wfRecetaMedica : Form
    {
        ArrayList alDatosEntrada = new ArrayList();
        public wfRecetaMedica()
        {
            InitializeComponent();
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

            String[,] Scadena ={
                              {"id_medico","Codigo","true"},
                              {"nombre_medico","Nombre","true"},
                              {"priimer_apellido_medico","Apellido","true"},
                              {"medico_segundo_apellido","Segundo apellido","true"},
                              {"fecha_ingreso","Fecha de ingreso","true"},
                              {"estado","Estado","true"},
                              };
            cuDataGridD2.AlDatosEntrada.Add(Scadena);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstado.SelectedItem.Equals("Activado"))
            {
                txtestado.Text = "1";
            }
            else
            {
                txtestado.Text = "0";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtvia_de_administracion.Text = cbovia_de_administracion.Text;
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

        private void wfRecetaMedica_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtid_recetamedica);
            alDatosEntrada.Add(txtid_medico);
            alDatosEntrada.Add(txtid_pacientes);
            alDatosEntrada.Add(txtnom_med);
            alDatosEntrada.Add(txtcatmedico);
            alDatosEntrada.Add(txtvia_de_administracion);
            alDatosEntrada.Add(txtdosis);
            alDatosEntrada.Add(txtestado);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
            ///////////////////////////////////////
            //Datos Grid Paciente
            
            cuDataGridD1.vinicializar();
            ///////////////////////////////////


            //Datos Grid Medico
            
            cuDataGridD2.vinicializar();
            ///////////////////////////////////
        }

        private void txtid_recetamedica_TextChanged(object sender, EventArgs e)
        {

        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_pacientes.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_medico.Text = cuDataGridD2.SObtenerDato;
        }

        private void cbocatmedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcatmedico.Text = cbocatmedico.Text;
        }

        private void txtcatmedico_TextChanged(object sender, EventArgs e)
        {
             cbocatmedico.Text = txtcatmedico.Text;
        }

        private void txtvia_de_administracion_TextChanged(object sender, EventArgs e)
        {
            cbovia_de_administracion.Text = txtvia_de_administracion.Text;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtid_medico.Enabled = false;
            txtid_pacientes.Enabled = false;
            txtid_recetamedica.Enabled = false;
        }
    }
}
