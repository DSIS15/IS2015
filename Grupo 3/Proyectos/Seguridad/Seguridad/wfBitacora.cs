using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguridad
{
    public partial class wfBitacora : Form
    {
        BindingSource bsBitacora = new BindingSource();
        DataTable dtBitacora = new DataTable();
        
        public wfBitacora()
        {
            InitializeComponent();
        }

        private void vLlenarDgvProductosAmbiente()
        {
            dtBitacora = Capas.csNegocio.dtConsultarRegistros("select fecha_bit, usuario_bit, maquina_bit, ip_bit, empresa_bit, accion_bit from tabm_bitacora where fecha_bit like '" + txtClave.Text + "%' or usuario_bit like '" + txtClave.Text + "%' or maquina_bit like '" + txtClave.Text + "%' or ip_bit like '" + txtClave.Text + "%' or empresa_bit like '" + txtClave.Text + "%' or accion_bit like '" + txtClave.Text + "%' order by fecha_bit desc");
            if (dtBitacora.Rows.Count != 0)
            {
                dtBitacora.Columns[0].ColumnName = "Fecha";
                dtBitacora.Columns[1].ColumnName = "Usuario";
                dtBitacora.Columns[2].ColumnName = "Maquina";
                dtBitacora.Columns[3].ColumnName = "IP";
                dtBitacora.Columns[4].ColumnName = "Empresa";
                dtBitacora.Columns[5].ColumnName = "Acción";
            }
            else
            {
                dtBitacora.Columns.Add("Fecha");
                dtBitacora.Columns.Add("Usuario");
                dtBitacora.Columns.Add("Maquina");
                dtBitacora.Columns.Add("IP");
                dtBitacora.Columns.Add("Empresa");
                dtBitacora.Columns.Add("Acción");
            }
            bsBitacora.DataSource = dtBitacora;
            dgvBitacora.DataSource = bsBitacora;
        }

        private void wfBitacora_Load(object sender, EventArgs e)
        {
            btnRecargar_Click(this, e);
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            vLlenarDgvProductosAmbiente();            
        }
    }
}
