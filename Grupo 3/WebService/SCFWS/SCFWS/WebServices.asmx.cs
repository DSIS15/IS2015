using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;

namespace SCFWS
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServices : System.Web.Services.WebService
    {
        private string sObtenerCodigo(string sNombreTabla)
        {
            string sQuery = "select * from " + sNombreTabla;
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
            return iCodigo.ToString();
        }

        [WebMethod]
        public string sAgregarCuentasBancarias(string sFilePath, string sEmpresa, string sMoneda)
        {
            string sMensaje = string.Empty;
            try
            {
                ArrayList alCuentasBancarias = new ArrayList();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(sFilePath);
                XmlNodeList CuentasBancarias = xmlDoc.GetElementsByTagName("lista_cuentasbancarias");
                XmlNodeList CuentaBancaria = ((XmlElement)CuentasBancarias[0]).GetElementsByTagName("cuentabancaria");
                foreach (XmlElement xmlNodo in CuentaBancaria)
                {
                    ArrayList alFila = new ArrayList();
                    XmlNodeList xnlNumCuenta = xmlNodo.GetElementsByTagName("numcuenta");
                    XmlNodeList xnlNombre = xmlNodo.GetElementsByTagName("nombre");
                    XmlNodeList xnlBanco = xmlNodo.GetElementsByTagName("banco");
                    XmlNodeList xnlSaldo = xmlNodo.GetElementsByTagName("saldo");
                    alFila.Add(sEmpresa);
                    alFila.Add(sMoneda);
                    alFila.Add(xnlNumCuenta[0].InnerText.ToString());
                    alFila.Add(xnlNombre[0].InnerText.ToString());
                    alFila.Add(xnlBanco[0].InnerText.ToString());
                    alFila.Add(xnlSaldo[0].InnerText.ToString());
                    alCuentasBancarias.Add(alFila);
                }
                foreach (ArrayList alFila in alCuentasBancarias)
                {
                    bool bResp = ODBCconnector.csFunciones.bEjecutarQuery("insert into tabm_ctabco values ('" + sObtenerCodigo("tabm_ctabco") + "','" + alFila[0].ToString() + "','" + alFila[1].ToString() + "','" + alFila[2].ToString() + "','" + alFila[3].ToString() + "','" + alFila[4].ToString() + "','" + alFila[5].ToString() + "','1')", "insertado", false, "tabm_ctabco");
                }
                sMensaje = "Cuentas bancarias agregadas correctamente";
            }
            catch (Exception ex)
            {
                sMensaje = "Error al agregar las cuentas bancarias";
            }
            //File.Delete(sFilePath);
            return sMensaje;
        }

        [WebMethod]
        public string sAgregarMovimientosBancarios(string sFilePath, string sEmpresa, string sMoneda)
        {
            string sMensaje = string.Empty;
            try
            {
                ArrayList alMovimientosBancarios = new ArrayList();
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.Load(sFilePath);
                XmlNodeList MovimientosBancarios = xmlDoc.GetElementsByTagName("lista_movimientosbancarios");
                XmlNodeList MovimientoBancario = ((XmlElement)MovimientosBancarios[0]).GetElementsByTagName("movimientobancario");
                foreach (XmlElement xmlNodo in MovimientoBancario)
                {
                    ArrayList alFila = new ArrayList();
                    XmlNodeList xnlMovimiento = xmlNodo.GetElementsByTagName("movimiento");
                    XmlNodeList xnlCuenta = xmlNodo.GetElementsByTagName("cuenta");
                    XmlNodeList xnlFecha = xmlNodo.GetElementsByTagName("fecha");
                    XmlNodeList xnlCorrelativo = xmlNodo.GetElementsByTagName("correlativo");
                    XmlNodeList xnlDescripcion = xmlNodo.GetElementsByTagName("descripcion");
                    XmlNodeList xnlDebito = xmlNodo.GetElementsByTagName("debito");
                    XmlNodeList xnlCredito = xmlNodo.GetElementsByTagName("credito");
                    alFila.Add(sEmpresa);
                    alFila.Add(sMoneda);
                    ArrayList alDatos;
                    ArrayList alFilaDato;
                    alDatos = ODBCconnector.csFunciones.alConsultarQuery("select cod_tmov from tabm_tmovimiento where nombre_tmov='" + xnlMovimiento[0].InnerText.ToString() + "'");
                    alFilaDato = (ArrayList)alDatos[0];
                    alFila.Add(alFilaDato[0].ToString());
                    alDatos = ODBCconnector.csFunciones.alConsultarQuery("select cod_ctabco from tabm_ctabco where numcta_ctabco='" + xnlCuenta[0].InnerText.ToString() + "'");
                    alFilaDato = (ArrayList)alDatos[0];
                    alFila.Add(alFilaDato[0].ToString());
                    alFila.Add(xnlFecha[0].InnerText.ToString());
                    alFila.Add(xnlCorrelativo[0].InnerText.ToString());
                    alFila.Add(xnlDescripcion[0].InnerText.ToString());
                    alFila.Add(xnlDebito[0].InnerText.ToString());
                    alFila.Add(xnlCredito[0].InnerText.ToString());
                    alMovimientosBancarios.Add(alFila);
                }
                foreach (ArrayList alFila in alMovimientosBancarios)
                {
                    bool bResp = ODBCconnector.csFunciones.bEjecutarQuery("insert into tabm_movimiento values ('" + sObtenerCodigo("tabm_movimiento") + "','" + alFila[0].ToString() + "','" + alFila[1].ToString() + "','" + alFila[2].ToString() + "','" + alFila[3].ToString() + "','" + alFila[4].ToString() + "','" + alFila[5].ToString() + "','" + alFila[6].ToString() + "','" + alFila[7].ToString() + "','" + alFila[8].ToString() + "','1')", "insertado", false, "tabm_movimiento");
                }
                sMensaje = "Movimientos bancarios agregados correctamente";
            }
            catch (Exception ex)
            {
                sMensaje = "Error al agregar los movimientos bancarios";
            }
            //File.Delete(sFilePath);
            return sMensaje;
        }
    }
}
