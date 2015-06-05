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
//JOSE AMBROSIO
//0901-07-3573
//15/05/2015

namespace pdFormula
{
    #region codigo Jose Ambrosio  
    public partial class wf_Formula : Form
    {
        cs_Negocios dgv= new cs_Negocios();
        ArrayList EnviaDatos = new ArrayList();
        public wf_Formula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void codigof()
        {
            #region obtenr id de formula
            MySqlConnection Nconexion = conexcioBD.BDcomun.ObtenerConexion();
            int antes = 0;
            string consulta = "select max(cod_formu) from tabm_formula";
            MySqlCommand comando = new MySqlCommand(consulta, Nconexion);
            
            MySqlDataReader dr = comando.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dr.Read();
                    antes = int.Parse(Convert.ToString(dr["max(cod_formu)"]));
                }
            }

            txt_codf.Text = Convert.ToString(antes + 1);
            dr.Close();
            #endregion
        }
        private void wf_Formula_Load(object sender, EventArgs e)
        {
            EnviaDatos.Add(txt_codf);
            EnviaDatos.Add(txt_nomf);
            EnviaDatos.Add(txtestado);
            EnviaDatos.Add(txt_preciou);
            EnviaDatos.Add(txt_estado);
     

            navegador1.alDatosEntrada = EnviaDatos;
            navegador1.vIniciarNavegador();
            navegador1.btnLimpiar.Enabled = false;
            navegador1.btnModificar.Enabled = false;
            #region llenando datagrid
            dgv_materiaprima.DataSource = dgv.obtemp();
            #endregion
            codigof();
            dataGridView2.Enabled = false;
            dgv_materiaprima.Enabled = false;
            numericUpDown1.Enabled = false;
            cbo_unif.Enabled = false;
            cbo_estaf.Enabled = false;
            btn_agregar.Enabled=false;
            btn_quitar.Enabled = false;
           // navegador1.btnModificar.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero = numericUpDown1.Value.ToString();
            #region pasar datos de datagrid a otro datagrid y suma de columna precio
            foreach (DataGridViewRow rowPrincipal in dgv_materiaprima.SelectedRows)
            {
                
               
             
                             /*  rowPrincipal.Cells["cod_materiaPrima"].Value;  
                               rowPrincipal.Cells["Materia_Prima"].Value, 
                               Convert.ToDouble(rowPrincipal.Cells["Precio"].Value.ToString())*Convert.ToDouble((numericUpDown1.Value.ToString())), 
                              rowPrincipal.Cells["Cantidad"].Value,
                            
                      
                
                DataGridViewRow roww1 = new DataGridViewRow();
               
                roww1.CreateCells(dataGridView2, values);*/

               
             
                dataGridView2.Rows.Add( rowPrincipal.Cells["cod_materiaPrima"].Value,rowPrincipal.Cells["Materia_Prima"].Value,Convert.ToDouble(rowPrincipal.Cells["Precio"].Value.ToString())*Convert.ToDouble((numericUpDown1.Value.ToString())),numericUpDown1.Value.ToString() );

              DataGridViewRow roee = dataGridView2.CurrentRow;
            

                   
                //dgv_empleados.Rows.Remove(rowPrincipal);
               




            }
            double suma = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                suma += Convert.ToDouble(row.Cells[2].Value);


            }
            txt_preciou.Text = Convert.ToString(suma);
            #endregion
        }

        private void button2_Click(object sender, EventArgs e)
        {
            #region quitando linea de datagrid
            try
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
                double resta = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    resta -= Convert.ToDouble(row.Cells[2].Value);
                    

                }
                txt_preciou.Text = Convert.ToString(Math.Abs(resta));
            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            #endregion

        }

        private void button3_Click(object sender, EventArgs e)
        {
            #region comentario
            /*#region guardar datagiredview
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=produccion2015; Uid=root; pwd=;");
            conectar.Open();

            try
            {

                MySqlCommand cmd = new MySqlCommand("insert into tabm_for values(@cod_formu,@cod_mp,@cantidad_formu,@estado_formu)", conectar);


                string cadena = comboBox1.SelectedItem.ToString();
                string cadena2 = textBox2.Text;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    cmd.Parameters.Clear();

                    cmd.Parameters.AddWithValue("@cod_formu", Convert.ToString(cadena2));
                    cmd.Parameters.AddWithValue("@cod_mp", Convert.ToString(row.Cells["cod_materiaprima"].Value));
                    cmd.Parameters.AddWithValue("@cantidad_formu", Convert.ToString(row.Cells["Cantidad"].Value));
                    cmd.Parameters.AddWithValue("@estado_formu", Convert.ToString(cadena));
                    cmd.CommandTimeout = 0;


                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("guardado");
            }
            catch (MySqlException ex)
            {
                //LogError log = new LogError();
                //log.escribirEnLog("Clase: CnBD.cs", "Tabla", 0, ex.Message, "");
                throw new Exception("Se genero el siguiente error: " + ex.Message.ToString().Replace("'", ""));
            }


            #endregion*/
    #endregion
            #region trasaccion mysql para insertar en dos tablas hecho por JOSE AMBROSIO 0901-07-3573

            MySqlConnection myConnection = conexcioBD.BDcomun.ObtenerConexion();
          

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            MySqlTransaction myTrans;

            // iniciando la trasaccion
            myTrans = myConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            myCommand.Transaction = myTrans;

            try
            {
                myCommand.CommandText = "insert into tabt_detalleformu values(@cod_formu,@cod_mp,@precio,@cantidad_formu,@estado_formu)";
               
                string cadena = cbo_estaf.SelectedItem.ToString();
                string cadena2 = txt_codf.Text;
              string cad = numericUpDown1.Value.ToString();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    myCommand.Parameters.Clear();

                    myCommand.Parameters.AddWithValue("@cod_formu", Convert.ToString(cadena2));
                    myCommand.Parameters.AddWithValue("@cod_mp", Convert.ToString(row.Cells["cod_materiaprima"].Value));
                    myCommand.Parameters.AddWithValue("@precio", Convert.ToString(row.Cells["precio"].Value));
                    myCommand.Parameters.AddWithValue("@cantidad_formu", Convert.ToString(row.Cells["Cantidad"].Value));
                    myCommand.Parameters.AddWithValue("@estado_formu", Convert.ToString(cadena));
                    myCommand.CommandTimeout = 0;

                    myCommand.ExecuteNonQuery();
                    
                }

                string nombref = txt_nomf.Text;
                string unidadf = cbo_unif.SelectedItem.ToString();
                string preciof = txt_preciou.Text;
                myCommand.CommandText = "INSERT INTO tabm_formula(cod_formu,descrip_formu,unidad_formu,costouni_formu,estado_formu) Values('"+cadena2+"','"+nombref+"','"+unidadf+"','"+preciof+"','"+cadena+"')";
                myCommand.ExecuteNonQuery();
               /* myCommand.CommandText = ")";
                myCommand.ExecuteNonQuery();*/
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
            #endregion

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            #region buscad de materia prima
            string fieldName = string.Concat("[", dgv.obtemp().Columns[1].ColumnName, "]");
            dgv.obtemp().DefaultView.Sort = fieldName;
            DataView view = dgv.obtemp().DefaultView;
            view.RowFilter = string.Empty;
            if (textBox1.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + textBox1.Text + "%'";
            dgv_materiaprima.DataSource = view;
            #endregion
        }

        private void txt_preciou_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {

            this.dataGridView2.Rows.Clear();

            #region  guardar detalle formula
            MySqlConnection myConnection = conexcioBD.BDcomun.ObtenerConexion();
          

            MySqlCommand myCommand = new MySqlCommand();
            myCommand.Connection = myConnection;
            MySqlTransaction myTrans;

            // iniciando la trasaccion
            myTrans = myConnection.BeginTransaction(IsolationLevel.ReadCommitted);
            myCommand.Transaction = myTrans;

            try
            {
                myCommand.CommandText = "insert into tabt_detalleformu values(@cod_formu,@cod_mp,@precio,@cantidad_formu,@estado_formu)";
               
                string cadena = cbo_estaf.SelectedItem.ToString();
                string cadena2 = txt_codf.Text;
                string cad = numericUpDown1.Value.ToString();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    myCommand.Parameters.Clear();

                    myCommand.Parameters.AddWithValue("@cod_formu", Convert.ToString(cadena2));
                    myCommand.Parameters.AddWithValue("@cod_mp", Convert.ToString(row.Cells["cod_materiaprima"].Value));
                    myCommand.Parameters.AddWithValue("@precio", Convert.ToString(row.Cells["precio"].Value));
                    myCommand.Parameters.AddWithValue("@cantidad_formu", Convert.ToString(row.Cells["Cantidad"].Value));
                    myCommand.Parameters.AddWithValue("@estado_formu", Convert.ToString(cadena));
                    myCommand.CommandTimeout = 0;

                    myCommand.ExecuteNonQuery();
                    
                }

               /* string nombref = txt_nomf.Text;
                string unidadf = cbo_unif.SelectedItem.ToString();
                string preciof = txt_preciou.Text;
                myCommand.CommandText = "INSERT INTO pruebam(cod_for,nom_for,uni_for,precio_for,esta_for) Values('"+cadena2+"','"+nombref+"','"+unidadf+"','"+preciof+"','"+cadena+"')";
                myCommand.ExecuteNonQuery();
               /* myCommand.CommandText = ")";
                myCommand.ExecuteNonQuery();*/
                myTrans.Commit();
                MessageBox.Show("Los Datos Se Han Guardado Exitosamente");
                dataGridView2.Enabled = false;
                numericUpDown1.Enabled = false;
                cbo_unif.Enabled = false;
                cbo_estaf.Enabled = false;
                
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
            #endregion

        }

        private void cbo_estaf_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region combo estado
            switch (cbo_estaf.SelectedIndex)
            {
                case 0: txt_estado.Text = "1";
                    break;
                case 1: txt_estado.Text = "0";
                    break;
                default: break;
            }
            #endregion
        }

        private void cbo_unif_SelectedIndexChanged(object sender, EventArgs e)
        {
           // cbo_estaf.Text = txtestado.Text;
            txtestado.Text = cbo_unif.Text;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txt_preciou.Enabled = false;
            txt_codf.Enabled = false;
            dgv_materiaprima.Enabled = true;
            btn_agregar.Enabled = true;
            btn_quitar.Enabled = true;
            dataGridView2.Enabled = true;
            numericUpDown1.Enabled = true;
            cbo_unif.Enabled = true;
            cbo_estaf.Enabled = true;
            navegador1.btnLimpiar.Enabled = false;
            
            codigof();
        }

        
    }

}
#endregion