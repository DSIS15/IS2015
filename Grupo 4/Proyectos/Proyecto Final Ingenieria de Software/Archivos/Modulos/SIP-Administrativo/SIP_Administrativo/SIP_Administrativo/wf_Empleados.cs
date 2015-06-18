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
    public partial class wf_Empleados : Form
    {
        cs_Negocio cbo = new cs_Negocio();
        ArrayList EnviaDatos = new ArrayList();
        public wf_Empleados()
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
        private void wf_Empleados_Load(object sender, EventArgs e)
        {
            EnviaDatos.Add(txtcod_emp);
            EnviaDatos.Add(txtcod_empsa);
            EnviaDatos.Add(txtdpi_emp);
            EnviaDatos.Add(txtnit_emp);
            EnviaDatos.Add(txtnom1_emp);
            EnviaDatos.Add(txtnom2_emp);
            EnviaDatos.Add(txtape1_emp);
            EnviaDatos.Add(txtape2_emp);
            EnviaDatos.Add(txtdire_emp);
            EnviaDatos.Add(txtafigss_emp);
            EnviaDatos.Add(txtestado_emp);

            navegador1.alDatosEntrada = EnviaDatos;
            navegador1.vIniciarNavegador();

            llenarCBO();
        }

        private void llenarCBO()
        {
            BindingSource bdcbo = new BindingSource();
            bdcbo.DataSource = cbo.obtenerDatosCombo();
            cbocodempsa.DataSource = bdcbo.DataSource;
            cbocodempsa.DisplayMember = "nomcomercial_empsa";
            cbocodempsa.ValueMember = "cod_empsa";
            cbocodempsa.Refresh();

            cboestado_emp.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtestado_emp_TextChanged(object sender, EventArgs e)
        {
            switch (txtestado_emp.Text)
            {
                case "1": cboestado_emp.SelectedIndex = 0;
                    break;
                case "2": cboestado_emp.SelectedIndex = 1;
                    break;
                default: break;
            }
        }

        private void cboestado_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboestado_emp.SelectedIndex)
            {
                case 0: txtestado_emp.Text = "1";
                    break;
                case 1: txtestado_emp.Text = "0";
                    break;
                default: break;
            }
        }
        private void cbocodempsa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocodempsa.DropDownStyle = ComboBoxStyle.DropDownList;

            string valor = cbocodempsa.SelectedValue.ToString();
            txtcod_empsa.Text = valor;
        }
        private void navegador1_btnNuevo_BeforeClick(object sender, EventArgs e)
        {
            txtcod_emp.Visible = false;
            lblcodEmp.Visible = false;
        }
        private void txtdpi_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs_Entidades.SoloNumeros(e);
        }

        private void txtnom1_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs_Entidades.SoloLetras(e);
        }

        private void txtape1_emp_KeyPress(object sender, KeyPressEventArgs e)
        {
            cs_Entidades.SoloLetras(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            wf_BusquedaEmp frmemp = new wf_BusquedaEmp();
            frmemp.Show();
        }

        private void navegador1_btnNuevo_BeforeClick_1(object sender, EventArgs e)
        {
            txtcod_emp.Visible = false;
            lblcodEmp.Visible = false;
        }

    }
}
