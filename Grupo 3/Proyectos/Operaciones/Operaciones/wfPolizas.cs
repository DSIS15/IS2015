using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contable
{
    public partial class wfPolizas : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        public string sCodigo = string.Empty;

        public wfPolizas()
        {
            InitializeComponent();
        }

        private void wfPolizas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsDatos.dtPoliza' Puede moverla o quitarla según sea necesario.
            this.dtaPoliza.Fill(this.dsDatos.dtPoliza);
            
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();

        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            if (!Capas.csNegocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!navegador1.bValidarTeclasFuncion(ref msg, keyData))
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
            else
            {
                return true;
            }
        }

        private void txtEstadoPza_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoPza.Text)
            {
                case "1": cboEstadoPza.SelectedIndex = 0; break;
                case "0": cboEstadoPza.SelectedIndex = 1; break;
                default: cboEstadoPza.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoPza_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoPza.SelectedIndex) 
            {
                case 0: txtEstadoPza.Text = "1"; break;
                case 1: txtEstadoPza.Text = "0"; break;
                default: txtEstadoPza.Text = string.Empty; break;
            }
        }

    }
}
