using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Cod_Bar
{
    public class csEntidades
    {
        public class cs_CodigoBarras
        {
            public int IdCodBar { get; set; }
            public int num_cobar { get; set; }
            public int codigo_cobar { get; set; }

            public cs_CodigoBarras() { }

            public cs_CodigoBarras(int Idcodbar, int num_cobar, int codigo_cobar)
            {
                this.IdCodBar = Idcodbar;
                this.num_cobar = num_cobar;
                this.codigo_cobar = codigo_cobar;
            }
        }
        
    }
}
