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
using System.Threading;
using System.Globalization;

namespace dll_seguridad.Presentacion
{
    public partial class wfUsuario : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfUsuario()
        {
            InitializeComponent();
            String[,] Scadena ={{"codigo_perfil","Codigo","true"},
                                {"nombre_perfil","Nombre","true"},
                                {"fecha_creacion","Fecha_Creación","true",}, 
                                {"fecha_modificacion","Fecha_Modificación","true",},
                                {"estado","Estado","false"}
                              };
            dgvperfil.AlDatosEntrada.Add(Scadena);
        }

        private void wfUsuario_Load(object sender, EventArgs e)
        {
            //Datos del navegador
            alDatosEntrada.Add(txtIDUsuario);
            alDatosEntrada.Add(txtCodPerfil);
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
            txtContraseña.Enabled = false;
            /////////////////////////////////////////////////////////

            //datos del grid Perfil
            //Datos Grid Perfil

            dgvperfil.vinicializar();
            ////////////////////////////////////////////////////

            //Datos del grid Roll
            
           
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
            txtCodPerfil.Text = dgvperfil.SObtenerDato;
        }

        private void cuDataGridD1_Load(object sender, EventArgs e)
        {

        }

        private void cuDataGridD2_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void s(object sender, EventArgs e)
        {

        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se agrego un registro en usuario");

            txtfechcrea.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtfechmod.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIDUsuario.Enabled = false;
            txtCodPerfil.Enabled = false;
            
            txtfechcrea.Enabled = txtfechmod.Enabled = false;
            txtContraseña.Enabled = false;
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se modifico un registro en usuario");

            txtfechmod.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtIDUsuario.Enabled = false;
            txtCodPerfil.Enabled = false;
            
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

        

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            //byte[] byEncriptado = Encoding.Unicode.GetBytes(txtContraseña.Text);
            //txtEncriptar.Text = Convert.ToBase64String(byEncriptado);
        }

        private void txtEncriptar_TextChanged(object sender, EventArgs e)
        {
            txtContraseña.Text = txtEncriptar.Text;            
            //byte[] byDesencriptar = Convert.FromBase64String(txtEncriptar.Text);
           //txtEncriptar.Text = Encoding.Unicode.GetString(byDesencriptar);
        }

        private void navegador1_btnGuardar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se guardo un registro en usuario");
            
            txtContraseña.Enabled = false; 
        }

        private void cuDataGridD1_sdgv_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtCodPerfil.Text = dgvperfil.SObtenerDato;
        }

        private void navegador1_btnBuscar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se busco un registro en usuario");
        }

        private void navegador1_btnEliminar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se elimino un registro en usuario");
        }

        private void navegador1_btnLimpiar_AfterClick(object sender, EventArgs e)
        {
            dll_bitacora.Presentacion.cs_PInsercionBitacora.vinsertar("Se limpiaron registros en usuario");
        }
    }
}
