using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCF
{
    public partial class wfMenuPrincipal : Form
    {
        ArrayList alPestanasContables = new ArrayList();
        ArrayList alPestanasFinancieras = new ArrayList();
        wfLogoSCF Logotipo = new wfLogoSCF();
        private bool bSesionIniciada;
        private int iPestañaActiva = 0;
        
        public wfMenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            alPestanasContables.Add(btnC1_2);
            alPestanasContables.Add(btnC1_1);
            alPestanasContables.Add(btnC2_4);
            alPestanasContables.Add(btnC2_3);
            alPestanasContables.Add(btnC2_2);
            alPestanasContables.Add(btnC2_1);
            alPestanasContables.Add(btnC3_2);
            alPestanasContables.Add(btnC3_1);
            alPestanasContables.Add(btnC4_1);
            alPestanasFinancieras.Add(btnF1_2);
            alPestanasFinancieras.Add(btnF1_1);
            alPestanasFinancieras.Add(btnF2_2);
            alPestanasFinancieras.Add(btnF2_1);
            alPestanasFinancieras.Add(btnF3_3);
            alPestanasFinancieras.Add(btnF3_2);
            alPestanasFinancieras.Add(btnF3_1);
            Logotipo.MdiParent = this;
            Logotipo.Dock = DockStyle.Fill;
            Logotipo.Show();
            tsslUsuario.Text = Capas.csParametros.AlUsuario[2].ToString();
            tsslPerfil.Text = Capas.csParametros.AlUsuario[3].ToString();
            tsmiContable_Click(this, e);
            tssllEmpresa_Click(this, e);
            tssllMoneda_Click(this, e);
            ODBCconnector.csBitacora.vRegistarEnBitacora("Inicio de sesión");
            bSesionIniciada = true;
        }

        private void vValidacionFormulario(string sNombreFormulario, Form frmFormulario)
        {
            Form frmValidacion = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == sNombreFormulario).SingleOrDefault();
            if (frmValidacion == null)
            {
                frmFormulario.MdiParent = this;
                frmFormulario.Show();
            }
        }

        private void vCerrarVentanas()
        {
            foreach (Form fmFormularioHijo in MdiChildren)
            {
                if (string.Compare(fmFormularioHijo.Text, "SCF") != 0)
                {
                    fmFormularioHijo.Close();
                }
            }
        }

        private void wfMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bSesionIniciada)
            {
                EventArgs ev = new EventArgs();            
                tsmiSalir_Click(this, ev);
            }
        }

        private void tsmiSalir_Click(object sender, EventArgs e)
        {
            bSesionIniciada = false;
            ODBCconnector.csBitacora.vRegistarEnBitacora("Cierre de sesión");
            Application.Exit();
        }

        private void tsmiCascada_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tsmiMosaicoVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void tsmiMosaicoHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void tsmiCerrarTodo_Click(object sender, EventArgs e)
        {
            vCerrarVentanas();
        }

        private void vAbrirTabs(int iIndex, ArrayList alPestanas)
        {
            foreach (Button btnBoton in alPestanas)
            {
                if (Convert.ToInt32(btnBoton.Tag) == iIndex)
                {
                    btnBoton.Visible = true;
                }
                else
                {
                    btnBoton.Visible = false;
                }                
            }
        }

        private void vValidarPestanaActiva(int iPestaña, ArrayList alPestanas)
        {
            if (iPestañaActiva == iPestaña)
            {
                iPestañaActiva = 0;
            }
            else
            {
                iPestañaActiva = iPestaña;
            }
            vAbrirTabs(iPestañaActiva, alPestanas);
        }

        private void tsmiAcercaDe_Click(object sender, EventArgs e)
        {
            wfAcercaDe AcercaDe = new wfAcercaDe();
            AcercaDe.ShowDialog();
        }
                
        private void tsmiContable_Click(object sender, EventArgs e)
        {
            pnlPanelContable.Dock = DockStyle.Fill;
            pnlPanelContable.Visible = true;
            pnlPanelFinanciero.Visible = false;
            vAbrirTabs(0, alPestanasContables);            
        }

        private void tsmiFinanciero_Click(object sender, EventArgs e)
        {
            pnlPanelFinanciero.Dock = DockStyle.Fill;
            pnlPanelFinanciero.Visible = true;
            pnlPanelContable.Visible = false;
            vAbrirTabs(0, alPestanasFinancieras);
        }

        private void tsmiBitacora_Click(object sender, EventArgs e)
        {
            Seguridad.wfBitacora Bitacora = new Seguridad.wfBitacora();
            vValidacionFormulario("wfBitacora", Bitacora);
        }

        private void tsmiPerfiles_Click(object sender, EventArgs e)
        {
            Seguridad.wfPerfiles Perfiles = new Seguridad.wfPerfiles();
            vValidacionFormulario("wfPerfiles", Perfiles);
        }

        private void tsmiUsuarios_Click(object sender, EventArgs e)
        {
            Seguridad.wfUsuarios Usuarios = new Seguridad.wfUsuarios();
            vValidacionFormulario("wfUsuarios", Usuarios);
        }

        private void tsmiAmortizaciones_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiDepreciaciones_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiEmpresas_Click(object sender, EventArgs e)
        {
            Seguridad.wfEmpresas Empresas = new Seguridad.wfEmpresas();
            vValidacionFormulario("wfEmpresas", Empresas);
        }

        private void tsmiImpuestos_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiMonedas_Click(object sender, EventArgs e)
        {
            Seguridad.wfMonedas Monedas = new Seguridad.wfMonedas();
            vValidacionFormulario("wfMonedas", Monedas);
        }

        private void tssllEmpresa_Click(object sender, EventArgs e)
        {
            Seguridad.wfEmpresas Empresas = new Seguridad.wfEmpresas();
            Empresas.ShowDialog();
            ArrayList alEmpresa = new ArrayList();
            alEmpresa = ODBCconnector.csFunciones.alConsultarQuery("select cod_empsa, nomcomercial_empsa, rznsocial_empsa, dire_empsa, nit_empsa from tabm_empresa where cod_empsa='" + Empresas.sCodigo + "'");
            Capas.csParametros.AlEmpresa = (ArrayList)alEmpresa[0];
            tsslEmpresa.Text = Capas.csParametros.AlEmpresa[1].ToString();
        }

        private void tsslEmpresa_Click(object sender, EventArgs e)
        {
            tssllEmpresa_Click(this, e);
        }

        private void tssllMoneda_Click(object sender, EventArgs e)
        {
            Seguridad.wfMonedas Monedas = new Seguridad.wfMonedas();
            Monedas.ShowDialog();
            ArrayList alMoneda = new ArrayList();
            alMoneda = ODBCconnector.csFunciones.alConsultarQuery("select cod_mda, concat(moneda_mda,' (',abrev_mda,')') as 'moneda', tipocambio_mda from tabm_moneda where cod_mda='" + Monedas.sCodigo + "'");
            Capas.csParametros.AlMoneda = (ArrayList)alMoneda[0];
            tsslMoneda.Text = Capas.csParametros.AlMoneda[1].ToString();
        }

        private void tsslMoneda_Click(object sender, EventArgs e)
        {
            tssllMoneda_Click(this, e);
        }

        private void btnCuentas_Click(object sender, EventArgs e)
        {
            vValidarPestanaActiva(1, alPestanasContables);
        }

        private void btnInformesContables_Click(object sender, EventArgs e)
        {
            vValidarPestanaActiva(2, alPestanasContables);
        }

        private void btnLibrosFiscales_Click(object sender, EventArgs e)
        {
            vValidarPestanaActiva(3, alPestanasContables);
        }

        private void btnOperacionesContables_Click(object sender, EventArgs e)
        {
            vValidarPestanaActiva(4, alPestanasContables);
        }
                
        private void btnC1_1_Click(object sender, EventArgs e)
        {
            Operaciones.wfCuentas CatCuentas = new Operaciones.wfCuentas();
            vValidacionFormulario("wfCuentas", CatCuentas);
        }

        private void btnC1_2_Click(object sender, EventArgs e)
        {
            Operaciones.wfTipoCuenta TipoCuentas = new Operaciones.wfTipoCuenta();
            vValidacionFormulario("wfTipoCuenta", TipoCuentas);
        }
        
        private void btnC2_1_Click(object sender, EventArgs e)
        {
            EstadosFinancieros.wfEstadoFinanciero BalanceSaldos = new EstadosFinancieros.wfEstadoFinanciero();
            BalanceSaldos.sEstadoFinanciero = "Balance de Saldos";
            vValidacionFormulario("wfEstadoFinanciero", BalanceSaldos);
        }

        private void btnC2_2_Click(object sender, EventArgs e)
        {
            EstadosFinancieros.wfEstadoFinanciero BalanceGeneral = new EstadosFinancieros.wfEstadoFinanciero();
            BalanceGeneral.sEstadoFinanciero = "Balance General";
            vValidacionFormulario("wfEstadoFinanciero", BalanceGeneral);
        }

        private void btnC2_3_Click(object sender, EventArgs e)
        {
            EstadosFinancieros.wfEstadoFinanciero EstadoResultados = new EstadosFinancieros.wfEstadoFinanciero();
            EstadoResultados.sEstadoFinanciero = "Estado de Resultados";
            vValidacionFormulario("wfEstadoFinanciero", EstadoResultados);
        }

        private void btnC2_4_Click(object sender, EventArgs e)
        {
            EstadosFinancieros.wfEstadoFinanciero FlujoEfectivo = new EstadosFinancieros.wfEstadoFinanciero();
            FlujoEfectivo.sEstadoFinanciero = "Flujo de Efectivo";
            vValidacionFormulario("wfEstadoFinanciero", FlujoEfectivo);
        }

        private void btnC3_1_Click(object sender, EventArgs e)
        {
            Compras_Ventas.wfCompraVenta Compras = new Compras_Ventas.wfCompraVenta();
            vValidacionFormulario("wfCompraVenta", Compras);
        }

        private void btnC3_2_Click(object sender, EventArgs e)
        {
            Compras_Ventas.wfCompraVenta Ventas = new Compras_Ventas.wfCompraVenta();
            vValidacionFormulario("wfCompraVenta", Ventas);
        }

        private void btnC4_1_Click(object sender, EventArgs e)
        {
            //Contable.wfPolizas Polizas = new Contable.wfPolizas();
            //vValidacionFormulario("wfPolizas", Polizas);
        }

        private void btnInformesFinancieros_Click(object sender, EventArgs e)
        {
            vValidarPestanaActiva(1, alPestanasFinancieras);
        }

        private void btnMovimientosBancarios_Click(object sender, EventArgs e)
        {
            vValidarPestanaActiva(2, alPestanasFinancieras);
        }

        private void btnOperacionesFinancieras_Click(object sender, EventArgs e)
        {
            vValidarPestanaActiva(3, alPestanasFinancieras);
        }

        private void btnF1_1_Click(object sender, EventArgs e)
        {
            ConciliacionBancaria.wfConciliacionesBancarias ConciliacionBancaria = new ConciliacionBancaria.wfConciliacionesBancarias();
            vValidacionFormulario("wfConciliacionesBancarias", ConciliacionBancaria);
        }

        private void btnF1_2_Click(object sender, EventArgs e)
        {
            Movimientos.wfMovimientos MovimientosBancarios = new Movimientos.wfMovimientos();
            vValidacionFormulario("wfMovimientos", MovimientosBancarios);
        }

        private void btnF2_1_Click(object sender, EventArgs e)
        {
            Movimientos.wfMovimientos Movimientos = new Movimientos.wfMovimientos();
            vValidacionFormulario("wfMovimiento", Movimientos);
        }

        private void btnF2_2_Click(object sender, EventArgs e)
        {
            Movimientos.wfTipoDeMovimiento TiposMovimientos = new Movimientos.wfTipoDeMovimiento();
            vValidacionFormulario("wfTipoDeMovimiento", TiposMovimientos);
        }

        private void btnF3_1_Click(object sender, EventArgs e)
        {
            ConciliacionBancaria.wfProcesoConciBancaria ProcesoConciBancaria = new ConciliacionBancaria.wfProcesoConciBancaria();
            vValidacionFormulario("wfProcesoConciBancaria", ProcesoConciBancaria);
        }

        private void btnF3_2_Click(object sender, EventArgs e)
        {
            ConciliacionBancaria.wfCuentasBancarias CuentasBancarias = new ConciliacionBancaria.wfCuentasBancarias();
            vValidacionFormulario("wfCuentaBanco", CuentasBancarias);
        }

        private void btnF3_3_Click(object sender, EventArgs e)
        {
            ConciliacionBancaria.wfEstadosCuenta EstadosCuenta = new ConciliacionBancaria.wfEstadosCuenta();
            vValidacionFormulario("wfEstadoCuentaBanco", EstadosCuenta);
        }
    }
}