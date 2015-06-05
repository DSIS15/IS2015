using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIP_Administrativo
{
    public partial class wf_Busquedacte : Form
    {
        cs_Negocio cbo = new cs_Negocio();
        public wf_Busquedacte()
        {
            InitializeComponent();
        }

        private void wf_Busquedacte_Load(object sender, EventArgs e)
        {
            //llenado el datagridview
            dataGridView1.DataSource = cbo.obtDatosClientes();

            int fila;
            fila = Convert.ToInt32(dataGridView1.RowCount.ToString()) - 1;

            label3.Text = fila.ToString();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
             string fieldName = string.Concat("[", cbo.obtDatosClientes().Columns[1].ColumnName, "]");
            cbo.obtDatosClientes().DefaultView.Sort = fieldName;
            DataView view = cbo.obtDatosClientes().DefaultView;
            view.RowFilter = string.Empty;

            if (textBox1.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = view;

            int fila;
            fila = Convert.ToInt32(dataGridView1.RowCount.ToString()) - 1;

            label3.Text = fila.ToString();

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
