using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion_Bitacora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            String[,] sCadena = {
                                    {"ID_Bitacora","ID","true"},
                                    {"Hostname","Hostname","true"},
                                    {"IP","IP","true"},
                                    {"Fecha_Hora","Fecha/Hora","true"},
                                    {"Descripcion","Descripción","true"}
                                };
            cuDataGridConBusqueda1.AlDatosEntrada.Add(sCadena);
            cuDataGridConBusqueda1.vinicializar();
            
        }
    }
}
