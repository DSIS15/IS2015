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
using System.Security.Cryptography;

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
            //Datos del navegador
            alDatosEntrada.Add(txtIDUsuario);
            alDatosEntrada.Add(txtCodPerfil);
            alDatosEntrada.Add(txtIDRoll);
            alDatosEntrada.Add(txtAlias);
            alDatosEntrada.Add(txtEncriptar);
            alDatosEntrada.Add(txtNomUsuario);
            alDatosEntrada.Add(txtPrimerAp);
            alDatosEntrada.Add(txtSegundoAp);
            alDatosEntrada.Add(txtDireccion);
            alDatosEntrada.Add(txtfechcrea);
            alDatosEntrada.Add(txtfechmod);
            alDatosEntrada.Add(txtEstado);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
            /////////////////////////////////////////////////////////

            //datos del grid Perfil
            //Datos Grid Perfil
            String[,] Scadena ={{"codigo_perfil","Codigo","true"},
                                {"nombre_perfil","Nombre","true"},
                                {"fecha_creacion","Fecha Creación","true",}, 
                                {"fecha_modificacion","Fecha Modificación","true",},
                                {"estado","Estado","false"}
                              };
            cuDataGridD1.AlDatosEntrada.Add(Scadena);
            cuDataGridD1.vinicializar();
            ////////////////////////////////////////////////////

            //Datos del grid Roll
            String[,] Scadena2 ={{"id_roll","Codigo","true"},
                                 {"nombre_roll","Nombre","true"},
                                 {"descripcion","descripcion","false"},
                                 {"fecha_creacion","Fecha Creacion","true"},
                                 {"fecha_modificacion","Fecha Modificación","true"},
                                 {"estado","Estado","true"}
                               };
            cuDataGridD2.AlDatosEntrada.Add(Scadena2);
            cuDataGridD2.vinicializar();
            /////////////////////////////////////////////////////////

            
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

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodPerfil.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD1_Load(object sender, EventArgs e)
        {

        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDRoll.Text = cuDataGridD2.SObtenerDato;
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {            
            txtfechcrea.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfechmod.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtIDUsuario.Enabled = false;
            txtCodPerfil.Enabled = false;
            txtIDRoll.Enabled = false;
            txtfechcrea.Enabled = txtfechmod.Enabled = false;
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            txtfechmod.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtIDUsuario.Enabled = false;
            txtCodPerfil.Enabled = false;
            txtIDRoll.Enabled = false;
            txtfechcrea.Enabled = txtfechmod.Enabled = false;
        }

        private void buttonEncriptar (object sender, EventArgs e)
        {
            string login_pass = txtContraseña.Text;
            MD5 md5 = MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(login_pass);
            byte[] hash = md5.ComputeHash(inputBytes);
            login_pass = BitConverter.ToString(hash).Replace("-", "");
            txtEncriptar.Text = login_pass.ToString();
        }
    }
}
