using dll_seguridad.Recursos_localizables;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_seguridad.Presentacion
{
    public partial class wfDetMod : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfDetMod()
        {
            InitializeComponent();
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEstado.SelectedIndex)
            {
                case 0: txtestado.Text = "1"; break;
                case 1: txtestado.Text = "0"; break;
                default: txtestado.Text = String.Empty; break;
            }
        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {
            switch (txtestado.Text)
            {
                case "1": cbEstado.SelectedIndex = 0; break;
                case "0": cbEstado.SelectedIndex = 1; break;
                default: cbEstado.SelectedIndex = -1; break;
            }
        }

        private void wfDetMod_Load(object sender, EventArgs e)
        {
            //Datos navegador
            alDatosEntrada.Add(txtIDDetMod);
            alDatosEntrada.Add(txtIDModulo);
            alDatosEntrada.Add(txtCodPerf);
            alDatosEntrada.Add(txtfecC);
            alDatosEntrada.Add(txtfecm);
            alDatosEntrada.Add(txtestado);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
            ///////////////////////////////////////

            //Datos Grid Modulo
            String[,] Scaden ={
                              {"id_modulo","Codigo","true"},
                              {"nombre_modulo","Nombre","true"},
                              {"nombre_dll","Nombre_DLL","false"},
                              {"fecha_creacion","Fecha Creación","true",},
                              {"fecha_modificacion","Fecha Modificación","true",},
                              {"estado","Estado","true"},                              
                              };
            cuDataGridD1.AlDatosEntrada.Add(Scaden);
            cuDataGridD1.vinicializar();
            ///////////////////////////////////

            //Datos Grid Perfil
            String[,] Scadena ={{"codigo_perfil","Codigo","true"},
                                {"nombre_perfil","Nombre","true"},
                                {"fecha_creacion","Fecha Creación","true",}, 
                                {"fecha_modificacion","Fecha Modificación","true",},
                                {"estado","Estado","false"}
                              };
            cuDataGridD2.AlDatosEntrada.Add(Scadena);
            cuDataGridD2.vinicializar();
           ///////////////////////////////////////////

        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDModulo.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodPerf.Text = cuDataGridD2.SObtenerDato;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            
            txtfecC.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtIDDetMod.Enabled = false;
            txtIDModulo.Enabled = false;
            txtCodPerf.Enabled = false;
            txtfecm.Enabled= txtfecC.Enabled = false;
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtIDDetMod.Enabled = false;
            txtIDModulo.Enabled = false;
            txtCodPerf.Enabled = false;
            txtfecC.Enabled = txtfecm.Enabled = false;
        }

        public void AplicarIdioma()
        {
            lblIDDetMod.Text = StringResources.Label6;
            lblCodMod.Text = StringResources.Label7;
            lblCodPerf.Text = StringResources.Label8;
            lblEstado.Text = StringResources.Label9;
            lblfecC.Text = StringResources.Label10;
            lblfecm.Text = StringResources.Label11;
           

            this.Text = StringResources.WindowTitle2;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((string)listBox1.SelectedItem);
            AplicarIdioma();
        }
        

      
    }
}
