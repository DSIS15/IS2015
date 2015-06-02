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

namespace dll_factura.Presentacion
{
    public partial class wfFactura : Form
    {
        ArrayList alDatosEntrada = new ArrayList();
        public wfFactura()
        {
            InitializeComponent();
            ///////////////////////////////////////
            //Datos Grid Paciente
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
            cuDataGridD2.AlDatosEntrada.Add(Scaden);
            cuDataGridD2.vinicializar();
            ///////////////////////////////////

            ///////////////////////////////////////
            //Datos Grid Usuario
            String[,] Scadena ={
                              {"id_usuario","Codigo","true"},
                              {"codigo_perfil","Perfil","true"},
                              {"alias_usuario","Alias","true"},
                              {"contrasena_usuario","Contrasena","false"},
                              {"nombre_usuario","Nombre usuario","true"},
                              {"primer_apellido","Primer apellido","true"},
                              {"segundo_apellido","Segundo apellido","true"},
                              {"direccion","Direccion","true"}, 
                              {"fecha_de_creacion","Fecha de creacion","true",},
                              {"fecha_de_modificacion","Fecha de modificacion","true",},
                              {"estado","Estado","true",},
                              };
            cuDataGridD1.AlDatosEntrada.Add(Scadena);
            cuDataGridD1.vinicializar();
            ///////////////////////////////////
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtfecha.Text = dtpfecha.Text;
        }

        private void wfFactura_Load(object sender, EventArgs e)
        {
            txtfecha.Text = DateTime.Now.ToString("MM/dd/yyyy");
            alDatosEntrada.Add(txtnumero_factura);
            alDatosEntrada.Add(txtnit_cliente);
            alDatosEntrada.Add(txtid_usuario);
            alDatosEntrada.Add(txtid_pacientes);
            alDatosEntrada.Add(txtfecha);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
            
            
            
        }

        private void cuDataGridD1_Load(object sender, EventArgs e)
        {

        }

        private void txtfecha_TextChanged(object sender, EventArgs e)
        {
            dtpfecha.Text = txtfecha.Text;
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_usuario.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_pacientes.Text = cuDataGridD2.SObtenerDato;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtnumero_factura.Enabled = false;
            txtid_usuario.Enabled = false;
            txtid_pacientes.Enabled = false;
        }
    }
}
