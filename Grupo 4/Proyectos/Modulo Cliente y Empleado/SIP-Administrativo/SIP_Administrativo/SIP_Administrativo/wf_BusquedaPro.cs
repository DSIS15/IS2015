using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Jose Ambrosio 
//0901-07-3573
//Busqueda Proveedores
namespace SIP_Administrativo
{
    public partial class wf_BusquedaPro : Form
    {
        cs_Negocio cbo = new cs_Negocio();

        public wf_BusquedaPro()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string fieldName = string.Concat("[", cbo.obtDatosProveedor().Columns[1].ColumnName, "]");
            cbo.obtDatosProveedor().DefaultView.Sort = fieldName;
            DataView view = cbo.obtDatosProveedor().DefaultView;
            view.RowFilter = string.Empty;
            if (textBox1.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + textBox1.Text + "%'";
            dgv_Bproveedores.DataSource = view;

            int fila;
            fila = Convert.ToInt32(dgv_Bproveedores.RowCount.ToString()) - 1;

            label3.Text = fila.ToString();
            
        }

        private void wf_BusquedaPro_Load(object sender, EventArgs e)
        {
            //asignando datatable al dataGridView
            dgv_Bproveedores.DataSource = cbo.obtDatosProveedor();



        int fila;
            fila = Convert.ToInt32(dgv_Bproveedores.RowCount.ToString())-1;

            label3.Text = fila.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Bproveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
