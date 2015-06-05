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

namespace SIP_Administrativo
{
    public partial class wf_Clientes : Form
    {
        cs_Negocio cbo = new cs_Negocio();
        ArrayList EnviaDatos = new ArrayList();
        public wf_Clientes()
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
        private void wf_Clientes_Load(object sender, EventArgs e)
        {
            EnviaDatos.Add(txtcod_cte);
            //EnviaDatos.Add(txtcod_empsa);
            EnviaDatos.Add(txtdpi_cte);
            EnviaDatos.Add(txtnit_cte);
            EnviaDatos.Add(txtnom1_cte);
            EnviaDatos.Add(txtnom2_cte);
            EnviaDatos.Add(txtapell1_cte);
            EnviaDatos.Add(txtapell2_cte);
            EnviaDatos.Add(txttel_cte);
            EnviaDatos.Add(txtdire_cte);
            EnviaDatos.Add(txtestado_cte);

            navegador1.alDatosEntrada = EnviaDatos;
            navegador1.vIniciarNavegador();

            llenarCBO();
        }
        private void llenarCBO()
        {
            //BindingSource bdcbo = new BindingSource();
            //bdcbo.DataSource = cbo.obtenerDatosCombo();
            //cbocodempsa.DataSource = bdcbo.DataSource;
            //cbocodempsa.DisplayMember = "nomcomercial_empsa";
            //cbocodempsa.ValueMember = "cod_empsa";
            //cbocodempsa.Refresh();

            //cboestado_cte.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtestado_cte_TextChanged(object sender, EventArgs e)
        {
            switch (txtestado_cte.Text)
            {
                case "1": cboestado_cte.SelectedIndex = 0;
                    break;
                case "2": cboestado_cte.SelectedIndex = 1;
                    break;
                default: break;
            }
        }

        private void cboestado_cte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboestado_cte.SelectedIndex)
            {
                case 0: txtestado_cte.Text = "1";
                    break;
                case 1: txtestado_cte.Text = "0";
                    break;
                default: break;
            }
        }

        private void cbocodempsa_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbocodempsa.DropDownStyle = ComboBoxStyle.DropDownList;

            //string valor = cbocodempsa.SelectedValue.ToString();
            //txtcod_empsa.Text = valor;
        }
        private void txtcod_empsa_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            wf_Busquedacte frmcte = new wf_Busquedacte();
            frmcte.Show();
        }

        private void txtnom1_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs_Entidades.SoloLetras(e);
        }

        private void txtnom2_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs_Entidades.SoloLetras(e);
        }

        private void txtapell1_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs_Entidades.SoloLetras(e);
        }

        private void txtapell2_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs_Entidades.SoloLetras(e);
        }

        private void txtdpi_cte_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs_Entidades.SoloNumeros(e);
        }

        private void navegador1_btnNuevo_BeforeClick(object sender, EventArgs e)
        {
            txtcod_cte.Visible = false;
            lblcodcte.Visible = false;
        }

    }
}
