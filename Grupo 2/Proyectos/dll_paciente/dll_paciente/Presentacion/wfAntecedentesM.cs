using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_paciente.Presentacion
{
    public partial class wfAntecedentesM : Form
    {
        private ArrayList alDatoesEntrada = new ArrayList();
        public wfAntecedentesM()
        {
            InitializeComponent();
        }

        private void wfAntecedentesM_Load(object sender, EventArgs e)
        {
            //navegador
            alDatoesEntrada.Add(txtidantecedente);
            alDatoesEntrada.Add(txtidpaciente);
            alDatoesEntrada.Add(txtidenfermedad);
            alDatoesEntrada.Add(txtdescripcion);
            navegador1.alDatosEntrada=alDatoesEntrada;
            navegador1.vIniciarNavegador();
            ///////////////////////////////////////////////

            //Grid Paciente
            String[,] sCadena ={
                               {"id_pacientes","ID","true"},
                               {"nombre_paciente","Nombre","true"},
                               {"primer_apellido","Primer Apellido","true"},
                               {"segundo_apellido","Segundo Apellido","true"},
                               {"direccion_paciente","Direccion","false"},
                               {"telefono_paciente","Telefono","false"},
                               {"estatura_paciente","Estatura","false"},
                               {"peso_paciente","Peso Paciente","true"},
                               {"sangre_paciente","Tipo de Sangre","true"},
                               {"identificacion_paciente","Identificacion","true"},
                               {"fecha_nacimiento_paciente","Fecha Nacimiento","true"},
                               {"estado","Estado","false"},
                               };
            cuDataGridD1.AlDatosEntrada.Add(sCadena);
            cuDataGridD1.vinicializar();
            /////////////////////////////////////////////////////////////

            //grid enfermedad
            String[,] sCadena2 ={
                                {"id_enfermedad","ID","true"},
                                {"nombre_enfermedad","Nombre","true"},
                                {"estado","Estado","true"},
                                };
            cuDataGridD2.AlDatosEntrada.Add(sCadena2);
            cuDataGridD2.vinicializar();

        }

        private void btnenferdedad_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            btnenferdedad.Enabled = true;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            btnenferdedad.Enabled = false;
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidpaciente.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_Load(object sender, EventArgs e)
        {

        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidenfermedad.Text = cuDataGridD1.SObtenerDato;
        }
    }
}
