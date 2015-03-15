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

namespace dll_seguridad.Presentacion
{
    public partial class wfUsuario : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfUsuario()
        {
            InitializeComponent();
        }

        private void wfUsuario_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIDUsuario);
            alDatosEntrada.Add(txtCodPerfil);
            alDatosEntrada.Add(txtAlias);
            alDatosEntrada.Add(txtContraseña);
            alDatosEntrada.Add(txtNomUsuario);
            alDatosEntrada.Add(txtPrimerAp);
            alDatosEntrada.Add(txtSegundoAp);
            alDatosEntrada.Add(txtDireccion);
            alDatosEntrada.Add(txtEstado);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbEstado.SelectedIndex)
            {
                case 0: txtEstado.Text="1"; break;
                case 1: txtEstado.Text="0"; break;
                default:txtEstado.Text= string.Empty; break;
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado.Text)
            {
                case "0": cbEstado.SelectedIndex = 1; break;
                case "1": cbEstado.SelectedIndex = 0; break;
                default: cbEstado.SelectedIndex = -1; break;
            }
        }
    }
}
