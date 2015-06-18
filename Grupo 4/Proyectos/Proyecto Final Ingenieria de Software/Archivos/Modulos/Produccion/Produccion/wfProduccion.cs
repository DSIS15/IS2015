using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;

/* Roberto Alexander Grave Vicente
 * 0901-11-16185
 * generar Orden de Produccion*/

namespace Produccion
{
    public partial class wfProduccion : Form
    {
        csNegocio obtDatosN = new csNegocio();
        string nombreFormula;
        string cantidad;
        ArrayList listaP = new ArrayList();
        int per, cant, i,num;
        bool valido = false;

        

        public wfProduccion()
        {
            InitializeComponent();
            obtDatosFormula();
            detalleFormula();

        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        public void obtDatosFormula()
        {

            BindingSource obtBinFormula = new BindingSource();
            obtBinFormula.DataSource = obtDatosN.obtDatosF();
            dgvFormula.DataSource = obtBinFormula;
            
        }

        

        private void wfProduccion_Load(object sender, EventArgs e)
        {
            listaP.Add(txtCodP.Text);
            listaP.Add(txtCodF.Text);
            listaP.Add(txtCantP.Text);
            listaP.Add(txtEstadoP.Text);
            listaP.Add(txtCostoDirFab.Text);
            listaP.Add(txtCostoIndFabricacion.Text);
            listaP.Add(txtCostoP.Text);
            listaP.Add(txtCostoTotal.Text);
            listaP.Add(txtPrecioVta.Text);
            //navegador1.alDatosEntrada = listaP;
            //navegador1.vIniciarNavegador();

            
        }

        private void txtNombreFormula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreFormula_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }


        public void detalleFormula()
        {

            BindingSource obtBinFormula = new BindingSource();
            obtBinFormula.DataSource = obtDatosN.obtDatosFMP();
            dgvDetalleF.DataSource = obtBinFormula;

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                float costoPrimo = Convert.ToInt32(txtMOD.Text) + Convert.ToInt32(txtMP.Text);
                float costoProduccion = Convert.ToInt32(txtGF.Text) + costoPrimo;
                float costoIndFab = costoProduccion - costoPrimo;
                float costoTotal = costoProduccion + Convert.ToInt32(txtGF.Text) + Convert.ToInt32(txtMOI.Text);
                float precioVta = (costoTotal + (costoTotal * 30 / 100)) / Convert.ToInt32(txtCantP.Text);

                txtCostoDirFab.Text = Convert.ToString(costoPrimo);
                txtCostoIndFabricacion.Text = Convert.ToString(costoIndFab);
                txtCostoP.Text = Convert.ToString(costoProduccion);
                txtCostoTotal.Text = Convert.ToString(costoTotal);
                txtPrecioVta.Text = Convert.ToString(precioVta);

            }catch(Exception g)
            {
                MessageBox.Show(g.ToString());
                MessageBox.Show("Los Calculos No puedieron Realizarse ...");
            }

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection myConnection = conexcioBD.BDcomun.ObtenerConexion();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            MySqlTransaction myTrans;

            // iniciando la trasaccion
            myTrans = myConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            myCommand.Transaction = myTrans;

            try
            {
               // myCommand.CommandText = "insert into tabm_for values(@cod_formu,@cod_mp,@cantidad_formu,@estado_formu)";
                #region
                //string cadena = cbo_estaf.SelectedItem.ToString();
                //string cadena2 = txt_codf.Text;
                //string cad = numericUpDown1.Value.ToString();
                //foreach (DataGridViewRow row in dataGridView2.Rows)
                //{
                //    myCommand.Parameters.Clear();

                //    myCommand.Parameters.AddWithValue("@cod_formu", Convert.ToString(cadena2));
                //    myCommand.Parameters.AddWithValue("@cod_mp", Convert.ToString(row.Cells["cod_materiaprima"].Value));
                //    myCommand.Parameters.AddWithValue("@cantidad_formu", Convert.ToString(row.Cells["Cantidad"].Value));
                //    myCommand.Parameters.AddWithValue("@estado_formu", Convert.ToString(cadena));
                //    myCommand.CommandTimeout = 0;

                //    myCommand.ExecuteNonQuery();

                //}

                //string nombref = txt_nomf.Text;
                //string unidadf = cbo_unif.SelectedItem.ToString();
                //string preciof = txt_preciou.Text;
                #endregion
                myCommand.CommandText = "INSERT INTO tabm_produccion(cod_pro,cod_formu,cantidad_prod,estado_prod,costo_dir,costo_ind,costo_prod,costo_total,precio_vta) Values('" + txtCodP.Text + "','" + txtCodF.Text + "','" + txtCantP.Text + "','" + txtEstadoP.Text + "','" + txtCostoDirFab.Text + "', '" + txtCostoIndFabricacion.Text + "', '" + txtCostoP.Text + "', '" + txtCostoTotal.Text + "', '" + txtPrecioVta.Text + "')";
                myCommand.ExecuteNonQuery();

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

            actualizarDatos();

            DataTable dt = new DataTable();
            dt = obtDatosN.obtDatosFMP();
            
            btnMover.Enabled = true;
        }





     

