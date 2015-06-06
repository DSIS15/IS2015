using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capas
{
    public class csArbolPolizas
    {
        csNegocio Negocio = new csNegocio();

        private class NodoArbol
        {
            public NodoArbol Nizq;
            public NodoArbol Nder;
            public string sNomenc;
            public string sPredec;
            public float fSactual;
            public float fSanterior;
        }

        public static void vActualizarCuentas(string sNomenclatura, float fSaldo)
        {
            NodoArbol Arbol = null;
            ArrayList alCuentas = ODBCconnector.csFunciones.alConsultarQuery("select nomenc_cta, predec_cta, sactual_cta from tabm_cuenta where estado_cta=1");
            foreach (ArrayList alFila in alCuentas)
            {
                vCargarArbol(ref Arbol, Arbol, alFila[0].ToString(), alFila[1].ToString(), Convert.ToSingle(alFila[2].ToString()));
            }
            vCargarArbol(ref Arbol, Arbol, sNomenclatura, "", fSaldo);
        }

        private static void vCargarArbol(ref NodoArbol Arbol, NodoArbol ArbolT, string sNomenclatura, string sPredecesor, float fSaldo)
        {
            NodoArbol p;
            NodoArbol n;
            if (Arbol == null)
            {
                n = new NodoArbol();
                n.sNomenc = sNomenclatura;
                n.sPredec = sPredecesor;
                n.Nder = null;
                n.Nizq = null;
                n.fSanterior = 0;
                n.fSactual = fSaldo;
                Arbol = n;
            }
            else
            {
                p = Arbol;
                if (string.Compare(sNomenclatura,p.sNomenc) < 0)
                {
                    vCargarArbol(ref p.Nizq, ArbolT, sNomenclatura, sPredecesor, fSaldo);
                }
                else
                {
                    if (string.Compare(sNomenclatura, p.sNomenc) > 0)
                    {
                        vCargarArbol(ref p.Nder, ArbolT, sNomenclatura, sPredecesor, fSaldo);
                    }
                    else
                    {
                        p.fSanterior = p.fSactual;
                        p.fSactual = p.fSactual + fSaldo;
                        bool bResp = ODBCconnector.csFunciones.bEjecutarQuery("update tabm_cuenta set santerior_cta='" + p.fSanterior.ToString() + "', sactual_cta='" + p.fSactual.ToString() + "' where nomenc_cta='" + p.sNomenc.ToString() + "'", "Actualizado", false, "tabm_cuenta");
                        vActualizarCuenta(ref ArbolT, ArbolT, p.sPredec, fSaldo);
                    }
                }
            }
        }

        private static void vActualizarCuenta(ref NodoArbol Arbol, NodoArbol ArbolT, string sNomenclatura, float fSaldo)
        {
            NodoArbol p;
            if (Arbol != null)
            {
                p = Arbol;
                if (string.Compare(sNomenclatura, p.sNomenc) < 0)
                {
                    vActualizarCuenta(ref p.Nizq, ArbolT, sNomenclatura, fSaldo);
                }
                else
                {
                    if (string.Compare(sNomenclatura, p.sNomenc) > 0)
                    {
                        vActualizarCuenta(ref p.Nder, ArbolT, sNomenclatura, fSaldo);
                    }
                    else
                    {
                        p.fSanterior = p.fSactual;
                        p.fSactual = p.fSactual + fSaldo;
                        bool bResp = ODBCconnector.csFunciones.bEjecutarQuery("update tabm_cuenta set santerior_cta='" + p.fSanterior.ToString() + "', sactual_cta='" + p.fSactual.ToString() + "' where nomenc_cta='" + p.sNomenc.ToString() + "'", "Actualizado", false, "tabm_cuenta");
                        if (string.Compare(p.sPredec, "0") != 0)
                        {
                            vActualizarCuenta(ref ArbolT, ArbolT, p.sPredec, fSaldo);
                        }                        
                    }
                }
            }
        }
    }
}
