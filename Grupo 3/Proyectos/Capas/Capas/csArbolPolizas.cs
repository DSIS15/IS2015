using System;
using System.Collections;
using System.Linq;
using System.Text;

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
            public float fSanterior;
            public float fCargos;
            public float fAbonos;
            public float fSactual;
        }

        public static void vActualizarCuentas(string sNomenclatura, float fCargo, float fAbono)
        {
            NodoArbol Arbol = null;
            ArrayList alCuentas = ODBCconnector.csFunciones.alConsultarQuery("select nomenc_cta, predec_cta, santerior_cta, cargo_cta, abono_cta, sactual_cta from tabm_cuenta where estado_cta=1");
            foreach (ArrayList alFila in alCuentas)
            {
                vCargarArbol(ref Arbol, Arbol, alFila[0].ToString(), alFila[1].ToString(), Convert.ToSingle(alFila[2].ToString()), Convert.ToSingle(alFila[3].ToString()), Convert.ToSingle(alFila[4].ToString()), Convert.ToSingle(alFila[5].ToString()));
            }
            vCargarArbol(ref Arbol, Arbol, sNomenclatura, "", 0, fCargo, fAbono, 0);
        }

        private static void vCargarArbol(ref NodoArbol Arbol, NodoArbol ArbolT, string sNomenclatura, string sPredecesor, float fSanterior, float fCargo, float fAbono, float fSaldo)
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
                n.fSanterior = fSanterior;
                n.fCargos = fCargo;
                n.fAbonos = fAbono;
                n.fSactual = fSanterior + (n.fCargos - n.fAbonos);                
                Arbol = n;
            }
            else
            {
                p = Arbol;
                if (string.Compare(sNomenclatura,p.sNomenc) < 0)
                {
                    vCargarArbol(ref p.Nizq, ArbolT, sNomenclatura, sPredecesor, fSanterior, fCargo, fAbono, fSaldo);
                }
                else
                {
                    if (string.Compare(sNomenclatura, p.sNomenc) > 0)
                    {
                        vCargarArbol(ref p.Nder, ArbolT, sNomenclatura, sPredecesor, fSanterior, fCargo, fAbono, fSaldo);
                    }
                    else
                    {
                        p.fCargos = p.fCargos + fCargo;
                        p.fAbonos = p.fAbonos + fAbono;
                        p.fSactual = p.fSanterior + (p.fCargos - p.fAbonos);                        
                        bool bResp = ODBCconnector.csFunciones.bEjecutarQuery("update tabm_cuenta set cargo_cta='" + p.fCargos.ToString() + "', abono_cta='" + p.fAbonos.ToString() + "', sactual_cta='" + p.fSactual.ToString() + "' where nomenc_cta='" + p.sNomenc.ToString() + "'", "Actualizado", false, "tabm_cuenta");
                        vActualizarCuenta(ref ArbolT, ArbolT, p.sPredec, fSanterior, fCargo, fAbono, fSaldo);
                    }
                }
            }
        }

        private static void vActualizarCuenta(ref NodoArbol Arbol, NodoArbol ArbolT, string sNomenclatura, float fSanterior, float fCargo, float fAbono, float fSaldo)
        {
            NodoArbol p;
            if (Arbol != null)
            {
                p = Arbol;
                if (string.Compare(sNomenclatura, p.sNomenc) < 0)
                {
                    vActualizarCuenta(ref p.Nizq, ArbolT, sNomenclatura, fSanterior, fCargo, fAbono, fSaldo);
                }
                else
                {
                    if (string.Compare(sNomenclatura, p.sNomenc) > 0)
                    {
                        vActualizarCuenta(ref p.Nder, ArbolT, sNomenclatura, fSanterior, fCargo, fAbono, fSaldo);
                    }
                    else
                    {
                        p.fCargos = p.fCargos + fCargo;
                        p.fAbonos = p.fAbonos + fAbono;
                        p.fSactual = p.fSanterior + (p.fCargos - p.fAbonos);                        
                        bool bResp = ODBCconnector.csFunciones.bEjecutarQuery("update tabm_cuenta set cargo_cta='" + p.fCargos.ToString() + "', abono_cta='" + p.fAbonos.ToString() + "', sactual_cta='" + p.fSactual.ToString() + "' where nomenc_cta='" + p.sNomenc.ToString() + "'", "Actualizado", false, "tabm_cuenta");
                        if (string.Compare(p.sPredec, "0") != 0)
                        {                            
                            vActualizarCuenta(ref ArbolT, ArbolT, p.sPredec, fSanterior, fCargo, fAbono, fSaldo);
                        }                        
                    }
                }
            }
        }
    }
}
