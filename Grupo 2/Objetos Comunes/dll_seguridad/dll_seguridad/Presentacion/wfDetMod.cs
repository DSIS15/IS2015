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
            String[,] Scaden ={
                              {"id_modulo","Codigo","true"},
                              {"nombre_modulo","Nombre","true"},
                              {"nombre_dll","Nombre_DLL","false"},
                              {"fecha_creacion","Fecha Creación","true",},
                              {"fecha_modificacion","Fecha Modificación","true",},
                              {"estado","Estado","true"},                              
                              };
            dgvmodulo.AlDatosEntrada.Add(Scaden);

            String[,] Scadena ={{"codigo_perfil","Codigo","true"},
                                {"nombre_perfil","Nombre","true"},
                                {"fecha_creacion","Fecha Creación","true",}, 
                                {"fecha_modificacion","Fecha Modificación","true",},
                                {"estado","Estado","false"}
                              };
            dgvperfil.AlDatosEntrada.Add(Scadena);
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
            alDatosEntrada.Add(txtCodPerf);
            alDatosEntrada.Add(txtIDModulo);
            alDatosEntrada.Add(txtfecC);
            alDatosEntrada.Add(txtfecm);
            alDatosEntrada.Add(txtestado);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
            ///////////////////////////////////////

            //Datos Grid Modulo
            
            dgvmodulo.vinicializar();
            ///////////////////////////////////

            //Datos Grid Perfil
            
            dgvperfil.vinicializar();
           ///////////////////////////////////////////

        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDModulo.Text = dgvmodulo.SObtenerDato;
        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodPerf.Text = dgvperfil.SObtenerDato;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se creo un nuevo detalle de modulo");

            txtfecC.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtIDDetMod.Enabled = false;
            txtIDModulo.Enabled = false;
            txtCodPerf.Enabled = false;
            txtfecm.Enabled= txtfecC.Enabled = false;
            //MessageBox.Show("Ejecutando dllbitacora");
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se inserto en Detalle modulo");
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se modifico un registro en detalle de modulo");

            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtIDDetMod.Enabled = false;
            txtIDModulo.Enabled = false;
            txtCodPerf.Enabled = false;
            txtfecC.Enabled = txtfecm.Enabled = false;
            
            
        }
                

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se guardo un nuevo detalle de modulo");
        }

        private void cuDataGridD2_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_btnBuscar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se busco un registro en detalle de modulo");
        }

        private void navegador1_btnEliminar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se elimino un registro en detalle de modulo");
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se limpiaron los regisros en detalle de modulo");
        }
        

      
    }
}
