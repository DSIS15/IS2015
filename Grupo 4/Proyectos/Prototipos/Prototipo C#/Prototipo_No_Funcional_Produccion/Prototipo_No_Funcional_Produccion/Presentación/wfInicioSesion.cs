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

namespace Produccion_EnterpriseSolution
{
    public partial class wfInicioSesion : Form
    {
       // ArrayList  = new ArrayList();
        csNegocios cbo = new csNegocios();
        csNegocios txtcbo = new csNegocios();
        csDatos bitacora = new csDatos();
        public wfInicioSesion()
        {
            InitializeComponent();
            llenarDatoscboEmpresa();
            llenarDatoscboMoneda();
        }

        private void btnIniciosesion_Click(object sender, EventArgs e)
        {
            if ((txtUser.Text != "") && (txtPass.Text != "") )
            {
                
                if(Seguridad_Producción.csValidaciones.Validar_Usuario(txtUser.Text, txtPass.Text, txtcboEmpresa.Text)== 1)
                {
                    wfMenuPrincipal MenuPrincipal = new wfMenuPrincipal();
                    MenuPrincipal.vgUsuario = txtUser.Text;
                    MenuPrincipal.vgEmpresa = txt2Empresa.Text;
                    MenuPrincipal.vgMoneda = txt2Moneda.Text;
                    MenuPrincipal.Show(this);
                    this.Hide();
                                            
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

        private void wfInicioSesion_Load(object sender, EventArgs e)
        {

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

        private void cboEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboEmpresa.DropDownStyle = ComboBoxStyle.DropDownList;
            txtcboEmpresa.Text = cboEmpresa.SelectedValue.ToString();
            
            string valor = cboEmpresa.Text;
            
            string valor1 = this.cboEmpresa.GetItemText(this.cboEmpresa.SelectedItem);
            txt2Empresa.Text = valor1; 
            
        }

        private void cboMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtcboMoneda.Text = cboMoneda.SelectedValue.ToString();

            string valor2 = cboMoneda.Text;

            string valor3 = this.cboMoneda.GetItemText(this.cboMoneda.SelectedItem);
            txt2Moneda.Text = valor3;


        }

        public void llenarBitacora(string usuario, string fecha, string hora)
        {
            
            ODBCconnector.csFunciones.vInsertar("insert into tabm_bitacora values('"+usuario+"', '"+ fecha +"', '"+ hora +"')");
        }


    }

        
    
}
