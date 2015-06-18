using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;

// Abner Josue Rodas
// Grupo 4
// DLL MATERIA PRIMA


namespace Materia_Prima
{
    public partial class wf_MateriaPrima : Form
    {
        cs_Negocio cbo = new cs_Negocio();
        ArrayList EnviaDatos = new ArrayList();
        
        public wf_MateriaPrima()
        {
          
            InitializeComponent();
        }
        
        public void vinicializar()
        {
            navegador1.btnEliminar.Enabled = false;
            navegador1.btnGuardar.Enabled = false;
            navegador1.btnModificar.Enabled = false;
            navegador1.btnNuevo.Enabled = false;
        }
        private void wf_MateriaPrima_Load(object sender, EventArgs e)
        {
            EnviaDatos.Add(txtcod_mp);
            EnviaDatos.Add(txtnom_mp);
            EnviaDatos.Add(txtunidm_mp);
            EnviaDatos.Add(txtcant_mp);
            EnviaDatos.Add(txtprecio_mp);


            navegador1.alDatosEntrada = EnviaDatos;
            navegador1.vIniciarNavegador();

        }


        private void navegador1_btnNuevo_BeforeClick(object sender, EventArgs e)
        {
            txtcod_mp.Visible = false;
            lblcodmp.Visible = false;
        }

        private void txtnom_mp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcant_mp_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wf_BusquedaMp BuscaMp = new wf_BusquedaMp();
            BuscaMp.Show();
        }


//        private void button1_Click(object sender, EventArgs e)
  //      {
    //        wf_BusquedaMp Empresa = new wf_BusquedaMp();
      //      Empresa.Show();

//        }

    }
}
