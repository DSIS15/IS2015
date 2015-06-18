using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Abner Josue Rodas 
//Grupo 4
//Busqueda de Pedido

namespace Materia_Prima
{
    public partial class wf_BusquedaPed : Form
    {
        cs_Negocio cbo = new cs_Negocio();
        public wf_BusquedaPed()
        {
            InitializeComponent();
        }


        private void wf_BusquedaPed_Load(object sender, EventArgs e)
        {

            //llenado el datagridview
            dataGridView1.DataSource = cbo.obtDatosPedido();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string fieldName = string.Concat("[", cbo.obtDatosPedido().Columns[1].ColumnName, "]");
            cbo.obtDatosPedido().DefaultView.Sort = fieldName;
            DataView view = cbo.obtDatosPedido().DefaultView;
            view.RowFilter = string.Empty;
            if (textBox1.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = view;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}