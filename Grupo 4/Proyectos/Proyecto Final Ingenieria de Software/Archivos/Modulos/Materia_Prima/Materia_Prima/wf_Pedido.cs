using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;

// Abner Josue Rodas
// Grupo 4
// DLL MATERIA PRIMA



namespace Materia_Prima
{
    public partial class wf_Pedido : Form
    {
        cs_Negocio cbo = new cs_Negocio();
        ArrayList EnviaDatos = new ArrayList();
     
        public wf_Pedido()
        {
            InitializeComponent();
        }

        public void vinicializar()
        {
            navegador1.btnEliminar.Enabled = false;
            navegador1.btnGuardar.Enabled = false;
            navegador1.btnModificar.Enabled = false;
            navegador1.btnNuevo.Enabled = false;
        }

        private void wf_Pedido_Load(object sender, EventArgs e)
        {
            EnviaDatos.Add(txtcod_ped);
            EnviaDatos.Add(txtcod_prov);
            EnviaDatos.Add(txtunitm_ped);
            EnviaDatos.Add(txtcant_ped);
            EnviaDatos.Add(txtfecha_ped);

            navegador1.alDatosEntrada = EnviaDatos;
            navegador1.vIniciarNavegador();

            llenarCBO();
            llenarCBO2();
        }

        private void llenarCBO()
        {
            BindingSource bdcbo = new BindingSource();
            bdcbo.DataSource = cbo.obtenerDatosCombo();
            cbocodprov.DataSource = bdcbo.DataSource;
            cbocodprov.DisplayMember = "nom_prov";
            cbocodprov.ValueMember = "cod_prov";
            cbocodprov.Refresh();

        }


        private void llenarCBO2()
        {
            BindingSource bdcbo2 = new BindingSource();
            bdcbo2.DataSource = cbo.obtenerDatosCombo2();
            cbocodmp.DataSource = bdcbo2.DataSource;
            cbocodmp.DisplayMember = "nom_mp";
            cbocodmp.ValueMember = "cod_mp";
            cbocodmp.Refresh();

        }

        private void cbocodprov_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocodprov.DropDownStyle = ComboBoxStyle.DropDownList;

            string valor = cbocodprov.SelectedValue.ToString();
            txtcod_prov.Text = valor;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            wf_BusquedaPed frmcte = new wf_BusquedaPed();
            frmcte.Show();
        }

        private void cbocodmp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbocodmp.DropDownStyle = ComboBoxStyle.DropDownList;

            string valor = cbocodmp.SelectedValue.ToString();
            txtcod_mp.Text = valor;
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }


    }
}