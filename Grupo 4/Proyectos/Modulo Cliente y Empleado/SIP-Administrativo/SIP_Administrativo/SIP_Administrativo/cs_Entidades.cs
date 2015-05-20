using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace SIP_Administrativo
{
    public class cs_Entidades
    {
        public class cs_Empleado
        {
            public int codigoEmp { get; set; }
            public int codigoEmpsa { get; set; }
            public int  dpiEmp  { get; set; }
            public int nitEmp   { get; set; }
            public string nombreEmp1 { get; set; }
            public string nombreEmp2 { get; set; }
            public string apellidoEmp1 { get; set; }
            public string apellidoEmp2 { get; set; }
            public string direEmp { get; set; }
            public int afiigssEmp { get; set; }
            public Boolean estadoEmp { get; set; }

            public cs_Empleado ()   { }

            public cs_Empleado (int codigoEmp, int codigoEmpsa, int dpiEmp, int nitEmp, string nombreEmp1, string nombreEmp2, 
                                string apellidoEmp1, string apellidoEmp2, string direEmp, int afiigssEmp, Boolean estadoEmp)
            {
                this.codigoEmp = codigoEmp;
                this.codigoEmpsa = codigoEmpsa;
                this.dpiEmp = dpiEmp;
                this.nitEmp = nitEmp;
                this.nombreEmp1 = nombreEmp1;
                this.nombreEmp2 = nombreEmp2;
                this.apellidoEmp1 = apellidoEmp1;
                this.apellidoEmp2 = apellidoEmp2;
                this.direEmp = direEmp;
                this.afiigssEmp = afiigssEmp;
                this.estadoEmp = estadoEmp;
            }
        }

        public class cs_Cliente
        {
            public int codigoCte { get; set; }
            //public int codigoEmpsaCte { get; set; }
            public int dpiCte  { get; set; }
            public int nitCte  { get; set; }
            public string nombre1Cte  { get; set; }
            public string nombre2Cte { get; set; }
            public string apellido1Cte { get; set; }
            public string apellido2Cte { get; set; }
            public int telefonoCte { get; set; }
            public string direCte { get; set; }
            
            public Boolean estadoCte { get; set; }

            public cs_Cliente ()   { }

            public cs_Cliente (int codigoCte, int codigoEmpsaCte, int dpiCte, int nitCte, string nombre1Cte,
                                string nombre2Cte, string apellido1Cte, string apellido2Cte, int telefonoCte, string direCte, Boolean estadoCte)
            {
                this.codigoCte = codigoCte;
                //this.codigoEmpsaCte = codigoEmpsaCte;
                this.dpiCte = dpiCte;
                this.nitCte = nitCte;
                this.nombre1Cte = nombre1Cte;
                this.nombre2Cte = nombre2Cte;
                this.apellido1Cte = apellido1Cte;
                this.apellido2Cte = apellido2Cte;
                this.telefonoCte = telefonoCte;
                this.direCte = direCte;
                this.estadoCte = estadoCte;
            }

        }

        public class cs_Proveedor
        {
            public int codigoProv { get; set; }
            public int nitProv { get; set; }
            public string nombreProv { get; set; }
            public string direccionProv { get; set; }
            public int telefonoProv { get; set; }
            public Boolean estadoProv { get; set; }

            public cs_Proveedor() { }

            public cs_Proveedor(int codigoProv, int nitProv, string nombreProv, string direccionProv,
                                  int telefonoProv, Boolean estadoProv)
            {
                this.codigoProv = codigoProv;
                this.nitProv = nitProv;
                this.nombreProv = nombreProv;
                this.direccionProv = direccionProv;
                this.telefonoProv = telefonoProv;
                this.estadoProv = estadoProv;
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
