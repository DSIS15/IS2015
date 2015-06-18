/* Autor: Rodrigo Miranda
 * Fecha: 15/05/2015 
 * Comentario: Programación de detalle de pedido, en las tablas tabm_pedido y tabt_detalle_pedido 
 */
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pedidos
{
    public partial class wfpedido_prov : Form
    {
         ArrayList alDatosEnviados = new ArrayList(); 
         DataTable dtProducto = new DataTable();
         BindingSource bsProducto = new BindingSource();
         Negocio.csNegocio cbo = new Negocio.csNegocio();
         DataTable dtPedProv = new DataTable();
         BindingSource bsPedProv = new BindingSource();
         Negocio.csNegocio copia = new Negocio.csNegocio();
         
        public wfpedido_prov()
        {
            InitializeComponent();          
        }        
         private void navegador1_btnNuevo_AfterClick_1(object sender, EventArgs e)
         {
             txtFechaPed.Text = dtpFechaPed.Text;
             dtpFechaPed.Focus();
             llenarDatoscboProducto();
             llenarDatoscboUMedida();
             vLlenardgvDetallePedProv();
             llenarcodigoaux();
             activar_campos();
             txtCantidad.Text = string.Empty;
             txtCod_ped.Enabled = false;

         }

         private void txtCod_ped_EnabledChanged(object sender, EventArgs e) //Bloqueo de llave primaria
         {
             txtCod_ped.Enabled = false;
         }
         private void dtpFechaPed_ValueChanged(object sender, EventArgs e)
         {
             try
            {
                txtFechaPed.Text = dtpFechaPed.Text;
            }
            catch(Exception ex)
            {
            } 
             
         }

         private void txtFechaPed_TextChanged(object sender, EventArgs e)
         {
             dtpFechaPed.Text = txtFechaPed.Text;
         }

        private void pedido_prov_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCod_ped);
            alDatosEnviados.Add(txtFechaPed);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            dgvDetallePedProv.AllowUserToAddRows = false;
            navegador1.btnLimpiar.Enabled = true;
            bloqueo_campos();

        }

        private void llenarcodigoaux()
        {
            MySqlConnection Nconexion =conexcioBD.BDcomun.ObtenerConexion();
            int antes = 0;
            string consulta = "select max(cod_ped) from tabm_pedido";
            MySqlCommand comando = new MySqlCommand(consulta, Nconexion);

            MySqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    antes = int.Parse(Convert.ToString(dr["max(cod_ped)"]));
                }
            }

            txtCodAux.Text = Convert.ToString(antes + 1);
            dr.Close();

        }

        private void llenarDatoscboProducto()
        {
            BindingSource cbobin = new BindingSource();
            cbobin.DataSource = cbo.obtDatosProductosMP();
            cboProducto.DataSource = cbobin.DataSource;
            cboProducto.DisplayMember = "nom_mp";
            cboProducto.ValueMember = "cod_mp";
            //cboProducto.ValueMember = "cod_mp";
            //cboProducto.SelectedIndex = -1;
            cboProducto.Refresh();
                   
        }

        private void llenarDatoscboUMedida() //Llenar CBO Medidas
        {
            BindingSource cbobin = new BindingSource();
            cbobin.DataSource = cbo.obtDatosProductosMP();
            cboUMedida.DataSource = cbobin.DataSource;
            cboUMedida.DisplayMember = "unimedida_mp";
            cboUMedida.ValueMember = "cod_mp";
            //cboUMedida.SelectedIndex = -1;
            cboUMedida.Refresh();
            
        }
        private void vLlenardgvDetallePedProv()//Llenar el DatagridView del detalle_pedido
        {
            //dtPedProv = Funciones.dtConsultarRegistros("select * from dett_vtaacc where cod_vta='" + txtCod_vta.Text + "'");
            if (dtPedProv.Rows.Count != 0)
            {
                dtPedProv.Columns.RemoveAt(0);
                dtPedProv.Columns[0].ColumnName = "Producto";
                dtPedProv.Columns[1].ColumnName = "Unidad_Medida";
                dtPedProv.Columns[2].ColumnName = "Cantidad";                
            }
            else
            {
                dtPedProv.Columns.Add("Producto");
                dtPedProv.Columns.Add("Unidad_Medida");
                dtPedProv.Columns.Add("Cantidad");                
            }
            bsPedProv.DataSource = dtPedProv;
            dgvDetallePedProv.DataSource = bsPedProv;
        }

        private void btnAgregar_Click(object sender, EventArgs e)// Agregar productos al detalle
        {
            if ((txtCantidad.Text != "") && (cboProducto.Text != "") && (cboUMedida.Text != ""))
            {
                dtPedProv.Rows.Add(cboProducto.SelectedValue, cboUMedida.Text, txtCantidad.Text);
                //dtPedProv.Rows.Add(cboProducto.SelectedValue, cboUMedida.SelectedValue, txtCantidad.Text);
                 dgvDetallePedProv.Refresh();
            }
             else
             {
                 MessageBox.Show("Ingrese todos los campos", "Producción", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e) //Pasar variable al txtProducto desde el cbo
        {
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            txtProducto.Text = cboProducto.SelectedValue.ToString();

            string valor = cboProducto.Text;

            string valor1 = this.cboProducto.GetItemText(this.cboProducto.SelectedItem);
            txtProducto.Text = valor1;            
        }
        private void cboUMedida_SelectedIndexChanged_1(object sender, EventArgs e) //Pasar variable al UMedida desde el cbo
        {
            cboUMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUMedida.Text = cboUMedida.SelectedValue.ToString();

            string valor2 = cboUMedida.Text;

            string valor3 = this.cboUMedida.GetItemText(this.cboUMedida.SelectedItem);
            txtUMedida.Text = valor3;
        }
              
        private void txtProv_Enter(object sender, EventArgs e)//Llamado al Modulo Proveedor para obtener el codigo
        {
            SIP_Administrativo.wf_Proveedores FProv = new SIP_Administrativo.wf_Proveedores();
            FProv.ShowDialog();
           txtProv.Text = FProv.SCod_provee;

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e) //VAlidación de campo cantidad
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtProv_KeyPress(object sender, KeyPressEventArgs e)//VAlidación de campo prov
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
      
        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            try {
                Datos.csLimpiar Limpiar = new Datos.csLimpiar();
                Limpiar.BorrarCampos(this, gbdetallepedido);
                txtFechaPed.Text = dtpFechaPed.Text;
                dtpFechaPed.Focus();
                dgvDetallePedProv.Rows.RemoveAt(0);
                //this.dgvDetallePedProv.Rows.Clear();
                //dgvDetallePedProv.DataSource = null;// limpiar 
                //llenarDatoscboProducto();
                //llenarDatoscboUMedida();
                txtCantidad.Text = string.Empty;
            
                }
                catch(Exception ex)
                {
                }        
                       
        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            //-------------------------------------------------------------------------------------------------------------------
            MySqlConnection myConnection = new MySqlConnection("server=localhost; database=produccion2015; Uid=root; pwd=;");
            //-------------------------------------------------------------------------------------------------------------------
            MySqlCommand agregar = new MySqlCommand("Insert into tabt_detallepedido values (@cod_ped,@cod_mp,@cod_prov, @cantidad_dped,@unidad_dped)", myConnection);
            myConnection.Open();

            try
            {
                //string cadena = cbo_estaf.SelectedItem.ToString();
                string cadena2 = txtCodAux.Text;
                string cadena3 = txtProv.Text;

                foreach (DataGridViewRow row in dgvDetallePedProv.Rows)
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@cod_ped", Convert.ToString(cadena2));
                    agregar.Parameters.AddWithValue("@cod_mp", Convert.ToString(row.Cells["Producto"].Value));
                    agregar.Parameters.AddWithValue("@cod_prov", Convert.ToString(cadena3));
                    agregar.Parameters.AddWithValue("@cantidad_dped", Convert.ToString(row.Cells["Cantidad"].Value));
                    agregar.Parameters.AddWithValue("@unidad_dped", Convert.ToString(row.Cells["Unidad_Medida"].Value));
                    agregar.ExecuteNonQuery();
                }
                //MessageBox.Show("Datos agregados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                MessageBox.Show(ex.Message);
                MessageBox.Show("Datos no ingresados a la Base de Datos");
            }
            finally
            {
                myConnection.Close();
            }
            limpiar_campos();
            bloqueo_campos();
        }

        private void bloqueo_campos()
        {
            txtProv.Enabled = false;
            cboProducto.Enabled = false;
            cboUMedida.Enabled = false;
            txtCantidad.Enabled = false;
            btnAgregar.Enabled = false;
            dtpFechaPed.Enabled = false;
            dgvDetallePedProv.Enabled = false;

            //txtCantidad.Text = string.Empty;      
           
        }

        private void activar_campos()
        {
            txtProv.Enabled = true;
            cboProducto.Enabled = true;
            cboUMedida.Enabled = true;
            txtCantidad.Enabled = true;
            btnAgregar.Enabled = true;
            dtpFechaPed.Enabled = true;
            dgvDetallePedProv.Enabled = true;              

        }

        private void limpiar_campos()
        {
            try
            {
                Datos.csLimpiar Limpiar = new Datos.csLimpiar();
                Limpiar.BorrarCampos(this, gbdetallepedido);
                txtFechaPed.Text = dtpFechaPed.Text;
                dtpFechaPed.Focus();
                dgvDetallePedProv.Rows.RemoveAt(0);
                txtCantidad.Text = string.Empty;
            }
            catch (Exception ex)
            {
            }  
        }
                     
    }
}
