using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_idioma.Presentacion
{
    public partial class cuIdioma : UserControl
    {
        //variable para obtener la información del idioma del combobox
       
        private String sobteneridioma;
        private Negocio.csN_Cambiodeidioma csn_cambiodeidioma = new Negocio.csN_Cambiodeidioma();

        public cuIdioma()
        {
            InitializeComponent();
            
        }

        private void cuIdioma_Load(object sender, EventArgs e)
        {
                      
           cbidioma.SelectedIndex = 0;
        }

        private void cbidioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            csp_cambiodeidioma.sobteneridioma = sobteneridioma = (string)cbidioma.SelectedItem;
            //MessageBox.Show(sobteneridioma);
            csn_cambiodeidioma.vObtenerdatosformulario(sobteneridioma);
        }

        public void vinicializaridioma(Form frmFormulario)
        {            
            csn_cambiodeidioma.vObtenerdatosformulario(sobteneridioma, frmFormulario);
        }
    }
}
