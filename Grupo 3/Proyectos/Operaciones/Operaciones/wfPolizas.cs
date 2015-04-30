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

namespace Operaciones
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
            alDatosEnviados.Add(txtCodigoPlz);
            alDatosEnviados.Add(txtCodEmpsa);
            alDatosEnviados.Add(txtMoneda);
            alDatosEnviados.Add(txtNumPlz);
            alDatosEnviados.Add(txtFechemiPlz);
            alDatosEnviados.Add(txtDetallePlz);
            alDatosEnviados.Add(txtEstadoPlz);
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
            switch (txtEstadoPlz.Text)
            {
                case "1": cboEstadoPlz.SelectedIndex = 0; break;
                case "0": cboEstadoPlz.SelectedIndex = 1; break;
                default: cboEstadoPlz.SelectedIndex = -1; break;
            }
        }

        private void cboEstadoPza_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboEstadoDplz.SelectedIndex) 
            {
                case 0: txtEstadoPlz.Text = "1"; break;
                case 1: txtEstadoPlz.Text = "0"; break;
                default: txtEstadoPlz.Text = string.Empty; break;
            }
        }        

        private void navegador1_btnAfterNuevo(object sender, EventArgs e)
        {
            dgvDplz.ReadOnly = false;
            dgvDplz.AllowUserToAddRows = true;
        }

        
        private void dgvDplz_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*switch(dgvDplz.CurrentCell.ColumnIndex)
            {
                case 1: Capas.csNegocio.vValidarTexto(e, "0123456789"); break;
                case 2: case 3: Capas.csNegocio.vValidarTexto(e, "0123456789."); break;
                default: break;
            }*/

            
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

        private void btnAgregarDplz_Click(object sender, EventArgs e)
        {
            //if (string.Compare(txtCargoDplz.Text, string.Empty) && string.Compare(txtAbonoDplz.Text, string.Empty) != 0)
            if (string.Compare(txtCargoDplz.Text, string.Empty) != 0)
            {
                dgvDplz.Rows[0].Cells[0].Value = txtCorrDplz.Text;
                dgvDplz.Rows[0].Cells[3].Value = txtCargoDplz.Text;
                dgvDplz.Rows[0].Cells[4].Value = txtAbonoDplz.Text;
                if (txtEstadoDplz.Text == "1")
                {
                    dgvDplz.Rows[0].Cells[5].Value = "Activado";
                }
                else
                {
                    dgvDplz.Rows[0].Cells[5].Value = "Desactivado";
                }
                dgvDplz.Refresh();
            }
            else
            {
                MessageBox.Show("Ingrese cantidad", "SCF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCargoDplz.Focus();
            }
        }

        private void cboEstadoDplz_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cboEstadoDplz.SelectedIndex)
            {
                case 0: txtEstadoDplz.Text = "1"; break;
                case 1: txtEstadoDplz.Text = "0"; break;
                default: txtEstadoDplz.Text = string.Empty; break;
            }
        }

        private void txtEstadoDplz_TextChanged(object sender, EventArgs e)
        {
            switch (txtEstadoDplz.Text)
            {
                case "1": cboEstadoDplz.SelectedIndex = 0; break;
                case "0": cboEstadoDplz.SelectedIndex = 1; break;
                default: cboEstadoDplz.SelectedIndex = -1; break;
            }
        }

        private void dgvDplz_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            string sCodAux = string.Empty; 
            switch (e.ColumnIndex)
            {
                case 1: wfCuentas Nomenclatura = new wfCuentas();
                    Nomenclatura.ShowDialog();
                    txtCuentaDplz.Text = Nomenclatura.sCodigo;
                    dgvDplz.Rows[e.RowIndex].Cells[1].Value = Nomenclatura.sNomenclatura;
                    dgvDplz.Rows[e.RowIndex].Cells[2].Value = Nomenclatura.sNombre;
                    break;
                case 2: wfCuentas Cuentas = new wfCuentas();
                    Cuentas.ShowDialog();
                    txtCuentaDplz.Text = Cuentas.sCodigo;
                    dgvDplz.Rows[e.RowIndex].Cells[1].Value = Cuentas.sNomenclatura;
                    dgvDplz.Rows[e.RowIndex].Cells[2].Value = Cuentas.sNombre;
                    break;
                default: break;
            }
        }

        private void btnTotalPlz_Click(object sender, EventArgs e)
        {
            double sumac = 0;
            double sumaa = 0;
            for (int i = 0; i < dgvDplz.Rows.Count; i++)
            {
                sumac += Convert.ToDouble(dgvDplz.Rows[i].Cells[3].Value);
                sumaa += Convert.ToDouble(dgvDplz.Rows[i].Cells[4].Value);
            }
            txtCargos.Text = sumac.ToString();
            txtAbonos.Text = sumaa.ToString();
        }

        private void txtCodEmpsa_Enter(object sender, EventArgs e)
        {
            Seguridad.wfEmpresas Empresa = new Seguridad.wfEmpresas();
            Empresa.ShowDialog();
            txtCodEmpsa.Text = Empresa.sCodigo;
        }

        private void txtMoneda_Enter(object sender, EventArgs e)
        {
            Seguridad.wfMonedas Moneda = new Seguridad.wfMonedas();
            Moneda.ShowDialog();
            txtMoneda.Text = Moneda.sCodigo;
        }

        private void txtCodigoPlz_TextChanged(object sender, EventArgs e)
        {
            sCodigo = txtCodigoPlz.Text;
        }


        /*private void dgvDplz_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if(e.Control is TextBox)
            {
                TextBox txt = e.Control as TextBox;
                if(object.ReferenceEquals(dgvDplz.CurrentCell.ValueType, typeof(System.Int32)))
                {
                    txt.KeyPress += Numeros_KeyPress;
                }
                else
                {
                    txt.KeyPress -= Numeros_KeyPress;
                    ((TextBox)(e.Control)).CharacterCasing = CharacterCasing.Upper;
                }
            }
        }*/

        /*private void Numeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar)&& e.KeyChar !=8)
            {
                e.Handled = true; //invalidar
                System.Media.SystemSounds.Beep.Play();
            }
        }*/

    }
}
