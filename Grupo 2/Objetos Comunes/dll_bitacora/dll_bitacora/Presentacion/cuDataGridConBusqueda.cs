using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_bitacora.Presentacion
{
    public partial class cuDataGridConBusqueda : UserControl
    {
        private Negocio.cs_NCamposyDatos csn_obtenercampos = new Negocio.cs_NCamposyDatos();
        private ArrayList alDatosEntrada = new ArrayList();
        private ArrayList alDatosNombre = new ArrayList();
        private String sTabla = string.Empty;

        public String STabla
        {
            get { return sTabla; }
            set { sTabla = value; }
        }

        public ArrayList AlDatosEntrada
        {
            get { return alDatosEntrada; }
            set { alDatosEntrada = value; }
        }
        public cuDataGridConBusqueda()
        {
            InitializeComponent();
        }

        private void cuDataGridConBusqueda_Load(object sender, EventArgs e)
        {

        }


        public void vinicializar()
        {
            if (String.Compare(STabla, string.Empty) != 0)
            {
                if (alDatosEntrada.Count > 0)
                {
                    if (csn_obtenercampos.bCompararCampos(alDatosEntrada, STabla) == true)
                    {                        
                        dgvTabla.DataSource = csn_obtenercampos.dtNCamposyDatos(alDatosEntrada, STabla);
                        //cbCampos.Items.Add(csn_obtenercampos.cbllenarcombo(alDatosEntrada));
                        //cbCampos.DataSource = 
                        cbCampos.DataSource = csn_obtenercampos.cbllenarcombo(alDatosEntrada).Items;
;
                        
                        //cbCampos.DataSource = 
                    }
                    else
                    {
                        MessageBox.Show("Los Campos no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("AlDatosEntrada vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de STabla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
