using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dll_inventario.Presentacion
{
    public partial class wfInventario : Form
    {
        private ArrayList alDatosEntrada = new ArrayList();
        public wfInventario()
        {
            InitializeComponent();
        }

        private void wfInventario_Load(object sender, EventArgs e)
        {
            alDatosEntrada.Add(txtIdInventario);
            alDatosEntrada.Add(txtLaboratorio);
            alDatosEntrada.Add(txtNombre);
            alDatosEntrada.Add(txtForma);
            alDatosEntrada.Add(txtLote);
            alDatosEntrada.Add(txtCantidad);
            alDatosEntrada.Add(txtPrecioUnitario);
            alDatosEntrada.Add(txtDescuento);
            alDatosEntrada.Add(txtTotal);
            alDatosEntrada.Add(txtFechaVencimiento);
            alDatosEntrada.Add(txtExistencia);
            alDatosEntrada.Add(txtEstado);

            navegador1.alDatosEntrada = alDatosEntrada;
            navegador1.vIniciarNavegador();
        }

        private void dtpFechaVencimiento_ValueChanged(object sender, EventArgs e)
        {
            txtFechaVencimiento.Text = dtpFechaVencimiento.Text;
        }

        private void txtFechaVencimiento_TextChanged(object sender, EventArgs e)
        {
            dtpFechaVencimiento.Text = txtFechaVencimiento.Text;
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstado.SelectedItem.Equals("Activado"))
            {
                txtEstado.Text = "1";
            }
            else
            {
                txtEstado.Text = "0";
            }
        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {
            if (txtEstado.Text.Equals("1"))
            {
                cboEstado.Text = "Activado";
            }
            else
            {
                cboEstado.Text = "Desactivado";
            }
        }
    }
}
