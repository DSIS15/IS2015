using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIP_Administrativo
{
    public partial class wf_BusquedaEmp : Form
    {
        cs_Negocio cbo = new cs_Negocio();
        public wf_BusquedaEmp()
        {
            InitializeComponent();
        }

        private void wf_BusquedaEmp_Load(object sender, EventArgs e)
        {
            dgv_empleados.DataSource = cbo.obteemp();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            string fieldName = string.Concat("[", cbo.obteemp().Columns[2].ColumnName, "]");
            cbo.obteemp().DefaultView.Sort = fieldName;
            DataView view = cbo.obteemp().DefaultView;
            view.RowFilter = string.Empty;
            if (textBox1.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + textBox1.Text + "%'";
            dgv_empleados.DataSource = view;




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