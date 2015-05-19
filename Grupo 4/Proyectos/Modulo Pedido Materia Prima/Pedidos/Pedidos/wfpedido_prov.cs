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
         DataTable dtProducto = new DataTable();
         BindingSource bsProducto = new BindingSource();
         Negocio.csNegocio cbo = new Negocio.csNegocio();
         //Negocio.csNegocio dt = new Negocio.csNegocio();
         DataTable dtPedProv = new DataTable();
         BindingSource bsPedProv = new BindingSource();
         Negocio.csNegocio copia = new Negocio.csNegocio();
       
         public wfpedido_prov()
        {
            InitializeComponent();
            llenarDatoscboProducto();
            llenarDatoscboUMedida();
            vLlenardgvDetallePedProv();
            txtCantidad.Text = string.Empty;

        }

        private void pedido_prov_Load(object sender, EventArgs e)
        {
            
        }
        private void llenarDatoscboProducto()
        {
            BindingSource cbobin = new BindingSource();
            cbobin.DataSource = cbo.obtDatosProductosMP();
            cboProducto.DataSource = cbobin.DataSource;
            cboProducto.DisplayMember = "nom_mp";
            cboProducto.ValueMember = "cod_mp";
            //cboProducto.SelectedIndex = -1;
            cboProducto.Refresh();
                   
        }

        private void llenarDatoscboUMedida()
        {
            BindingSource cbobin = new BindingSource();
            cbobin.DataSource = cbo.obtDatosProductosMP();
            cboUMedida.DataSource = cbobin.DataSource;
            cboUMedida.DisplayMember = "unimedida_mp";
            cboUMedida.ValueMember = "cod_mp";
            //cboUMedida.SelectedIndex = -1;
            cboUMedida.Refresh();
            
        }

        private void vLlenardgvDetallePedProv()
        {
            
            //dtPedProv = Funciones.dtConsultarRegistros("select * from dett_vtaacc where cod_vta='" + txtCod_vta.Text + "'");
            if (dtPedProv.Rows.Count != 0)
            {
                dtPedProv.Columns.RemoveAt(0);
                dtPedProv.Columns[0].ColumnName = "Producto";
                dtPedProv.Columns[1].ColumnName = "Unidad_Medida";
                dtPedProv.Columns[2].ColumnName = "Cantidad";
                dtPedProv.Columns[3].ColumnName = "Total";

            }
            else
            {
                dtPedProv.Columns.Add("Producto");
                dtPedProv.Columns.Add("Unidad_Medida");
                dtPedProv.Columns.Add("Cantidad");
                dtPedProv.Columns.Add("Total");

            }
            bsPedProv.DataSource = dtPedProv;
            dgvDetallePedProv.DataSource = bsPedProv;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dtPedProv.Rows.Add(cboProducto.SelectedValue,cboUMedida.SelectedValue,txtCantidad.Text,txtTotal.Text);
            dgvDetallePedProv.Refresh();
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProducto.DropDownStyle = ComboBoxStyle.DropDownList;
            txtProducto.Text = cboProducto.SelectedValue.ToString();

            string valor = cboProducto.Text;

            string valor1 = this.cboProducto.GetItemText(this.cboProducto.SelectedItem);
            txtProducto.Text = valor1;

            //---------------------------------------------------------------------------
            //if (cboProducto.SelectedIndex != -1)
            //{
            //    float fPrecio = 0;
            //    foreach (DataRow drFila in dtProducto.Rows)
            //    {
            //        if (string.Compare(cboProducto.SelectedValue.ToString(), drFila[0].ToString()) == 0)
            //        {
            //            fPrecio = Convert.ToSingle(drFila[3].ToString());
            //        }
            //    }
            //    float fTotal = fPrecio * 1;
            //    txtTotal.Text = fTotal.ToString();
            //}
            

            //////if (cboProducto.SelectedIndex != -1)
            //////{
            //////    float fPrecio = 0;
            //////    foreach (DataRow drFila in cbo.obtDatosProductosMP.Rows)
            //////    {
            //////        if (string.Compare(cboProducto.SelectedValue.ToString(), drFila[0].ToString()) == 0)
            //////        {
            //////            fPrecio = Convert.ToSingle(drFila[3].ToString());
            //////        }
            //////    }
            //////    float fTotal = fPrecio * 1;
            //////    txtTotal.Text = fTotal.ToString();
            //////}
           
        }

        private void cboUMedida_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cboUMedida.DropDownStyle = ComboBoxStyle.DropDownList;
            txtUMedida.Text = cboUMedida.SelectedValue.ToString();

            string valor2 = cboUMedida.Text;

            string valor3 = this.cboUMedida.GetItemText(this.cboUMedida.SelectedItem);
            txtUMedida.Text = valor3;
        }

        private void txtFecha_Ped_TextChanged(object sender, EventArgs e)
        {
            dtpFecha_Ped.Text = txtFecha_Ped.Text;
        }

        private void dtpFecha_Ped_ValueChanged(object sender, EventArgs e)
        {
            txtFecha_Ped.Text = dtpFecha_Ped.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = new MySqlConnection("server=localhost; database=produccion; Uid=root; pwd=;");
            myConnection.Open();

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            MySqlTransaction myTrans;

            // iniciando la trasaccion
            myTrans = myConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            myCommand.Transaction = myTrans;

            try
            {
                myCommand.CommandText = "insert into tabt_detallepedido values(@cod_ped,@cod_mp,@cod_prov,@cantidad_dped,@unidad_dped)";

                //string cadena = cbo_estaf.SelectedItem.ToString();
                string cadena2 = txtPed.Text;
                string cadena3 = txtprov.Text;
                string cadena4 = txtFecha_Ped.Text;
                foreach (DataGridViewRow row in dgvDetallePedProv.Rows)
                {
                    myCommand.Parameters.Clear();

                    myCommand.Parameters.AddWithValue("@cod_ped", Convert.ToString(cadena2));
                    myCommand.Parameters.AddWithValue("@cod_mp", Convert.ToString(row.Cells["Producto"].Value));
                    myCommand.Parameters.AddWithValue("@cod_prov", Convert.ToString(cadena3));
                    myCommand.Parameters.AddWithValue("@cantidad_ped", Convert.ToString(row.Cells["Cantidad"].Value));
                    myCommand.Parameters.AddWithValue("@unidad_ped", Convert.ToString(row.Cells["Unidad_Medida"].Value));
                    
                    myCommand.CommandTimeout = 0;

                    myCommand.ExecuteNonQuery();

                }

                ////string nombref = txt_nomf.Text;
                ////string unidadf = cbo_unif.SelectedItem.ToString();
                ////string preciof = txt_preciou.Text;
                ////myCommand.CommandText = "INSERT INTO pruebam(cod_for,nom_for,uni_for,precio_for,esta_for) Values('" + cadena2 + "','" + nombref + "','" + unidadf + "','" + preciof + "','" + cadena + "')";
                ////myCommand.ExecuteNonQuery();
                /////* myCommand.CommandText = ")";
                //// myCommand.ExecuteNonQuery();*/
                myTrans.Commit();
                MessageBox.Show("Los Datos Se Han Guardado Exitosamente");
            }
            catch (Exception a)
            {
                myTrans.Rollback();
                MessageBox.Show(a.ToString());
                MessageBox.Show("Datos no ingresados a la Base de Datos");
            }
            finally
            {
                myConnection.Close();
            }
        }
           
       
    }
}
