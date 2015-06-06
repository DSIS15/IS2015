/* Autor: Daniel Isaias Moreno
 * Fecha: 16/05/2015
 * Comentario: Moodulo de ingreso de Clientes y Proveedores
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Compras_Ventas
{
    public partial class wfProCte : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;
        
        public wfProCte()
        {
            InitializeComponent();
        }

        private void wfProCte_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodProv_Cte);
            alDatosEnviados.Add(txtNombreProvCte);
            alDatosEnviados.Add(txtNitProCte);
            alDatosEnviados.Add(txtDescripProCte);
            alDatosEnviados.Add(txtDirProvCte);
            alDatosEnviados.Add(txtTelProCte);
            alDatosEnviados.Add(txtEstadoProCte);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
        }

        private void cboEstadoProCte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ( this.cboEstadoProCte.SelectedIndex)
            {
                case 0: txtEstadoProCte.Text = "1"; break;
                case 1: txtEstadoProCte.Text = "0"; break;
                default: txtEstadoProCte.Text = string.Empty; break;
            }
        }

        private void txtEstadoProCte_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoProCte.Text)
            {
                case "0": cboEstadoProCte.SelectedIndex = 1; break;
                case "1": cboEstadoProCte.SelectedIndex = 0; break;
                default: cboEstadoProCte.SelectedIndex = -1; break;
            }
        }

        private void txtCodProv_Cte_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodProv_Cte.Text;
        }

        private void cboProCte_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cboProCte.SelectedIndex)
            {
                case 0: txtDescripProCte.Text = "0"; break;
                case 1: txtDescripProCte.Text = "1"; break;
                default: txtDescripProCte.Text = string.Empty; break;
            }
        }

        private void txtDescripProCte_TextChanged(object sender, EventArgs e)
        {
            switch (txtDescripProCte.Text)
            {
                case "0": this.cboProCte.SelectedIndex = 0; break;
                case "1": this.cboProCte.SelectedIndex = 1; break;
                default: this.cboProCte.SelectedIndex = -1; break;
            }
        }

        private void txtTelProCte_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e,"1234567890");
        }

    }
}
