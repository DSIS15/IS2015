using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seguridad
{
    public partial class wfPerfiles : Form
    {
        BindingSource bsTablas = new BindingSource();
        DataTable dtTablas = new DataTable();
        BindingSource bsDPerfil = new BindingSource();
        DataTable dtDPerfil = new DataTable();
        DataTable dtDetalle = new DataTable();
        ArrayList alDatosEnviados = new ArrayList();
        bool bModificarRegistro = false;
        public string sCodigo = string.Empty;

        public wfPerfiles()
        {
            InitializeComponent();
        }

        private void wfPerfiles_Load(object sender, EventArgs e)
        {
            alDatosEnviados.Add(txtCodPfl);
            alDatosEnviados.Add(txtPerfilPfl);
            alDatosEnviados.Add(txtDescripPfl);
            alDatosEnviados.Add(txtEstadoPfl);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
            navegador1.bTablaMaster = false;
            Capas.csNegocio.SNombreTabla = "tabt_dperfil";            
            vLlenarDgvDPerfil();
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

        private void txtCodPfl_EnabledChanged(object sender, EventArgs e)
        {
            txtCodPfl.Enabled = false;
        }

        private void txtEstadoPfl_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoPfl.Text)
            {
                case "0": cboEstadoPfl.SelectedIndex = 1; break;
                case "1": cboEstadoPfl.SelectedIndex = 0; break;
                default: cboEstadoPfl.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoPfl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoPfl.SelectedIndex)
            {
                case 0: txtEstadoPfl.Text = "1"; break;
                case 1: txtEstadoPfl.Text = "0"; break;
                default: txtEstadoPfl.Text = string.Empty; break;
            }
        }

        private void txtEstadoPfl_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoPfl.Enabled = txtEstadoPfl.Enabled;
        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            dtDetalle = dtDPerfil;
            dtDetalle.Columns.RemoveAt(1);
            if (!Capas.csNegocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
        }

        private void navegador1_btnBeforeLimpiar(object sender, EventArgs e)
        {
            sCodigo = txtCodPfl.Text;
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodPfl.Text = sCodigo;
            cboEstadoPfl.SelectedIndex = 0;
            txtPerfilPfl.Focus();
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoPfl.SelectedIndex = 0;
            txtPerfilPfl.Focus();
            vLlenarDgvDPerfil();
        }

        private void navegador1_btnAfterModificar(object sender, EventArgs e)
        {
            bModificarRegistro = true;            
            txtPerfilPfl.Focus();
            vHabilitarDgv(true);
        }

        private void txtPerfilPfl_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void txtDescripPfl_KeyPress(object sender, KeyPressEventArgs e)
        {
            Capas.csNegocio.vValidarTexto(e, "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ_abcdefghijklmnñopqrstuvwxyz -_.,0123456789");
        }

        private void vHabilitarDgv(bool bEstado)
        {
            dgvDPerfil.ReadOnly = !bEstado;
            dgvDPerfil.Columns[0].ReadOnly = true;
            dgvDPerfil.Columns[1].ReadOnly = true;
            dgvDPerfil.Columns[2].ReadOnly = !bEstado;
            dgvDPerfil.Columns[3].ReadOnly = !bEstado;
            dgvDPerfil.Columns[4].ReadOnly = !bEstado;
            dgvDPerfil.Columns[5].ReadOnly = !bEstado;
            dgvDPerfil.Columns[6].ReadOnly = !bEstado;
            dgvDPerfil.Columns[7].ReadOnly = !bEstado;
        }

        private void vLlenarDgvDPerfil()
        {
            bool bHabilitar = false;
            dgvDPerfil.DataSource = null;
            dtDPerfil = new DataTable();
            dtDPerfil = Capas.csNegocio.dtConsultarRegistros("SELECT a.cod_tbl, b.alias_tbl, a.insert_dpfl, a.update_dpfl, a.delete_dpfl, a.print_dpfl, a.select_dpfl, a.estado_dpfl FROM tabt_dperfil a, tabm_tabla b WHERE a.cod_tbl=b.cod_tbl and a.cod_pfl='" + txtCodPfl.Text + "'");
            if (dtDPerfil.Rows.Count != 0)
            {
                dtDPerfil.Columns[0].ColumnName = "Código";
                dtDPerfil.Columns[1].ColumnName = "Tabla";
                dtDPerfil.Columns[2].ColumnName = "Insert";
                dtDPerfil.Columns[3].ColumnName = "Update";
                dtDPerfil.Columns[4].ColumnName = "Delete";
                dtDPerfil.Columns[5].ColumnName = "Print";
                dtDPerfil.Columns[6].ColumnName = "Select";
                dtDPerfil.Columns[7].ColumnName = "Estado";
            }
            else
            {
                dtDPerfil.Columns.Add("Código");
                dtDPerfil.Columns.Add("Tabla");
                dtDPerfil.Columns.Add("Insert");
                dtDPerfil.Columns.Add("Update");
                dtDPerfil.Columns.Add("Delete");
                dtDPerfil.Columns.Add("Print");
                dtDPerfil.Columns.Add("Select");
                dtDPerfil.Columns.Add("Estado");
                ArrayList alTablas = ODBCconnector.csFunciones.alConsultarQuery("select cod_tbl, alias_tbl from tabm_tabla where estado_tbl=1 order by alias_tbl asc");
                foreach (ArrayList alFila in alTablas)
                {
                    dtDPerfil.Rows.Add(alFila[0], alFila[1], "0", "0", "0", "0", "0", "1");
                }
                bHabilitar = true;
            }
            bsDPerfil.DataSource = dtDPerfil;
            dgvDPerfil.DataSource = bsDPerfil;
            dgvDPerfil.Columns[0].Visible = false;
            dgvDPerfil.Columns[1].Width = 100;
            vHabilitarDgv(bHabilitar);
        }

        private void txtCodPfl_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodPfl.Text;
            vLlenarDgvDPerfil();
        }

        private void navegador1_btnAfterRecargar(object sender, EventArgs e)
        {
            vLlenarDgvDPerfil();
        }

        private void navegador1_btnAfterGuardar(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCodPfl.Text);
            if (bModificarRegistro)
            {
                Capas.csNegocio.vModificarRegistros(alCodigos, dtDetalle);
                bModificarRegistro = false;
            }
            else
            {
                Capas.csNegocio.vInsertarRegistros(alCodigos, dtDetalle);
            }
            vLlenarDgvDPerfil();
            Capas.csParametros.vObtenerPrivelegios();
            navegador1.vIniciarNavegador();
        }

        private void navegador1_btnAfterEliminar(object sender, EventArgs e)
        {
            ArrayList alCodigos = new ArrayList();
            alCodigos.Add(txtCodPfl.Text);
            dtDPerfil.Columns.RemoveAt(1);
            Capas.csNegocio.vEliminarRegistros(alCodigos, dtDPerfil);
            vLlenarDgvDPerfil();
        }

        private void dgvDPerfil_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvDPerfil.ReadOnly)
            {
                switch (dtDPerfil.Rows[e.RowIndex][e.ColumnIndex].ToString())
                {
                    case "0": dtDPerfil.Rows[e.RowIndex][e.ColumnIndex] = "1"; break;
                    case "1": dtDPerfil.Rows[e.RowIndex][e.ColumnIndex] = "0"; break;
                    default: break;
                }
            }
        }

        private void navegador1_btnAfterImprimir(object sender, EventArgs e)
        {
            Reporteador.wfReportes Perfiles = new Reporteador.wfReportes();
            Perfiles.sNombreReporte = "Reporte de Perfiles";
            Perfiles.sSubReporte = "Perfiles";
            Perfiles.ShowDialog();
        }
    }
}
