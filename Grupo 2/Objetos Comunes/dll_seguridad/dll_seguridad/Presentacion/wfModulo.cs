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
    public partial class wfModulo : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfModulo()
        {
            InitializeComponent();
        }

        private void wfModulo_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIDModulo);
            alDatosEntrada.Add(txtNombreMod);
            alDatosEntrada.Add(txtNombreDLL);
            alDatosEntrada.Add(txtfecc);
            alDatosEntrada.Add(txtfecm);
            alDatosEntrada.Add(txtestado);
            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();            
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbEstado.SelectedIndex)
            {
                case 0: txtestado.Text = "1"; break;
                case 1: txtestado.Text = "0"; break;
                default: txtestado.Text = String.Empty; break;
            }
        }

        private void txtestado_TextChanged(object sender, EventArgs e)
        {
            switch (txtestado.Text)
            {
                case "1": cbEstado.SelectedIndex = 0; break;
                case "0": cbEstado.SelectedIndex = 1; break;
                default: cbEstado.SelectedIndex= -1; break;
            }
        }

        private void navegador1_btnNuevo_AfterClick(object sender, EventArgs e)
        {
            txtfecc.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtIDModulo.Enabled = false;
            txtfecc.Enabled = txtfecm.Enabled = false;
            
        }

        private void navegador1_btnModificar_AfterClick(object sender, EventArgs e)
        {
            txtfecm.Text = DateTime.Now.ToString("yyyy/MM/dd");
            txtIDModulo.Enabled = false;
            txtfecc.Enabled = txtfecm.Enabled = false;
        }

        public void AplicarIdioma()
        {
            lblIDmodulo.Text = StringResources.Label12;
            lblNomDLL.Text = StringResources.Label13;
            lblEstado.Text = StringResources.Label14;
            lblNomModulo.Text = StringResources.Label15;
            lblfecC.Text = StringResources.Label16;
            lblfecm.Text = StringResources.Label17;
           

            this.Text = StringResources.WindowTitle3;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo((string)listBox1.SelectedItem);
            AplicarIdioma();
        }
    }
}
