/* Autor: Daniel Isaias Moreno
 * Fecha: 16/05/2015
 * Comentario: Moodulo de ingreso de Documentos 
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
    public partial class wfDocumento : Form
    {
        public int iTipo;
        public string sQuery= String.Empty;
        public string sCodigo = string.Empty;
        public int iCodigo;
        public ArrayList alDatosSalida;
        DataTable dtCodigoFactura = new DataTable();
        DataTable dtClienteProveedor = new DataTable();
        BindingSource bsClienteProveedor = new BindingSource();
        public double fPrecioSinIva =0;
        public double fImpuesto = 0;
        public wfDocumento()
        {
            InitializeComponent();
        }

        private void wfDocumento_Load(object sender, EventArgs e)
        {            
            btnIngresarDocto.Enabled = true;          
            switch (iTipo)
            {
                case 0: this.Text = "Compra"; this.lblProCte.Text = "Código Proveedor"; break;
                case 1: this.Text = "Venta"; this.lblProCte.Text = "Código Cliente";  break;
            }            
            this.iCodigo = sObtenerCodigo();
            txtCodFact.Text = iCodigo.ToString();
            string sQueryProCte = "Select nit_prov_cte FROM tabm_prov_cte where descrip="+iTipo+" and estado_prov_cte=1";
            dtClienteProveedor = Capas.csNegocio.dtConsultarRegistros(sQueryProCte);
            bsClienteProveedor.DataSource = dtClienteProveedor;       
        }

        private void btnIngresarDocto_Click(object sender, EventArgs e)
        {            
            sQuery = "," + Convert.ToInt32(txtCod_ProvCte.Text) + "," + iTipo + ",'" + txtTipoDocto.Text + "','" + txtNoDocto.Text + "','" + txtFechDocto.Text + "'," +  Math.Round(fPrecioSinIva,0) + "," + Math.Round(Convert.ToSingle(txtImpuesto.Text), 0).ToString() + "," + Convert.ToSingle(txtTotal.Text) + "";
            fImpuesto = Math.Round(Convert.ToSingle(txtImpuesto.Text), 0);
            btnIngresarDocto.Enabled = false;
            this.Hide();           
        }

        
        private void txtPrecioDocto_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                double iPrecioSinIva = Convert.ToSingle(txtPrecioDocto.Text.ToString()) / 1.12;
                fPrecioSinIva = iPrecioSinIva;
                double iImpuesto = iPrecioSinIva * 0.12;
                txtImpuesto.Text = iImpuesto.ToString();
                double dTotal = iPrecioSinIva + iImpuesto;
                txtTotal.Text = dTotal.ToString();
            }
            catch 
            { 
            
            }            
        }

        private int sObtenerCodigo()
        {
            string sQuery = "select * from tabm_factura";
            int iCodigo = 0;
            ArrayList alDatosEntrada = ODBCconnector.csFunciones.alConsultarQuery(sQuery);
            if (alDatosEntrada != null && alDatosEntrada.Count != 0)
            {
                ArrayList alFila = (ArrayList)alDatosEntrada[alDatosEntrada.Count - 1];
                iCodigo = Convert.ToInt32(alFila[0]) + 1;
            }
            else
            {
                iCodigo = 1;
            }
            return iCodigo;
        }

       

        private void txtCod_ProvCte_Click(object sender, EventArgs e)
        {
            wfProCte codigo = new wfProCte();
            codigo.ShowDialog();
            txtCod_ProvCte.Text = codigo.sCodigo;
        }

        private void txtPrecioDocto_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }        
    }
}
