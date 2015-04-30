using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConciliacionBancaria
{
    public partial class wfProcesoConciBancaria : Form
    {
        private DataTable dtEstadosCuenta = new DataTable();
        private BindingSource bsEstadoCuenta = new BindingSource();
        private DataTable dtMovimientos = new DataTable();
        private BindingSource bsMovimientos = new BindingSource();

        public wfProcesoConciBancaria()
        {
            InitializeComponent();
        }

        private void wfProcesoConciBancaria_Load(object sender, EventArgs e)
        {
            
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "0123456789");
        }

        private void txtCuenta_Enter(object sender, EventArgs e)
        {
            wfCuentasBancarias CuentasBancarias = new wfCuentasBancarias();
            CuentasBancarias.ShowDialog();
            txtCuenta.Text = CuentasBancarias.sCodigo;
        }

        private void vLlenarCboEstadoCuenta(string sCuenta)
        {
            dtEstadosCuenta = Capas.csNegocio.dtConsultarRegistros("select cod_estcta, concat(anio_estcta,'/',mes_estcta,' ',nombre_estcta), ubic_estcta from tabm_estadocuenta where cod_ctabco='" + sCuenta + "' and estado_estcta=1 order by anio_estcta desc, mes_estcta asc");
            if (dtEstadosCuenta.Rows.Count != 0)
            {
                dtEstadosCuenta.Columns[0].ColumnName = "Código";
                dtEstadosCuenta.Columns[1].ColumnName = "EstadoCuenta";
                dtEstadosCuenta.Columns[2].ColumnName = "Ubicación";
                bsEstadoCuenta.DataSource = dtEstadosCuenta;
                cboEstadoCuenta.DataSource = bsEstadoCuenta;
                cboEstadoCuenta.DisplayMember = "EstadoCuenta";
                cboEstadoCuenta.ValueMember = "Código";
                cboEstadoCuenta.SelectedIndex = 0;
                cboEstadoCuenta.Refresh();
            }
        }

        private void vLlenarDgvMovimientos(string sCuenta)
        {
            dtMovimientos = Capas.csNegocio.dtConsultarRegistros("select a.cod_mov, a.fechmov_mov, b.nombre_tmov, a.correlativo_mov, a.debito_mov, a.credito_mov from tabm_movimiento a, tabm_tmovimiento b where a.cod_tmov=b.cod_tmov and a.cod_empsa='" + Capas.csParametros.AlEmpresa[0].ToString() + "' and a.cod_mda='" + Capas.csParametros.AlMoneda[0].ToString() + "' and a.cod_ctabco='" + sCuenta + "' and a.estado_mov=1 and a.cod_mov not in (select cod_mov from tabm_conciliacion where conciliado_conci=1 and estado_conci=1)");
            if (dtMovimientos.Rows.Count != 0)
            {
                dtMovimientos.Columns[0].ColumnName = "Código";
                dtMovimientos.Columns[1].ColumnName = "Fecha";
                dtMovimientos.Columns[2].ColumnName = "Tipo";
                dtMovimientos.Columns[3].ColumnName = "Correlativo";
                dtMovimientos.Columns[4].ColumnName = "Debito";
                dtMovimientos.Columns[5].ColumnName = "Crédito";
            }
            else
            {
                dtMovimientos.Columns.Add("Código");
                dtMovimientos.Columns.Add("Fecha");
                dtMovimientos.Columns.Add("Tipo");
                dtMovimientos.Columns.Add("Correlativo");
                dtMovimientos.Columns.Add("Debito");
                dtMovimientos.Columns.Add("Crédito");
            }
            bsMovimientos.DataSource = dtMovimientos;
            dgvMovimientos.DataSource = bsMovimientos;
            dgvMovimientos.Columns[0].Visible = false;
            DataGridViewColumn dgvcConciliar = new DataGridViewCheckBoxColumn();
            dgvcConciliar.Name = "Conciliar";
            dgvcConciliar.HeaderText = "Conciliar";
            dgvMovimientos.Columns.Add(dgvcConciliar);
        }

        private void txtCuenta_TextChanged(object sender, EventArgs e)
        {
            vLlenarCboEstadoCuenta(txtCuenta.Text);
            vLlenarDgvMovimientos(txtCuenta.Text);
        }

        private void btnConciliarMovimientos_Click(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            DataTable dtConciliacion = new DataTable();
            int iCantidad = 0;
            alCodigos.Add(cboEstadoCuenta.SelectedValue.ToString());
            string sFecha = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            dtConciliacion.Columns.Add("Movimiento");
            dtConciliacion.Columns.Add("Fecha");
            dtConciliacion.Columns.Add("Conciliado");
            dtConciliacion.Columns.Add("Estado");            
            for (int iRow = 0; iRow < dgvMovimientos.Rows.Count; iRow++)
            {
                if ((bool)dgvMovimientos.Rows[iRow].Cells[dgvMovimientos.Columns.Count - 1].EditedFormattedValue)
                {
                    dtConciliacion.Rows.Add(dgvMovimientos.Rows[iRow].Cells[0].Value.ToString(), sFecha, "1", "1");
                    iCantidad++;
                }
            }
            if (iCantidad != 0)
            {
                Capas.csNegocio.SNombreTabla = "tabm_conciliacion";
                Capas.csNegocio.vInsertarRegistros(alCodigos, dtConciliacion);
                MessageBox.Show("Movimientos conciliados correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione los movimientos a conciliar");
            }
        }

        private void cboEstadoCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstadoCuenta.SelectedIndex != -1)
            {
                VisorPDF.LoadFile(dtEstadosCuenta.Rows[cboEstadoCuenta.SelectedIndex][2].ToString());
                VisorPDF.src = dtEstadosCuenta.Rows[cboEstadoCuenta.SelectedIndex][2].ToString();
                VisorPDF.Show();
            }
        }
    }
}
