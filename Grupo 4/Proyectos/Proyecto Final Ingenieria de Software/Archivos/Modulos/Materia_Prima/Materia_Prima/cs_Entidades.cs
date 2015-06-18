using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Materia_Prima
{
    public class cs_Entidades
    {
        public class cs_Pedido
        {
            public int codigoPed { get; set; }
            public int codigoProv { get; set; }
            public int codigoMp { get; set; }
            public string unidadPed { get; set; }
            public float cantidadPed { get; set; }
            public DateTime fechaPed { get; set; }

            public cs_Pedido() { }

            public cs_Pedido(int codigoPed, int codigoProv, int codigoMp, string unidadPed, float cantidadPed,
                                DateTime fechaPed)
            {
                this.codigoPed = codigoPed;
                this.codigoProv = codigoProv;
                this.codigoMp = codigoMp;
                this.unidadPed = unidadPed;
                this.cantidadPed = cantidadPed;
                this.fechaPed = fechaPed;
            }

        }

        public class cs_MateriaPrima
        {
            public int cod_mp { get; set; }
            public string nom_mp { get; set; }
            public string unimedida_mp { get; set; }
            public int canitdad_mp { get; set; }
            public float precio_mp { get; set; }

            public cs_MateriaPrima() { }

            public cs_MateriaPrima(int cod_mp, string nom_mp, string unimedida_mp, int canitdad_mp,
                                  float precio_mp)
            {
                this.cod_mp = cod_mp;
                this.nom_mp = nom_mp;
                this.unimedida_mp = unimedida_mp;
                this.canitdad_mp = canitdad_mp;
                this.precio_mp = precio_mp;
            }
        }

        public static void SoloNumeros(KeyPressEventArgs pE)
        {
            if (char.IsDigit(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
                MessageBox.Show("Solo Numeros");
            }
        }
        public static void SoloLetras(KeyPressEventArgs pE)
        {
            if (Char.IsLetter(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsControl(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else if (Char.IsSeparator(pE.KeyChar))
            {
                pE.Handled = false;
            }
            else
            {
                pE.Handled = true;
                MessageBox.Show("Solo Letras");
            }
        }
    }
}
