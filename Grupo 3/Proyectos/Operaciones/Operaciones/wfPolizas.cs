/* Autor:       Andrea Gabriela Pérez Quiacain
 * Módulo:      Operaciones
 * Formulario:  Pólizas
 * Fecha:       02/06/2015 última actualización
 */
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Operaciones
{
    public partial class wfPolizas : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        string sQueriesDocumento = string.Empty;
        BindingSource bsDetallePlz = new BindingSource();
        BindingSource bsCuentasDplz = new BindingSource();
        DataTable dtDetallePlz = new DataTable();
        DataTable dtDetallePlzAux = new DataTable();
        DataTable dtCuentasDplz = new DataTable();
        public string sCodigo = string.Empty;
        private bool bModificar = false;
        private int iCorrelativo = 1;
        private int iCorrelativoFact = 0;
        private int iCodigoDocumento;
        String obtener = string.Empty;
        private int iobtenerCodigoCuenta;
        public double PsinIVA = 0;
        public double dImpuesto = 0;
        public wfPolizas()
        {
            InitializeComponent();
        }

        private void wfPolizas_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodigoPlz);
            alDatosEnviados.Add(txtNumPlz);
            alDatosEnviados.Add(txtFechemiPlz);
            alDatosEnviados.Add(txtDetallePlz);
            alDatosEnviados.Add(txtEstadoPlz);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Capas.csNegocio.SNombreTabla = navegador1.sNombreTabla;
            bsDetallePlz.DataSource = dtDetallePlz;
            dgvDplz.DataSource = bsDetallePlz;
        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            dtDetallePlzAux = dtDetallePlz;
            if ((!Capas.csNegocio.bValidarTextBoxes(alDatosEnviados)) || (string.Compare(txtCargos.Text,txtAbonos.Text) != 0))
            {
                MessageBox.Show("La poliza no está cuadrada");
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

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoPlz.SelectedIndex = 0;
            txtFechemiPlz.Text = dtpFechemiPlz.Text;
            txtNumPlz.Focus();            
            vLlenarCboCodigoDplz();
            vLlenarDetallePlz();
            cboCuentaDplz.SelectedIndex = 0;
            cboClasificacionDplz.SelectedIndex = 0;
        }
        
        private void txtFechemiPlz_TextChanged(object sender, EventArgs e)
        {
            dtpFechemiPlz.Text = txtFechemiPlz.Text;
        }

        private void dtpFechemiPlz_ValueChanged(object sender, EventArgs e)
        {
            txtFechemiPlz.Text = dtpFechemiPlz.Text;
        }

        private void cboEstadoPlz_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoPlz.SelectedIndex)
            {
                case 0: txtEstadoPlz.Text = "1"; break;
                case 1: txtEstadoPlz.Text = "0"; break;
                default: txtEstadoPlz.Text = string.Empty; break;
            }
        }

        private void txtEstadoPlz_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoPlz.Text)
            {
                case "1": cboEstadoPlz.SelectedIndex = 0; break;
                case "0": cboEstadoPlz.SelectedIndex = 1; break;
                default: cboEstadoPlz.SelectedIndex = -1; break;
            }
        }

        private void btnAgregarDplz_Click(object sender, EventArgs e)
        {
            if (string.Compare(txtSaldoDplz.Text, string.Empty) != 0)
            {
                switch (cboClasificacionDplz.SelectedIndex)
                {
                    case 0: dtDetallePlz.Rows.Add(cboCuentaDplz.SelectedValue, dtCuentasDplz.Rows[cboCuentaDplz.SelectedIndex][2].ToString(), iCorrelativo.ToString(), txtSaldoDplz.Text, "0", "1"); iCorrelativoFact = iCorrelativo;  break;
                    case 1: dtDetallePlz.Rows.Add(cboCuentaDplz.SelectedValue, dtCuentasDplz.Rows[cboCuentaDplz.SelectedIndex][2].ToString(), iCorrelativo.ToString(), "0", txtSaldoDplz.Text, "1"); iCorrelativoFact = iCorrelativo;  break;
                    default: break;
                }
                iCorrelativo++;
                dgvDplz.Refresh();
                cboCuentaDplz.SelectedIndex = 0;
                cboClasificacionDplz.SelectedIndex = 0;
                txtSaldoDplz.Text = string.Empty;
                cboCuentaDplz.Focus();
                vSaldos();
            }
            else
            {
                MessageBox.Show("Llene todos los campos", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCuentaDplz.Focus();
            }
        }

        private void vSaldos()
        {
            float sumac = 0;
            float sumaa = 0;
            for (int i = 0; i < dtDetallePlz.Rows.Count; i++)
            {
                sumac += Convert.ToSingle(dtDetallePlz.Rows[i][3].ToString());
                sumaa += Convert.ToSingle(dtDetallePlz.Rows[i][4].ToString());
            }
            txtCargos.Text = sumac.ToString();
            txtAbonos.Text = sumaa.ToString();
        }

        private void vLlenarDetallePlz()
        {
            dtDetallePlz = Capas.csNegocio.dtConsultarRegistros("select a.cod_cta, b.nomenc_cta, a.corr_dplz, a.cargo_dplz, a.abono_dplz, a.estado_dplz from tabt_dpoliza a, tabm_cuenta b where a.cod_cta=b.cod_cta and a.cod_plz ='" + txtCodigoPlz.Text + "'");
            if (dtDetallePlz.Rows.Count != 0)
            {
                dtDetallePlz.Columns[0].ColumnName = "Cuenta";
                dtDetallePlz.Columns[1].ColumnName = "Nomenclatura";
                dtDetallePlz.Columns[2].ColumnName = "Correlativo";
                dtDetallePlz.Columns[3].ColumnName = "Cargo";
                dtDetallePlz.Columns[4].ColumnName = "Abono";
                dtDetallePlz.Columns[5].ColumnName = "Estado";
             
            }
            else
            {
                dtDetallePlz.Columns.Add("Cuenta");
                dtDetallePlz.Columns.Add("Nomenclatura");
                dtDetallePlz.Columns.Add("Correlativo");
                dtDetallePlz.Columns.Add("Cargo");
                dtDetallePlz.Columns.Add("Abono");
                dtDetallePlz.Columns.Add("Estado");
            }
            bsDetallePlz.DataSource = dtDetallePlz;
            dgvDplz.DataSource = bsDetallePlz;
            dgvDplz.Columns[0].Width = 95;
            dgvDplz.Columns[1].Width = 96;
            dgvDplz.Columns[2].Width = 95;
            dgvDplz.Columns[3].Width = 95;
            dgvDplz.Columns[4].Width = 95;
            dgvDplz.Columns[5].Width = 95;
        }

        private void vLlenarCboCodigoDplz()
        {
            dtCuentasDplz = Capas.csNegocio.dtConsultarRegistros("select cod_cta, cuenta_cta, nomenc_cta from tabm_cuenta where estado_cta = 1 order by nomenc_cta asc");
            if (dtCuentasDplz.Rows.Count != 0)
            {
                dtCuentasDplz.Columns[0].ColumnName = "Código";
                dtCuentasDplz.Columns[1].ColumnName = "Cuenta";
                dtCuentasDplz.Columns[2].ColumnName = "Nomenclatura";
                bsCuentasDplz.DataSource = dtCuentasDplz;
                cboCuentaDplz.DataSource = bsCuentasDplz;
                cboCuentaDplz.DisplayMember = "Cuenta";
                cboCuentaDplz.ValueMember = "Código";
                cboCuentaDplz.Refresh();
                cboCuentaDplz.SelectedIndex = -1;
            }
        }

        private void txtCodigoPlz_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodigoPlz.Text;
            vLlenarDetallePlz();
        }

        private void navegador1_btnAfterGuardar(object sender, EventArgs e)
        {
            ArrayList alCodigoDetalle = new ArrayList();
            alCodigoDetalle.Add(txtCodigoPlz.Text); 
            Capas.csNegocio.SNombreTabla = "tabt_dpoliza";
            dtDetallePlz = dtDetallePlzAux;
            dtDetallePlzAux.Columns.RemoveAt(1);
            if(bModificar)
            {
                Capas.csNegocio.vModificarRegistros(alCodigoDetalle, dtDetallePlzAux);
                bModificar = false;
            }
            else
            {
                Capas.csNegocio.vInsertarRegistros(alCodigoDetalle, dtDetallePlzAux);
            }
            vLlenarDetallePlz();
            int iObtenerCorrelativo=0;
            for (int x = 0; x < dtDetallePlz.Rows.Count; x++)
            {
                if (iobtenerCodigoCuenta == Convert.ToInt32(dtDetallePlz.Rows[x][0].ToString()))
                {
                    MessageBox.Show(dtDetallePlz.Rows[x][0].ToString() + "  " + dtDetallePlz.Rows[x][2].ToString());
                    iObtenerCorrelativo = Convert.ToInt32(dtDetallePlz.Rows[x][2].ToString());
                }
            }
            //MessageBox.Show("insert into tabm_factura values (" + iCodigoDocumento + "," + txtCodigoPlz.Text + "," + iobtenerCodigoCuenta + "," + iObtenerCorrelativo + sQueriesDocumento + ")");
            ODBCconnector.csFunciones.bEjecutarQuery("insert into tabm_factura values (" + iCodigoDocumento + "," + txtCodigoPlz.Text + "," + iobtenerCodigoCuenta + "," + iObtenerCorrelativo + sQueriesDocumento + ")", "Insertado", false, "tabm_factura");
                
            for (int x = 0; x < dtDetallePlz.Rows.Count; x++)
            {
                Capas.csArbolPolizas.vActualizarCuentas(dtDetallePlz.Rows[x][1].ToString(), Convert.ToSingle(dtDetallePlz.Rows[x][3].ToString()), Convert.ToSingle(dtDetallePlz.Rows[x][4].ToString()));
            }
            txtCargos.Text = string.Empty;
            txtAbonos.Text = string.Empty;
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            bModificar = true;
            vLlenarDetallePlz();
            vLlenarCboCodigoDplz();
            dgvDplz.ReadOnly = false;
            dgvDplz.AllowUserToDeleteRows = false;
            dgvDplz.Columns[0].ReadOnly = true;
            cboClasificacionDplz.Enabled = false;
            cboCuentaDplz.Enabled = false;
            txtSaldoDplz.Enabled = false;
            btnAgregarDplz.Enabled = false;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodigoPlz.Text = sCodigo;
            cboEstadoPlz.SelectedIndex = 0;
            cboCuentaDplz.SelectedIndex = 0;
            cboClasificacionDplz.SelectedIndex = 0;
            txtFechemiPlz.Text = dtpFechemiPlz.Text;
            txtNumPlz.Focus();
            vLlenarCboCodigoDplz();
            vLlenarDetallePlz();
            txtSaldoDplz.Text = string.Empty;
        }

        private void txtCodigoPlz_EnabledChanged(object sender, EventArgs e)
        {
            txtCodigoPlz.Enabled = false;
        }

        private void txtFechemiPlz_EnabledChanged(object sender, EventArgs e)
        {
            dtpFechemiPlz.Enabled = txtFechemiPlz.Enabled;
        }

        private void txtEstadoPlz_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoPlz.Enabled = txtEstadoPlz.Enabled;
            pnlDetallePlz.Enabled = txtEstadoPlz.Enabled;
        }

        private void cboCuentaDplz_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iObtenerIndexCompras = obtenerIndexCboCompra();
            int iObtenerIndexVentas = obtenerIndexCboVenta();
            int iObtenerIndexIvaPagar = obtenerIndexCboIvaPorPagar();
            int iObtenerIndexIvaCobrar = obtenerIndexCboIvaPorCobrar();
            switch(cboCuentaDplz.SelectedIndex)
            {
                case -1: break;
                case 0: break;
                default: if (iObtenerIndexCompras == cboCuentaDplz.SelectedIndex)
                    {
                        DialogResult resultado = MessageBox.Show("¿Desea Agregar un Documento?", "Documento", MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.Yes)
                        {
                            Compras_Ventas.wfDocumento Documento = new Compras_Ventas.wfDocumento();
                            Documento.iTipo = 0;
                            Documento.ShowDialog();
                            sQueriesDocumento = Documento.sQuery;
                            iCodigoDocumento = Documento.iCodigo;
                            PsinIVA = Documento.fPrecioSinIva;
                            dImpuesto = Math.Round(Documento.fImpuesto,0);
                            txtSaldoDplz.Text= Math.Round(PsinIVA,0).ToString();
                            iObtenerIndexCompras = obtenerIndexCboCompra();
                        }
                        else if (resultado == DialogResult.No)
                        {
                        }
                    }
                    if (iObtenerIndexVentas == cboCuentaDplz.SelectedIndex)
                    {
                        DialogResult resultado = MessageBox.Show("¿Desea Agregar un Documento?", "Documento", MessageBoxButtons.YesNo);
                        if (resultado == DialogResult.Yes)
                        {
                            Compras_Ventas.wfDocumento Documento = new Compras_Ventas.wfDocumento();
                            Documento.iTipo = 1;
                            Documento.ShowDialog();
                            sQueriesDocumento = Documento.sQuery;
                            iCodigoDocumento = Documento.iCodigo;
                            iObtenerIndexVentas = obtenerIndexCboVenta();
                            PsinIVA = Documento.fPrecioSinIva;
                            dImpuesto =Math.Round(Documento.fImpuesto,0);
                            txtSaldoDplz.Text = Math.Round(PsinIVA,0).ToString();
                        }
                        else if (resultado == DialogResult.No)
                        {
                        }
                    }

                    if (iObtenerIndexIvaPagar == cboCuentaDplz.SelectedIndex)
                    {
                        txtSaldoDplz.Text = dImpuesto.ToString();
                    }
                    if (iObtenerIndexIvaCobrar == cboCuentaDplz.SelectedIndex)
                    {
                        txtSaldoDplz.Text = dImpuesto.ToString();
                    }
                    break;
            }          
        }

        private int obtenerIndexCboIvaPorPagar() 
        {
            int iIndex = -1;
            for (int x = 0; x < dtCuentasDplz.Rows.Count; x++)
            {
                obtener = dtCuentasDplz.Rows[x][1].ToString();
                if (obtener.Equals("IVA por Pagar"))
                {
                    iIndex = x;
                    iobtenerCodigoCuenta = Convert.ToInt32(dtCuentasDplz.Rows[x][0].ToString());
                }
            }
            return iIndex;
        }

        private int obtenerIndexCboIvaPorCobrar()
        {
            int iIndex = -1;
            for (int x = 0; x < dtCuentasDplz.Rows.Count; x++)
            {
                obtener = dtCuentasDplz.Rows[x][1].ToString();
                if (obtener.Equals("IVA por Cobrar"))
                {
                    iIndex = x;
                    iobtenerCodigoCuenta = Convert.ToInt32(dtCuentasDplz.Rows[x][0].ToString());
                }
            }
            return iIndex;
        }

        private int obtenerIndexCboCompra()
        {
            int iIndex = -1;
            for (int x = 0; x < dtCuentasDplz.Rows.Count; x++)
            {
                obtener = dtCuentasDplz.Rows[x][1].ToString();
                if (obtener.Equals("Compras"))
                {
                    iIndex = x;
                    iobtenerCodigoCuenta = Convert.ToInt32(dtCuentasDplz.Rows[x][0].ToString());
                }
            }
            return iIndex;
        }

        private int obtenerIndexCboVenta()
        {
            int iIndex = -1;
            for (int x = 0; x < dtCuentasDplz.Rows.Count; x++)
            {
                obtener = dtCuentasDplz.Rows[x][1].ToString();
                if (obtener.Equals("Ventas"))
                {
                    iIndex = x;
                    iobtenerCodigoCuenta = Convert.ToInt32(dtCuentasDplz.Rows[x][0].ToString());
                }
            }
            return iIndex;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dtDetallePlz.Rows.RemoveAt(dgvDplz.CurrentCell.RowIndex);
            dgvDplz.Refresh();
            cboCuentaDplz.Focus();
            vSaldos();
        }

        private void txtNumPlz_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtDetallePlz_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 ");
        }

        private void txtSaldoDplz_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }
    }
}