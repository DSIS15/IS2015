﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reporteador_IS
{
    public partial class wf_RepoEmpleado : Form
    {
        public wf_RepoEmpleado()
        {
            InitializeComponent();
        }

        private void wf_RepoEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DT_Empleado.DataTable' Puede moverla o quitarla según sea necesario.
            this.DataTableTableAdapter.Fill(this.DT_Empleado.DataTable);

            this.reportViewer1.RefreshReport();
        }
    }
}