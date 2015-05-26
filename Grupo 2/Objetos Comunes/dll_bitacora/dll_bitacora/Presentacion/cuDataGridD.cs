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
        private int iCampo = 0;       
        private String sObtenerDato = string.Empty;

       //Con esto se obtiene el número de campos mostrados
       public int Icount
        {
            get { return csn_obtenercampos.iObtenerCount(alDatosEntrada); }
        }
        //Se obtiene los datos enviados en formato arraylist
        public ArrayList alObtenerCampos 
        {
            get { return alDatosEntrada; }
            set { alDatosEntrada = value; }
        }

        public int ICampo
        {
            get { return iCampo; }
            set { iCampo = value; }
        }
        //evento personalizado
        public event DataGridViewCellEventHandler sdgv_CellClick;

        
        public String SObtenerDato
        {
            get { return sObtenerDato; }            
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
            if (String.Compare(STabla, string.Empty) != 0)//verifica si el Stabla esta vacio
            {
                if (alDatosEntrada.Count > 0) //verifica si alDatosEntrada esta vacio
                {
                    //compara si los datos de alDatosEntrada realmente existen en la tabla
                    if (csn_obtenercampos.bCompararCampos(alDatosEntrada, sTabla) == true)
                    {   
                        //construcción del datagriedview
                        cbCampos.DataSource = csn_obtenercampos.cbllenarcombo(alDatosEntrada).Items;
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

        //evento en el cual se obtiene el dato requerido 
       private void dgvTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                sObtenerDato = dgvTabla.Rows[e.RowIndex].Cells[ICampo].Value.ToString();
            }
           catch(Exception)
            {
           MessageBox.Show("Debe seleccionar un valor valido","Alerta",MessageBoxButtons.OK, MessageBoxIcon.Warning);
           }
                
                
           //creacion de un evento personalizado
            if (sdgv_CellClick != null)
                sdgv_CellClick(this, e);
            else
                MessageBox.Show("Debe de crear el evento sdgv_CellClick","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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
