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
    public partial class cuDataGridD : UserControl
    {
        private Negocio.cs_NCamposyDatos csn_obtenercampos = new Negocio.cs_NCamposyDatos();
        private ArrayList alDatosEntrada = new ArrayList();
        private ArrayList alDatosNombre = new ArrayList();
        private String sTabla = string.Empty;
        private String sCampo = string.Empty;
        private String sObtenerDato = string.Empty;
        public event DataGridViewCellEventHandler sdgv_CellClick;
        

        public String SObtenerDato
        {
            get { return sObtenerDato; }            
        }

        public String SCampo
        {
            get { return sCampo; }
            set { sCampo = value; }
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
        
        public cuDataGridD()
        {
            InitializeComponent();
            
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cuBitacora_Load(object sender, EventArgs e)
        {
            
        }

        public void vinicializar()
        {
            if (String.Compare(STabla, string.Empty) != 0)
            {
                if (alDatosEntrada.Count > 0)
                {
                    if (csn_obtenercampos.bCompararCampos(alDatosEntrada, sTabla) == true)
                    {
                        //Comentado haciendo pruebas
                        //MessageBox.Show(alDatosEntrada[0].ToString());                        
                        dgvTabla.DataSource = csn_obtenercampos.dtNCamposyDatos(alDatosEntrada, STabla);
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
                    MessageBox.Show("Ingrese el nombre de STabla","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Application.Exit();
                }
            
        }

        private void dgvTabla_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
           
        }
        
        private void dgvTabla_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dgvTabla.Rows[e.RowIndex].Cells[SCampo].Value.ToString());
            sObtenerDato = dgvTabla.Rows[e.RowIndex].Cells[SCampo].Value.ToString();
           //MessageBox.Show(sObtenerDato);
            sdgv_CellClick(this,e);
            
        }
    }
}