        public void validarCantidad()
        {
            try
            {
                nombreFormula = txtNombreFormula.Text;
                DataTable dt = new DataTable();

                dt = obtDatosN.obtDatosFMP();
                //DataRow[] result = dt.Select("Cantidad");
                num = dt.Rows.Count;
                #region
                //MessageBox.Show(" " + num);
                // do{
                //for (i = 0; i < num; i++)
                //{
                //    DataRow fila = dt.Rows[i];
                //    per = Convert.ToInt32(fila["Cantidad"]);
                //    if (Convert.ToInt32(txtCantP.Text) >= per)
                //    {
                //        valido = false;
                //        i = num;
                //    }
                //    if (Convert.ToInt32(txtCantP.Text) <= per)
                //    {
                //        valido = true;

                //    }
                //}
                #endregion

                num = dgvDetalleF.Rows.Count;
               
                for (i = 0; i < num - 1; i++)
                {
                    per = Convert.ToInt32(dgvDetalleF.Rows[i].Cells[4].Value);

                    if (Convert.ToInt32(txtCantP.Text) >= per)
                    {
                        valido = false;
                        i = num;
                    }
                    if (Convert.ToInt32(txtCantP.Text) < per)
                    {
                        valido = true;

                    }

                   
                }


                if (valido)
                {
                    btnGenerar.Enabled = true;
                    txtCodF.Enabled = false;
                    txtCodP.Enabled = true;
                    txtNombreFormula.Enabled = false;
                    cboProduccion.Enabled = true;
                    txtCostoDirFab.Enabled = false;
                    txtCostoIndFabricacion.Enabled = false;
                    txtCostoP.Enabled = false;
                    txtCostoTotal.Enabled = false;
                    txtGF.Enabled = true;
                    txtMOD.Enabled = true;
                    txtMOI.Enabled = true;
                    txtMP.Enabled = false;
                    txtPrecioVta.Enabled = false;
                    btnProduccion.Enabled = true;

                    cant = Convert.ToInt32(cantidad) * Convert.ToInt32(txtCantP.Text);
                    txtMP.Text = cant.ToString();

                    MessageBox.Show("Orden de Producción de: " + txtNombreFormula.Text + " .", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    btnGenerar.Enabled = false;
                    txtCodF.Enabled = false;
                    txtCodP.Enabled = false;
                    txtNombreFormula.Enabled = false;
                    cboProduccion.Enabled = false;
                    txtCostoDirFab.Enabled = false;
                    txtCostoIndFabricacion.Enabled = false;
                    txtCostoP.Enabled = false;
                    txtCostoTotal.Enabled = false;
                    txtGF.Enabled = false;
                    txtMOD.Enabled = false;
                    txtMOI.Enabled = false;
                    txtMP.Enabled = false;
                    txtPrecioVta.Enabled = false;
                    btnProduccion.Enabled = false;
                    MessageBox.Show("No existe Materia Prima Suficiente para la Producción de: "+txtNombreFormula.Text+ " Se debe Realizar Una Orden de Compra." ,"Alerta", MessageBoxButtons.OK ,  MessageBoxIcon.Asterisk);

                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            #region
            //foreach (DataRow row in result)
            //{
            //    dtd = row[2].ToString();
            //    per = Convert.ToInt32(dtd);
            //}
            //DataRow row = datatable.Rows[0];
            //txtNombre.Text = row["nombre"].ToString();
            //txtApellido.Text = row["apellido"].ToString();
            #endregion
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            validarCantidad();
        }

        private void dgvFormula_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCodF.Text = dgvFormula.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombreFormula.Text = dgvFormula.Rows[e.RowIndex].Cells[1].Value.ToString();
                cantidad = dgvFormula.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNombreMp.Text = dgvFormula.Rows[e.RowIndex].Cells[1].Value.ToString();

                string fieldName = string.Concat("[", obtDatosN.obtDatosFMP().Columns[0].ColumnName, "]");
                obtDatosN.obtDatosFMP().DefaultView.Sort = fieldName;
                DataView view = obtDatosN.obtDatosFMP().DefaultView;
                view.RowFilter = string.Empty;
                if (txtNombreMp.Text != string.Empty)
                    view.RowFilter = fieldName + " LIKE '%" + txtNombreMp.Text + "%'";
                dgvDetalleF.DataSource = view;
            }catch(Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void cboProduccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboProduccion.SelectedIndex)
            {
                case 0: txtEstadoP.Text = "1";
                    break;
                case 1: txtEstadoP.Text = "0";
                    break;
                default: break;
            }
        }

        private void txtEstadoP_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoP.Text)
            {
                case "1": cboProduccion.SelectedIndex = 0;
                    break;
                case "2": cboProduccion.SelectedIndex = 1;
                    break;
                default: break;
            }
        }

