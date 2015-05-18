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
    public partial class wfExamenRutinario : Form
    {
        ArrayList alDatosEntrada = new ArrayList();
        public wfExamenRutinario()
        {
            InitializeComponent();
        }

        private void cbosangre_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (cbosangre.SelectedItem.Equals("A+")){
                txtsangre.Text= "A+";
            }
            else if (cbosangre.SelectedItem.Equals("A-")){
                txtsangre.Text= "A-";
            }
            else if (cbosangre.SelectedItem.Equals("B+")){
                txtsangre.Text= "B+";
            }
            else if (cbosangre.SelectedItem.Equals("B-")){
                txtsangre.Text= "B-";
            }
            else if (cbosangre.SelectedItem.Equals("AB+")){
                txtsangre.Text= "AB+";
            }
            else if (cbosangre.SelectedItem.Equals("AB-")){
                txtsangre.Text= "AB-";
            }
            else if (cbosangre.SelectedItem.Equals("O-")){
                txtsangre.Text= "O+";
            }else if (cbosangre.SelectedItem.Equals("O-")){
                txtsangre.Text= "O-";
            }*/
            txtsangre.Text = cbosangre.Text;
         }

        private void txtsangre_TextChanged(object sender, EventArgs e)
        {
            cbosangre.Text = txtsangre.Text;
           /* if (txtsangre.Equals("A+")){
                cbosangre.Text= "A+";
            }
            else if (txtsangre.Equals("A-")){
                cbosangre.Text= "A-";
            }
            else if (txtsangre.Equals("B+")){
                cbosangre.Text= "B+";
            }
            else if (txtsangre.Equals("AB+")){
                cbosangre.Text= "AB+";
            }
            else if (txtsangre.Equals("AB-")){
                cbosangre.Text= "AB-";
            }
            else if (txtsangre.Equals("O+")){
                cbosangre.Text= "O+";
            }
            else if (txtsangre.Equals("O-")){
                cbosangre.Text= "O-";
            }
            */
            }

        private void wfExamenRutinario_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtid_exrutinario);
            alDatosEntrada.Add(txtpresion);
            alDatosEntrada.Add(txtcolesterol);
            alDatosEntrada.Add(txtglucosa);
            alDatosEntrada.Add(txtpeso);
            alDatosEntrada.Add(txtestatura);
            alDatosEntrada.Add(txtestado_cavidad_bucal);
            alDatosEntrada.Add(txtestado_oido);
            alDatosEntrada.Add(txtid_pacientes);
            alDatosEntrada.Add(txtid_medico);
            alDatosEntrada.Add(txtsangre);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
        
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
            cuDataGridD1.AlDatosEntrada.Add(Scaden);
            cuDataGridD1.vinicializar();
            ///////////////////////////////////


            //Datos Grid Medico
            String[,] Scadena ={
                              {"id_medico","Codigo","true"},
                              {"nombre_medico","Nombre","true"},
                              {"priimer_apellido_medico","Apellido","true"},
                              {"medico_segundo_apellido","Segundo apellido","true"},
                              {"fecha_ingreso","Fecha de ingreso","true"},
                              {"estado","Estado","true"},
                              };
            cuDataGridD2.AlDatosEntrada.Add(Scadena);
            cuDataGridD2.vinicializar();
            ///////////////////////////////////
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_pacientes.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid_medico.Text = cuDataGridD2.SObtenerDato;
        }
        }
    }

