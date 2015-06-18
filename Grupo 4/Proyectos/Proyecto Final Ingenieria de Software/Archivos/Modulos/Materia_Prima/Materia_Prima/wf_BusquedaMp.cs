using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//Abner Josue Rodas 
//Grupo 4
//Busqueda de Materia Prima


namespace Materia_Prima
{
    public partial class wf_BusquedaMp : Form
    {
        cs_Negocio cbo3 = new cs_Negocio();

        public wf_BusquedaMp()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string fieldName = string.Concat("[", cbo3.obtDatosMateriaPrima().Columns[1].ColumnName, "]");
            cbo3.obtDatosMateriaPrima().DefaultView.Sort = fieldName;
            DataView view = cbo3.obtDatosMateriaPrima().DefaultView;
            view.RowFilter = string.Empty;
            if (textBox1.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + textBox1.Text + "%'";
            dgv_BMateriaPrima.DataSource = view;

            int fila;
            fila = Convert.ToInt32(dgv_BMateriaPrima.RowCount.ToString()) - 1;

            label3.Text = fila.ToString();

        }

        private void wf_BusquedaMp_Load(object sender, EventArgs e)
        {
            //asignando datatable al dataGridView
            dgv_BMateriaPrima.DataSource = cbo3.obtDatosMateriaPrima();



            int fila;
            fila = Convert.ToInt32(dgv_BMateriaPrima.RowCount.ToString()) - 1;

            label3.Text = fila.ToString();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar !=(char)Keys.Separator))
              {
                  MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  e.Handled = true;
                  return;



              }*/
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    if (Char.IsSeparator(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        e.Handled = true;
                    }

        }



    }
}