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

//Jose Ambrosio
//18/04/2015
//formulario proveedores

namespace SIP_Administrativo
{
    public partial class wf_Proveedores : Form
    {
        cs_Negocio cbo = new cs_Negocio();
        ArrayList EnviaDatos = new ArrayList();
        private String SCod_prov = string.Empty;

        public String SCod_provee
        {
            get { return SCod_prov; }
            set { SCod_prov = value; }
        }
        public wf_Proveedores()
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
        private void wf_Proveedores_Load(object sender, EventArgs e)
        {
            EnviaDatos.Add(txtcod_prov);
            EnviaDatos.Add(txtnit_prov);
            EnviaDatos.Add(txtnom_prov);
            EnviaDatos.Add(txttel_prov);
            EnviaDatos.Add(txtdir_prov);
            EnviaDatos.Add(txtestado_prov);

            navegador1.alDatosEntrada = EnviaDatos;
            navegador1.vIniciarNavegador();

        }
        private void txtestado_prov_TextChanged(object sender, EventArgs e)
        {
            switch (txtestado_prov.Text)
            {
                case "1": cboestado_prov.SelectedIndex = 0;
                    break;
                case "2": cboestado_prov.SelectedIndex = 1;
                    break;
                default: break;
            }
        }

        private void cboestado_prov_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboestado_prov.SelectedIndex)
            {
                case 0: txtestado_prov.Text = "1";
                    break;
                case 1: txtestado_prov.Text = "0";
                    break;
                default: break;
            }
            cboestado_prov.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void navegador1_btnNuevo_BeforeClick(object sender, EventArgs e)
        {
            txtcod_prov.Visible = false;
            lblcodprov.Visible = false;
        }

        private void navegador1_btnNuevo_BeforeClick_1(object sender, EventArgs e)
        {
            txtcod_prov.Visible = false;
            lblcodprov.Visible = false;
        }

        private void txtnom_prov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txttel_prov_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wf_BusquedaPro Empresa = new wf_BusquedaPro();
            Empresa.Show();
          
        }

        private void txtcod_prov_TextChanged(object sender, EventArgs e)
        {
            SCod_provee = txtcod_prov.Text;                   
        }
    }
}
