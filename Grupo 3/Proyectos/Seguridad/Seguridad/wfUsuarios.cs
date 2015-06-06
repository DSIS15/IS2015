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
    public partial class wfUsuarios : Form
    {
        ArrayList alDatosEnviados = new ArrayList();
        csNegocio Negocio = new csNegocio();
        BindingSource bsPermisosEspeciales = new BindingSource();
        DataTable dtPermisosEspeciales = new DataTable();
        DataTable dtDetalle = new DataTable();
        private bool bPermisosEspeciales = false;
        private bool bModificarFormulario = false;
        public string sCodigo = string.Empty;

        public wfUsuarios()
        {
            InitializeComponent();
        }

        private void wfUsuarios_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(630, 230);
            alDatosEnviados.Add(txtCodUsr);
            alDatosEnviados.Add(txtCodPfl);
            alDatosEnviados.Add(txtNomUsr);
            alDatosEnviados.Add(txtContrasena);
            alDatosEnviados.Add(txtEstadoUsr);
            navegador1.alDatosEntrada = alDatosEnviados;
            navegador1.vIniciarNavegador();
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

        private void txtContrasena_EnabledChanged(object sender, EventArgs e)
        {
            txtConfContrasena.Enabled = txtContrasena.Enabled;
        }

        private void txtEstadoUsr_EnabledChanged(object sender, EventArgs e)
        {
            cboEstadoUsr.Enabled = txtEstadoUsr.Enabled;
            btnPermisosEspeciales.Enabled = txtEstadoUsr.Enabled;
            dgvPermisosEspeciales.Enabled = txtEstadoUsr.Enabled;
        }

        private void txtCodUsr_EnabledChanged(object sender, EventArgs e)
        {
            txtCodUsr.Enabled = false;
        }

        private void txtEstadoUsr_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoUsr.Text)
            {
                case "0": cboEstadoUsr.SelectedIndex = 1; break;
                case "1": cboEstadoUsr.SelectedIndex = 0; break;
                default: cboEstadoUsr.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoUsr_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoUsr.SelectedIndex)
            {
                case 0: txtEstadoUsr.Text = "1"; break;
                case 1: txtEstadoUsr.Text = "0"; break;
                default: txtEstadoUsr.Text = string.Empty; break;
            }
        }

        private void navegador1_btnAfterLimpiar(object sender, EventArgs e)
        {
            txtCodUsr.Text = sCodigo;
            cboEstadoUsr.SelectedIndex = 0;            
        }

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            cboEstadoUsr.SelectedIndex = 0;
            bPermisosEspeciales = false;
        }

        private void navegador1_btnBeforeGuardar(object sender, EventArgs e)
        {
            txtContrasena.Text = Negocio.sCifrarCadena(txtContrasena.Text);
            txtConfContrasena.Text = Negocio.sCifrarCadena(txtConfContrasena.Text);
            if (!Capas.csNegocio.bValidarTextBoxes(alDatosEnviados))
            {
                navegador1.bEjecutarEvento = false;
            }
            if (string.Compare(txtContrasena.Text, txtConfContrasena.Text) != 0)
            {
                navegador1.bEjecutarEvento = false;
                MessageBox.Show("Error las contraseñas no coinciden.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContrasena.Text = string.Empty;
                txtConfContrasena.Text = string.Empty;
                txtContrasena.Focus();
            }
        }

        private void txtCodUsr_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodUsr.Text;
            vLlenarDgvPermisosEspeciales();
            if (bModificarFormulario)
            {
                this.Size = new System.Drawing.Size(630, 230);            
            }
            else
            {
                this.Size = new System.Drawing.Size(630, 540);
            }
        }

        private void navegador1_btnBeforeLimpiar(object sender, EventArgs e)
        {
            sCodigo = txtCodUsr.Text;
        }

        private void vHabilitarDgv(bool bEstado)
        {
            dgvPermisosEspeciales.ReadOnly = !bEstado;
            dgvPermisosEspeciales.Columns[0].ReadOnly = true;
            dgvPermisosEspeciales.Columns[1].ReadOnly = true;
            dgvPermisosEspeciales.Columns[2].ReadOnly = !bEstado;
            dgvPermisosEspeciales.Columns[3].ReadOnly = !bEstado;
            dgvPermisosEspeciales.Columns[4].ReadOnly = !bEstado;
            dgvPermisosEspeciales.Columns[5].ReadOnly = !bEstado;
            dgvPermisosEspeciales.Columns[6].ReadOnly = !bEstado;
            dgvPermisosEspeciales.Columns[7].ReadOnly = !bEstado;
        }

        private void vLlenarDgvPermisosEspeciales()
        {
            bool bHabilitar = false;
            dgvPermisosEspeciales.DataSource = null;
            dtPermisosEspeciales = new DataTable();
            dtPermisosEspeciales = Capas.csNegocio.dtConsultarRegistros("SELECT a.cod_tbl, b.alias_tbl, a.insert_permspl, a.update_permspl, a.delete_permspl, a.print_permspl, a.select_permspl, a.estado_permspl FROM tabt_permisoespecial a, tabm_tabla b WHERE a.cod_tbl=b.cod_tbl and a.cod_usr='" + txtCodUsr.Text + "'");
            if (dtPermisosEspeciales.Rows.Count != 0)
            {
                dtPermisosEspeciales.Columns[0].ColumnName = "Código";
                dtPermisosEspeciales.Columns[1].ColumnName = "Tabla";
                dtPermisosEspeciales.Columns[2].ColumnName = "Insert";
                dtPermisosEspeciales.Columns[3].ColumnName = "Update";
                dtPermisosEspeciales.Columns[4].ColumnName = "Delete";
                dtPermisosEspeciales.Columns[5].ColumnName = "Print";
                dtPermisosEspeciales.Columns[6].ColumnName = "Select";
                dtPermisosEspeciales.Columns[7].ColumnName = "Estado";
                bModificarFormulario = false;
            }
            else
            {
                dtPermisosEspeciales.Columns.Add("Código");
                dtPermisosEspeciales.Columns.Add("Tabla");
                dtPermisosEspeciales.Columns.Add("Insert");
                dtPermisosEspeciales.Columns.Add("Update");
                dtPermisosEspeciales.Columns.Add("Delete");
                dtPermisosEspeciales.Columns.Add("Print");
                dtPermisosEspeciales.Columns.Add("Select");
                dtPermisosEspeciales.Columns.Add("Estado");
                ArrayList alTablas = ODBCconnector.csFunciones.alConsultarQuery("select cod_tbl, alias_tbl from tabm_tabla where estado_tbl=1 order by alias_tbl asc");
                foreach (ArrayList alFila in alTablas)
                {
                    dtPermisosEspeciales.Rows.Add(alFila[0], alFila[1], "0", "0", "0", "0", "0", "0");
                }
                bHabilitar = true;
                bModificarFormulario = true;
            }
            bsPermisosEspeciales.DataSource = dtPermisosEspeciales;
            dgvPermisosEspeciales.DataSource = bsPermisosEspeciales;
            dgvPermisosEspeciales.Columns[0].Visible = false;
            dgvPermisosEspeciales.Columns[1].Width = 100;
            vHabilitarDgv(bHabilitar);
        }

        private void btnPermisosEspeciales_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(630, 540);
            bPermisosEspeciales = true;
            vLlenarDgvPermisosEspeciales();
        }

        private void navegador1_btnAfterGuardar(object sender, EventArgs e)
        {
            if (bPermisosEspeciales)
            {
                MessageBox.Show("Guardar permisos especiales");
            }
        }

        private void navegador1_btnAfterImprimir(object sender, EventArgs e)
        {
            Reporteador.wfReportes Usuarios = new Reporteador.wfReportes();
            Usuarios.sNombreReporte = "Reporte de Usuarios";
            Usuarios.sSubReporte = "Usuarios";
            Usuarios.ShowDialog();
        }        
    }
}
