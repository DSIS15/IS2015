using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_medico.Presentacion
{
    public partial class wfCitaMedica : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfCitaMedica()
        {
            InitializeComponent();
        }

        private void lblcitamedico_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaCita_ValueChanged(object sender, EventArgs e)
        {
            txtFechaCita.Text = dtpFechaCita.Text;
        }

        private void txtFechaCita_TextChanged(object sender, EventArgs e)
        {
            dtpFechaCita.Text = txtFechaCita.Text;
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstado.SelectedItem.Equals("Activado"))
            {
                txtEstado.Text = "1";
            }
            else
            {
                txtEstado.Text = "0";
            }
            
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals("1"))
            {
                cboEstado.Text = "Activado";
            }
            else
            {
                cboEstado.Text = "Desactivado";
            }
        }

        private void wfCitaMedica_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIdCitaMedica);
            alDatosEntrada.Add(txtIdUsuario);
            alDatosEntrada.Add(txtIdMedico);
            alDatosEntrada.Add(txtIdPacientes);
            alDatosEntrada.Add(txtFechaCita);
            alDatosEntrada.Add(txtTipoCita);
            alDatosEntrada.Add(txtEstado);
          
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();

            

            ///////////////////////////////////
           ////////Datos Grid Usuario
            String[,] Scadena ={
                                {"id_usuario","Codigo","true"},
                                {"codigo_perfil","Codigoperfil","false"},
                                {"alias_usuario","Alias","true"},
                                {"contrasena_usuario","contra","false"},
                                {"nombre_usuario","Nombre","true"},
                                {"primer_apellido","Primerapellido","false"},
                                {"segundo_apellido", "SegundoApellido","false"},
                                {"direccion","Direccion","false"},
                                {"fecha_de_creacion","Fechacreacion","true"},
                                {"fecha_de_modificacion","Fechamodificacion","false"},
                                {"estado","Estado","true"},
                                };
            cuDataGridD1.AlDatosEntrada.Add(Scadena);
            cuDataGridD1.vinicializar();

            //////////////////////////////////////
            ////////// Datos Grid Medico
            String[,] ScadenaMedico = {
                                    {"id_medico","Codigo","true"},
                                    {"nombre_medico","Nombre","true"},
                                    {"priimer_apellido_medico","PrimerApellido","true"},
                                    {"medico_segundo_apellido","SegundoApellido","true"},
                                    {"fecha_ingreso","Fecha","true"},
                                    {"estado","Estado","false"},
                                };
            cuDataGridD2.AlDatosEntrada.Add(ScadenaMedico);
            cuDataGridD2.vinicializar();

            ///////////////////////////////////
            ///////// Datos Grid Pacientes

            String[,] ScadenaPacientes = {
                                             {"id_pacientes","Codigo","true"},
                                             {"nombre_paciente","nombre","true"},
                                             {"primer_apellido","PrimerApellido","true"},
                                             {"segundo_apellido","SegundoApellido","false"},
                                             {"direccion_paciente","Direccion","false"},
                                             {"telefono_paciente","Telefono","false"},
                                             {"sexo","Sexo","false"},
                                             {"identificacion_paciente","Identificacion","false"},
                                             {"fecha_nacimiento_paciente","FechaNac","false"},
                                             {"estado","Estado","true"},

                                         };
            cuDataGridD3.AlDatosEntrada.Add(ScadenaPacientes);
            cuDataGridD3.vinicializar();


        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdUsuario.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMedico.Text = cuDataGridD2.SObtenerDato;
        }

        private void cuDataGridD3_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdPacientes.Text = cuDataGridD3.SObtenerDato;
        }

        private void navegador1_btnNuevo_BeforeClick(object sender, EventArgs e)
        {
            
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            
        }

        private void navegador1_MouseMove(object sender, MouseEventArgs e)
        {
            //txtIdCitaMedica.Enabled = false;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtIdCitaMedica.Enabled = false;
            txtIdMedico.Enabled = false;
            txtIdPacientes.Enabled = false;
            txtIdUsuario.Enabled = false;

        }
    }
}
