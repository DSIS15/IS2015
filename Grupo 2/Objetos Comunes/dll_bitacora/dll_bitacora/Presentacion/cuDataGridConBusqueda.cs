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

        public int iCount
        {
            get { return dgvTabla.ColumnCount; }            
        }

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
                        
                        dgvTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                       
                        cbCampos.DataSource = csn_obtenercampos.cbllenarcombo(alDatosEntrada).Items;
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

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            BindingSource bsBusqueda = new BindingSource();
            bsBusqueda.DataSource = dgvTabla.DataSource;            
            bsBusqueda.Filter = cbCampos.SelectedItem.ToString() + " LIKE '%" + txtbusqueda.Text + "%'";
            dgvTabla.DataSource = bsBusqueda;

        }
    }
}
