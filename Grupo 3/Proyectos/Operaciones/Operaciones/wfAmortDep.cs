/* Autor:       Andrea Gabriela Pérez Quiacain
 * Módulo:      Operaciones
 * Formulario:  Amortizaciones - Depreciaciones
 * Fecha:       31/05/2015 última actualización
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
    public partial class wfAmortDep : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        BindingSource bsDetalleAmort = new BindingSource();
        BindingSource bsDetalleAmortAux = new BindingSource();
        DataTable dtDetalleAmort = new DataTable();
        DataTable dtDetalleAmortAux = new DataTable();
        //private bool bModificarDato = false;
        public string sCodigo = string.Empty;
        string sCodCta = string.Empty;

        public wfAmortDep()
        {
            InitializeComponent();
        }

        private void cboEstado_amortizacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoAmort.SelectedIndex)
            {
                case 0: txtEstadoAmortDep.Text = "1"; break;
                case 1: txtEstadoAmortDep.Text = "0"; break;
                default: txtEstadoAmortDep.Text = string.Empty; break;
            }
        }

        private void txtEstado_amortizacion_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoAmortDep.Text)
            {
                case "1": cboEstadoAmort.SelectedIndex = 0; break;
                case "0": cboEstadoAmort.SelectedIndex = 1; break;
                default: cboEstadoAmort.SelectedIndex = -1; break;
            }
        }

        private void txtCod_amortizacion_EnabledChanged(object sender, EventArgs e)
        {
            txtCodAmortDep.Enabled = false;
        }

        private void wfAmortizacion_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodAmortDep);
            alDatosEnviados.Add(txtCuentaCta);
            alDatosEnviados.Add(txtPeriodosAmortDep);
            alDatosEnviados.Add(txtValorAmortDep);
            alDatosEnviados.Add(txtInteresAmortDep);
            alDatosEnviados.Add(txtEstadoAmortDep);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            Capas.csNegocio.SNombreTabla = navegador1.sNombreTabla;
            bsDetalleAmort.DataSource = dtDetalleAmort;
            dgvDetalleAmort.DataSource = bsDetalleAmort;
        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            dtDetalleAmortAux = dtDetalleAmort;
            if (!Capas.csNegocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void navegador1_btnBeforeLimpiar(object sender, EventArgs e)
        {
            sCodigo = txtCodAmortDep.Text;
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoAmort.SelectedIndex = 0;
            txtCuentaCta.Focus();
            vLlenarDetalleAmort();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            txtCuentaCta.Focus();            
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodAmortDep.Text = sCodigo;
            cboEstadoAmort.SelectedIndex = 0;
            
        }

        private void txtNom_amortizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtValor_amortizacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, ".0123456789");
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

        private void vLlenarDetalleAmort()
        {
            dtDetalleAmort = Capas.csNegocio.dtConsultarRegistros("select periodo_damortdep, pago_damortdep, interes_damortdep, amort_damortdep, sfinal_damortdep, estado_damortdep from tabt_damortdep where estado_damortdep='1' and cod_amortdep='" + txtCodAmortDep.Text + "'");
            if (dtDetalleAmort.Rows.Count != 0)
            {
                dtDetalleAmort.Columns[0].ColumnName = "Período";
                dtDetalleAmort.Columns[1].ColumnName = "Pago";
                dtDetalleAmort.Columns[2].ColumnName = "Interés";
                dtDetalleAmort.Columns[3].ColumnName = "Amortización";
                dtDetalleAmort.Columns[4].ColumnName = "Saldo";
                dtDetalleAmort.Columns[5].ColumnName = "Estado";
            }
            else
            {
                dtDetalleAmort.Columns.Add("Período");
                dtDetalleAmort.Columns.Add("Pago");
                dtDetalleAmort.Columns.Add("Interés");
                dtDetalleAmort.Columns.Add("Amortización");
                dtDetalleAmort.Columns.Add("Saldo");
                dtDetalleAmort.Columns.Add("Estado");
            }
            bsDetalleAmort.DataSource = dtDetalleAmort;
            dgvDetalleAmort.DataSource = bsDetalleAmort;
            dgvDetalleAmort.Columns[0].Width = 95;
            dgvDetalleAmort.Columns[1].Width = 95;
            dgvDetalleAmort.Columns[2].Width = 95;
            dgvDetalleAmort.Columns[3].Width = 96;
            dgvDetalleAmort.Columns[4].Width = 96;
            dgvDetalleAmort.Columns[5].Width = 95;
        }

        private string sInteres(string sSaldo)
        {
            float fInteres = Convert.ToSingle(sSaldo) * ((Convert.ToSingle(txtInteresAmortDep.Text) / 100) / Convert.ToSingle(txtPeriodosAmortDep.Text));
            return Math.Round(fInteres, 2).ToString();
        }

        private string sPago()
        {
            float itrs = (Convert.ToSingle(txtInteresAmortDep.Text) / 100) / (Convert.ToSingle(txtPeriodosAmortDep.Text));
            double R = Convert.ToDouble(txtValorAmortDep.Text) * (itrs / (1 - (Math.Pow((1 + itrs), - Convert.ToDouble(txtPeriodosAmortDep.Text)))));
            return Math.Round(R, 2).ToString();
        }

        private string sAmortizacion(string sPago, string sInteres)
        {
            return Math.Round(Convert.ToSingle(sPago) - Convert.ToSingle(sInteres), 2).ToString();
        }

        private string sSaldoT(string sSaldo, string sAmortizacion)
        {
            return Math.Round(Convert.ToSingle(sSaldo) - Convert.ToSingle(sAmortizacion), 2).ToString();
        }
                
        private void btnCalcularAmortDep_Click(object sender, EventArgs e)
        {
            vLlenarDetalleAmort();
            if (dtDetalleAmort.Rows.Count == 0)
            {
                dtDetalleAmort.Rows.Add("", "", "", "", txtValorAmortDep.Text, "1");
                for (int x = 1; x <= Convert.ToInt32(txtPeriodosAmortDep.Text); x++)
                {
                    string sPagoP = sPago();
                    string sInteresP = sInteres(dtDetalleAmort.Rows[x - 1][4].ToString());
                    string sAmortizacionP = sAmortizacion(sPagoP, sInteresP);
                    string sSaldoP = sSaldoT(dtDetalleAmort.Rows[x - 1][4].ToString(), sAmortizacionP);
                    dtDetalleAmort.Rows.Add(x, sPagoP, sInteresP, sAmortizacionP, sSaldoP, "1");
                }
                dgvDetalleAmort.Refresh();
            }
        }

        private int sObtenerCodigo()
        {
            string sQuery = "select * from tabt_damortdep";
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

        private void navegador1_btnAfterGuardar(object sender, EventArgs e)
        {
            for (int iFilas = 0; iFilas < dtDetalleAmortAux.Rows.Count; iFilas++)
            {
                ODBCconnector.csFunciones.bEjecutarQuery("insert into tabt_damortdep values ('" + sObtenerCodigo() + "','" + txtCodAmortDep.Text + "','" + dtDetalleAmortAux.Rows[iFilas][0].ToString() + "','" + dtDetalleAmortAux.Rows[iFilas][1].ToString() + "','" + dtDetalleAmortAux.Rows[iFilas][2].ToString() + "','" + dtDetalleAmortAux.Rows[iFilas][3].ToString() + "','" + dtDetalleAmortAux.Rows[iFilas][4].ToString() + "','" + dtDetalleAmortAux.Rows[iFilas][5].ToString() + "')", "insertado", false, "tabt_damortdep");
            }
            vLlenarDetalleAmort();
        }

        private void txtCuentaCta_Enter(object sender, EventArgs e)
        {
            wfCuentas Cuenta = new wfCuentas();
            Cuenta.ShowDialog();
            txtCuentaCta.Text = Cuenta.sCodigo;
            sCodCta = txtCuentaCta.Text;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dtDetalleAmort.Rows.RemoveAt(dgvDetalleAmort.CurrentCell.RowIndex);
            dgvDetalleAmort.Refresh();
        }

        private void txtCuentaCta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "");
        }

        private void txtPeriodosAmortDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtValorAmortDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }

        private void txtInteresAmortDep_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789.");
        }

        private void txtEstadoAmortDep_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoAmort.Enabled = txtEstadoAmortDep.Enabled;
            pnlAmortDep.Enabled = txtEstadoAmortDep.Enabled;
        }

        private void txtCodAmortDep_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodAmortDep.Text;
            vLlenarDetalleAmort();
        }
    }
}
