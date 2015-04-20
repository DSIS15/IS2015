using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using dll_seguridad.Recursos_localizables;
using System.Threading;
using System.Globalization;

namespace dll_seguridad.Presentacion
{
    public partial class wfPerfiles : Form
    {
        private DateTime DTFecha = new DateTime();
        private ArrayList alDatosEntrada = new ArrayList();




        public wfPerfiles()
        {
            InitializeComponent();
        }

        private void wfPerfil_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtCodPerfil);
            alDatosEntrada.Add(txtNombre);
            alDatosEntrada.Add(txtfech);
            alDatosEntrada.Add(txtfecm);
            alDatosEntrada.Add(txtEstado);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
            //txtfech.Text = DTFecha.ToString("dd/MM/yyyy");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEstado.SelectedIndex)
            { 
                case 0: txtEstado.Text="1"; break;
                case 1: txtEstado.Text="0"; break;
                default: txtEstado.Text=String.Empty; break;
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado.Text)
            {
                case "1": cbEstado.SelectedIndex = 0; break;
                case "0": cbEstado.SelectedIndex = 1; break;
                default: cbEstado.SelectedIndex = -1; break;
            }
        }

        private void navegador1_btnModificar_BeforeClick(object sender, EventArgs e)
        {
            
            
        }

       

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {           
            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfecm.Enabled = false;
            txtfech.Enabled = false;
            txtCodPerfil.Enabled = false;
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtfech.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfecm.Enabled = false;
            txtfech.Enabled = false;
            txtCodPerfil.Enabled = false;
        }

        public void AplicarIdioma()
        {
            lblCodPerfil.Text = StringResources.Label18;
            lblEstadoPerf.Text = StringResources.Label19;
            lblNombre_perfil.Text = StringResources.Label20;
            lblfecCreaPerf.Text = StringResources.Label21;
            lblfecmPerf.Text = StringResources.Label22;
            


            this.Text = StringResources.WindowTitle3;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((string)listBox1.SelectedItem);
            AplicarIdioma();
        }
    }
}