        private void txtNombreMp_KeyUp(object sender, KeyEventArgs e)
        {
            
        }


        public void actualizarDatos()
        {
            MySqlConnection myConnection = conexcioBD.BDcomun.ObtenerConexion();
            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            MySqlTransaction myTrans;

            // iniciando la trasaccion
            myTrans = myConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            myCommand.Transaction = myTrans;
            //myCommand.u

            try
            {

                num = dgvDetalleF.Rows.Count;

                int[] valoresN = new int[num];
                string[] CodigoMP = new string[num];
                string[] nomFormula = new string[num];

                for (i = 0; i < num - 1; i++)
                {
                    CodigoMP[i] = Convert.ToString(dgvDetalleF.Rows[i].Cells[2].Value);
                    valoresN[i] = Convert.ToInt32(dgvDetalleF.Rows[i].Cells[4].Value) - Convert.ToInt32(txtCantP.Text);

                    #region
                    //MessageBox.Show(" " + valoresN[i]);
                    //MessageBox.Show(" " + CodigoMP[i]);
                    //MessageBox.Show("UPDATE tabm_materiaprima SET canitdad_mp = " + valoresN[i] + " where nom_mp = '" + CodigoMP[i] + "'");
                    #endregion

                    myCommand.CommandText = "UPDATE tabm_materiaprima SET canitdad_mp = " + valoresN[i] + " where nom_mp = '" + CodigoMP[i] + "'";
                    myCommand.ExecuteNonQuery();

                }

                myTrans.Commit();

            }
            catch (Exception a)
            {
                myTrans.Rollback();
                MessageBox.Show(a.ToString());
                MessageBox.Show("Datos no Actualizados...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally
            {
                myConnection.Close();
            }
        }



        private void btnMover_Click(object sender, EventArgs e)
        {
            #region
            //MySqlConnection myConnection = conexcioBD.BDcomun.ObtenerConexion();
            //MySqlCommand myCommand = new MySqlCommand();
            //myCommand.Connection = myConnection;
            //MySqlTransaction myTrans;

            //// iniciando la trasaccion
            //myTrans = myConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            //myCommand.Transaction = myTrans;
            ////myCommand.u

            //try
            //{
                
            //    num = dgvDetalleF.Rows.Count;

            //    int[] valoresN = new int[num];
            //    string[] CodigoMP = new string[num];
            //    string[] nomFormula = new string[num];

            //    for (i = 0; i < num - 1; i++)
            //    {
            //        CodigoMP[i] = Convert.ToString(dgvDetalleF.Rows[i].Cells[2].Value);
            //        valoresN[i] = Convert.ToInt32(dgvDetalleF.Rows[i].Cells[4].Value) - Convert.ToInt32(txtCantP.Text);


            //        MessageBox.Show(" " + valoresN[i]);
            //        MessageBox.Show(" " + CodigoMP[i]);
            //        MessageBox.Show("UPDATE tabm_materiaprima SET canitdad_mp = " + valoresN[i] + " where nom_mp = '" + CodigoMP[i] + "'");

            //        myCommand.CommandText = "UPDATE tabm_materiaprima SET canitdad_mp = " + valoresN[i] + " where nom_mp = '"+CodigoMP[i]+"'";
            //        myCommand.ExecuteNonQuery();
                   
            //    }

            //    myTrans.Commit();
               
            //    //MessageBox.Show("........");

            //}
            //catch (Exception a)
            //{
            //    myTrans.Rollback();
            //    MessageBox.Show(a.ToString());
            //    MessageBox.Show("Datos no Actualizados...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //}
            //finally
            //{
            //    myConnection.Close();
            //}
            #endregion

            wfProducciones p = new wfProducciones();
            p.Show();
        }



    }     
}
