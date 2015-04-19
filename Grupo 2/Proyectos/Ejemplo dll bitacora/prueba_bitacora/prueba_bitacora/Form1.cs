using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_bitacora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grid_con_busqueda frm = new grid_con_busqueda();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grid_normal frm = new grid_normal();
            frm.ShowDialog();
        }
    }
}
