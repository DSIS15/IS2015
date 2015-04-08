using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace dll_seguridad.Presentacion
{
    public partial class wfSubMod : Form
    {

        private ArrayList alDatosEnviados = new ArrayList();
        public wfSubMod()
        {
            InitializeComponent();
        }

        private void wfSubMod_Load(object sender, EventArgs e)
        {
            //Datos del Navegador
            alDatosEnviados.Add(txtIDSubMod);
            alDatosEnviados.Add(txtIDMod);
            alDatosEnviados.Add(txtNomSubMod);
            alDatosEnviados.Add(txtNomForm);
            alDatosEnviados.Add(txtfecc);
            alDatosEnviados.Add(txtfecm);
            alDatosEnviados.Add(txtEstado);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            /////////////////////////////////////

            //Datos del Grid 
            String[,] sCadena={
                              {"id_modulo","Código","true"},
                              {"nombre_modulo","Nombre","true"},
                              {"nombre_dll","Nombre_DLL","false"},
                              {"fecha_creacion","Fecha Creación","true",},
                              {"fecha_modificacion","Fecha Modificación","true",},
                              {"estado","Estado","true"},                              
                              };
            cuDataGridD1.AlDatosEntrada.Add(sCadena);
            cuDataGridD1.vinicializar();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado.Text)
            {
                case "1": cbestado.SelectedIndex = 0; break;
                case "0": cbestado.SelectedIndex = 1; break;
                default: cbestado.SelectedIndex = -1; break;
            }
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbestado.SelectedIndex)
            {
                case 0: txtEstado.Text = "1"; break;
                case 1: txtEstado.Text = "0"; break;
                default: txtEstado.Text = String.Empty; break;
            }
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDMod.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD1_Load(object sender, EventArgs e)
        {

        }
    }
}
