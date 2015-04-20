﻿using System;
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
    public partial class wfSubMod : Form
    {

        private ArrayList alDatosEnviados = new ArrayList();
        public wfSubMod()
        {
            InitializeComponent();
        }

        private void wfSubMod_Load(object sender, EventArgs e)
        {
            //Datos del Navegador
            alDatosEnviados.Add(txtIDSubMod);
            alDatosEnviados.Add(txtIDMod);
            alDatosEnviados.Add(txtNomSubMod);
            alDatosEnviados.Add(txtNomForm);
            alDatosEnviados.Add(txtfecc);
            alDatosEnviados.Add(txtfecm);
            alDatosEnviados.Add(txtEstado);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            /////////////////////////////////////

            //Datos del Grid 
            String[,] sCadena={
                              {"id_modulo","Código","true"},
                              {"nombre_modulo","Nombre","true"},
                              {"nombre_dll","Nombre_DLL","false"},
                              {"fecha_creacion","Fecha Creación","true",},
                              {"fecha_modificacion","Fecha Modificación","true",},
                              {"estado","Estado","true"},                              
                              };
            cuDataGridD1.AlDatosEntrada.Add(sCadena);
            cuDataGridD1.vinicializar();
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstado.Text)
            {
                case "1": cbestado.SelectedIndex = 0; break;
                case "0": cbestado.SelectedIndex = 1; break;
                default: cbestado.SelectedIndex = -1; break;
            }
        }

        private void cbestado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbestado.SelectedIndex)
            {
                case 0: txtEstado.Text = "1"; break;
                case 1: txtEstado.Text = "0"; break;
                default: txtEstado.Text = String.Empty; break;
            }
        }

        private void cuDataGridD1_sdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDMod.Text = cuDataGridD1.SObtenerDato;
        }

        private void cuDataGridD1_Load(object sender, EventArgs e)
        {

        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtfecc.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfecc.Enabled = txtfecm.Enabled = false;
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfecc.Enabled = txtfecm.Enabled = false;
        }

        public void AplicarIdioma()
        {
            lblIDSubMod.Text = StringResources.Label29;
            lblIDMod.Text = StringResources.Label30;
            lblEstadoSubMod.Text = StringResources.Label31;
            lblNomSubMod.Text = StringResources.Label32;
            lblNomwf.Text = StringResources.Label33;
            lblfeccSubMod.Text = StringResources.Label34;
            lblfecmSubMod.Text = StringResources.Label35;


            this.Text = StringResources.WindowTitle6;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((string)listBox1.SelectedItem);
            AplicarIdioma();
        }
    }
}
