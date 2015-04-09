using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad_Producción.Presentación
{
    public partial class wfInicioSesion : Form
    {
        Negocio.csNegocio cbo = new Negocio.csNegocio();
        Negocio.csNegocio txtcbo = new Negocio.csNegocio();
        Datos.csDatos bitacora = new Datos.csDatos();
        private Form wfMenuPrincipal = new Form();
        private string sEmpresa = string.Empty;
        private string sUsuario = string.Empty;
        private string sMoneda = string.Empty;

        public string SMoneda
        {
            get { return sMoneda; }
            set { sMoneda = value; }
        }

        public string SEmpresa
        {
            get { return sEmpresa; }
            set { sEmpresa = value; }
        }
       
        public string SUsuario
        {
            get { return sUsuario; }
            set { sUsuario = value; }
        }
        
                 
      
        public wfInicioSesion(Form wfMenuV)
        {
            wfMenuPrincipal = wfMenuV;
            InitializeComponent();
            llenarDatoscboEmpresa();
            llenarDatoscboMoneda();
        }

        private void wfInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void enviodatos()
        {
            SUsuario = txtUser.Text;
            SEmpresa = txtcboEmpresa.Text;
            SMoneda = txtcboMoneda.Text;
        }

        private void btnIniciosesion_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text != "") && (txtPass.Text != ""))
            {

                if (Seguridad_Producción.csValidaciones.Validar_Usuario(txtUser.Text, txtPass.Text, txtcboEmpresa.Text) == 1)
                {
                    //wfMenuPrincipal.vgUsuario = txtUser.Text;
                    //wfMenuPrincipal.vgEmpresa = txt2Empresa.Text;
                    //wfMenuPrincipal.vgMoneda = txt2Moneda.Text;
                    //sEmpresa = txt2Empresa.Text;
                    //sMoneda = txt2Moneda.Text;
                    ////SUsuario = txtUser.Text;
                    ////SEmpresa = txt2Empresa.Text;
                    ////SMoneda = txt2Moneda.Text;
                    wfMenuPrincipal.Show(this);
                    this.Hide();
                    SUsuario = txtUser.Text;
                    SEmpresa = txtcboEmpresa.Text;
                    SMoneda = txtcboMoneda.Text;
                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecta", "Producción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Text = "";
                    txtPass.Text = "";
                    txtUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese todos los campos", "Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
               
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llenarDatoscboEmpresa()
        {
            BindingSource cbobin = new BindingSource();
            cbobin.DataSource = cbo.obtDatosEmpresa();
            cboEmpresa.DataSource = cbobin.DataSource;
            cboEmpresa.DisplayMember = "nom_empsa";
            cboEmpresa.ValueMember = "cod_empsa";
       }
        
        private void llenarDatoscboMoneda()
        {
            BindingSource cbobin = new BindingSource();
            cbobin.DataSource = cbo.obtDatosMoneda();
            cboMoneda.DataSource = cbobin.DataSource;
            cboMoneda.DisplayMember = "nom_mda";
            cboMoneda.ValueMember = "cod_mda";
        }

        public void llenarBitacora(string usuario, string fecha, string hora)
        {
            ODBCconnector.csFunciones.vInsertar("insert into tabm_bitacora values('" + usuario + "', '" + fecha + "', '" + hora + "')");
        }

        private void cboEmpresa_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            txtcboEmpresa.Text = cboEmpresa.SelectedValue.ToString();

            string valor = cboEmpresa.Text;

            string valor1 = this.cboEmpresa.GetItemText(this.cboEmpresa.SelectedItem);
            txt2Empresa.Text = valor1;
        }

        private void cboMoneda_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            txtcboMoneda.Text = cboMoneda.SelectedValue.ToString();

            string valor2 = cboMoneda.Text;

            string valor3 = this.cboMoneda.GetItemText(this.cboMoneda.SelectedItem);
            txt2Moneda.Text = valor3;
        }

        
    }
}
