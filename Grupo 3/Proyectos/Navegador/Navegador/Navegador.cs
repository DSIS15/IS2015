
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Navegador: UserControl
    {
        csNegocio Negocio = new csNegocio();
        csEntidades Entidades = new csEntidades();
        public event EventHandler btnBeforeNuevo, btnAfterNuevo;
        public event EventHandler btnBeforeGuardar, btnAfterGuardar;
        public event EventHandler btnBeforeBuscar, btnAfterBuscar;
        public event EventHandler btnBeforeModificar, btnAfterModificar;
        public event EventHandler btnBeforeEliminar, btnAfterEliminar;
        public event EventHandler btnBeforeLimpiar, btnAfterLimpiar;
        public event EventHandler btnBeforeRecargar, btnAfterRecargar;
        public event EventHandler btnBeforeImprimir, btnAfterImprimir;
        public event EventHandler btnBeforePrimero, btnAfterPrimero;
        public event EventHandler btnBeforeAnterior, btnAfterAnterior;
        public event EventHandler btnBeforeSiguiente, btnAfterSiguiente;
        public event EventHandler btnBeforeUltimo, btnAfterUltimo;
        public bool bTablaMaster = true;
        private ArrayList AlDatosEntrada = new ArrayList();
        private ArrayList alDatosSalida = new ArrayList();
        private string SNombreTabla = string.Empty;
        private int iCodigo = 0;
        private bool bModificarRegistro = false;
        private bool BEjecutarEvento = true;
        private int iContador = 0;
        
        public ArrayList alDatosEntrada
        {
            get { return AlDatosEntrada; }
            set { AlDatosEntrada = value; }
        }

        public bool bEjecutarEvento
        {
            get { return BEjecutarEvento; }
            set { BEjecutarEvento = value; }
        }
        public string sNombreTabla
        {
            get { return SNombreTabla; }
            set { SNombreTabla = value; }
        }

        public Navegador()
        {
            InitializeComponent();
            bModificarRegistro = false;
            iContador = 0;
        }

        public void vIniciarNavegador()
        {
            EventArgs e = new EventArgs();
            btnRecargar_Click(this, e);
        }

        private void vActivarLimpiarTextBoxes(bool bActivar, bool bLimpiar)
        {
            foreach (TextBox TxtBoxes in alDatosEntrada)
            {
                TxtBoxes.Enabled = bActivar;
                if (bLimpiar)
                {
                    TxtBoxes.Text = string.Empty;
                }
            }      
        }

        protected virtual void vValidarEvento(EventHandler ehEvento, EventArgs eaE)
        {
            if (ehEvento != null)
            {
                ehEvento(this, eaE);
            }
        }

        private void vMostrarDatos()
        {
            if (alDatosSalida != null)
            {
                for (int iPosicion = 0; iPosicion < alDatosEntrada.Count; iPosicion++)
                {
                    TextBox txtTextBoxes = (TextBox)alDatosEntrada[iPosicion];
                    if (alDatosSalida.Count != 0)
                    {
                        ArrayList alDatos = (ArrayList)alDatosSalida[iContador];
                        txtTextBoxes.Text = alDatos[iPosicion].ToString();
                    }
                    else
                    {
                        txtTextBoxes.Text = string.Empty;
                    }
                }
            }
            vActivarLimpiarTextBoxes(false, false);
        }

        private void vRestriccionBotones(bool bEstadoBoton)
        {
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = false;
            btnBuscar.Enabled = false;
            btnModificar.Enabled = false;
            btnLimpiar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRecargar.Enabled = false;
            btnImprimir.Enabled = false;
            btnPrimero.Enabled = false;
            btnAnterior.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            btnCancelar.Enabled = false;
            foreach (ArrayList alFila in Capas.csParametros.AlPrivilegios)
            {
                if (string.Compare(alFila[0].ToString(), sNombreTabla) == 0)
                {
                    if (string.Compare(alFila[1].ToString(),"1")==0)
                    {
                        btnNuevo.Enabled = bEstadoBoton;
                    }
                    if (string.Compare(alFila[2].ToString(), "1") == 0)
                    {
                        btnModificar.Enabled = bEstadoBoton;
                    }
                    if (string.Compare(alFila[3].ToString(), "1") == 0)
                    {
                        btnEliminar.Enabled = bEstadoBoton;
                    }
                    if (string.Compare(alFila[4].ToString(), "1") == 0)
                    {
                        btnImprimir.Enabled = bEstadoBoton;
                    }
                    if (string.Compare(alFila[5].ToString(), "1") == 0)
                    {
                        btnBuscar.Enabled = bEstadoBoton;
                        btnPrimero.Enabled = bEstadoBoton;
                        btnAnterior.Enabled = bEstadoBoton;
                        btnSiguiente.Enabled = bEstadoBoton;
                        btnUltimo.Enabled = bEstadoBoton;
                    }
                }
            }
            btnRecargar.Enabled = bEstadoBoton;
            btnGuardar.Enabled = !bEstadoBoton;
            btnLimpiar.Enabled = !bEstadoBoton;
            btnCancelar.Enabled = !bEstadoBoton;   
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeNuevo, e);
            if (bEjecutarEvento)
            {
                vActivarLimpiarTextBoxes(true, true);
                vValidarEvento(btnAfterNuevo, e);
                vRestriccionBotones(false);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeGuardar, e);
            if (bEjecutarEvento)
            {
                Negocio.SNombreTabla = sNombreTabla;
                if (bModificarRegistro)
                {
                    TextBox txtCodigo = (TextBox)alDatosEntrada[0];
                    iCodigo = Convert.ToInt32(txtCodigo.Text);
                    Negocio.vModificarRegistro(alDatosEntrada, bTablaMaster);
                    bModificarRegistro = false;
                    vActivarLimpiarTextBoxes(false, false);
                }
                else
                {
                    Entidades.SNombreTabla = sNombreTabla;
                    iCodigo = Entidades.iObtenerCodigo();
                    Negocio.vInsertarRegistro(alDatosEntrada, iCodigo.ToString(), bTablaMaster);
                    vActivarLimpiarTextBoxes(false, true);
                }
                btnRecargar_Click(this, e);
                if (iCodigo > 0)
                {
                    iContador = iCodigo - 1;
                }
                vMostrarDatos();
                vValidarEvento(btnAfterGuardar, e);
                vRestriccionBotones(true);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeBuscar, e);
            if (bEjecutarEvento)
            {
                wfBuscar Buscar = new wfBuscar();
                Buscar.SNombreTabla = sNombreTabla;
                Buscar.ShowDialog();
                Negocio.SNombreTabla = sNombreTabla;
                if (Buscar.bEjecutarBusqueda)
                {
                    alDatosSalida = Negocio.alConsultarRegistro(Buscar.AlDatosSalida);
                    iContador = 0;
                    vMostrarDatos();
                    vValidarEvento(btnAfterBuscar, e);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeModificar, e);
            if (bEjecutarEvento)
            {
                vActivarLimpiarTextBoxes(true, false);
                vValidarEvento(btnAfterModificar, e);
                bModificarRegistro = true;
                vRestriccionBotones(false);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeLimpiar, e);
            if (bEjecutarEvento)
            {
                vActivarLimpiarTextBoxes(true, true);
                vValidarEvento(btnAfterLimpiar, e);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea eliminar el registro?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bEjecutarEvento = true;
                vValidarEvento(btnBeforeEliminar, e);
                if (bEjecutarEvento)
                {
                    Negocio.SNombreTabla = sNombreTabla;
                    Negocio.vEliminarRegistro(alDatosEntrada, bTablaMaster);
                    vActivarLimpiarTextBoxes(false, true);
                    btnRecargar_Click(this, e);
                    TextBox txtCodigo = (TextBox)alDatosEntrada[0];
                    iCodigo = Convert.ToInt32(txtCodigo.Text);
                    iContador = iCodigo - 1;
                    vMostrarDatos();
                    vValidarEvento(btnAfterEliminar, e);
                }
            }
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeRecargar, e);
            if (bEjecutarEvento)
            {
                Negocio.SNombreTabla = sNombreTabla;
                alDatosSalida = Negocio.alConsultarRegistro(null);
                vMostrarDatos();
                vValidarEvento(btnAfterRecargar, e);
                vRestriccionBotones(true);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeImprimir, e);
            if (bEjecutarEvento)
            {
                vValidarEvento(btnAfterImprimir, e);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforePrimero, e);
            if (bEjecutarEvento)
            {
                iContador = 0;
                vMostrarDatos();
                vValidarEvento(btnAfterPrimero, e);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeAnterior, e);
            if (bEjecutarEvento)
            {
                if (iContador > 0)
                {
                    iContador--;
                }
                vMostrarDatos();
                vValidarEvento(btnAfterAnterior, e);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeSiguiente, e);
            if (bEjecutarEvento)
            {
                if (iContador < alDatosSalida.Count - 1)
                {
                    iContador++;
                }
                vMostrarDatos();
                vValidarEvento(btnAfterSiguiente, e);
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bEjecutarEvento = true;
            vValidarEvento(btnBeforeUltimo, e);
            if (bEjecutarEvento)
            {
                iContador = alDatosSalida.Count - 1;
                vMostrarDatos();
                vValidarEvento(btnAfterUltimo, e);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente desea cancelar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                vIniciarNavegador();
            }
        }

        public bool bValidarTeclasFuncion(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            EventArgs e = new EventArgs();
            bool bRespuesta = true;
            switch (keyData)
            {
                case Keys.F1: if (btnNuevo.Enabled) btnNuevo_Click(this, e); break;
                case Keys.F2: if (btnGuardar.Enabled) btnGuardar_Click(this, e); break;
                case Keys.F3: if (btnBuscar.Enabled) btnBuscar_Click(this, e); break;
                case Keys.F4: if (btnModificar.Enabled) btnModificar_Click(this, e); break;
                case Keys.F5: if (btnLimpiar.Enabled) btnLimpiar_Click(this, e); break;
                case Keys.F6: if (btnEliminar.Enabled) btnEliminar_Click(this, e); break;
                case Keys.F7: if (btnRecargar.Enabled) btnRecargar_Click(this, e); break;
                case Keys.F8: if (btnImprimir.Enabled) btnImprimir_Click(this, e); break;
                case Keys.F9: if (btnPrimero.Enabled) btnPrimero_Click(this, e); break;
                case Keys.F10: if (btnAnterior.Enabled) btnAnterior_Click(this, e); break;
                case Keys.F11: if (btnSiguiente.Enabled) btnSiguiente_Click(this, e); break;
                case Keys.F12: if (btnUltimo.Enabled) btnUltimo_Click(this, e); break;
                case Keys.Escape: if (btnCancelar.Enabled) btnCancelar_Click(this, e); break;
                default: bRespuesta = false; break;
            }
            return bRespuesta;
        }

        private void Navegador_Load(object sender, EventArgs e)
        {
            vRestriccionBotones(true);
        }
    }
}
