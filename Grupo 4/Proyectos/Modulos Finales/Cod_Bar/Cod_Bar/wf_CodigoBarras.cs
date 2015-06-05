using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Navegador;
using MySql.Data.MySqlClient;
using MySql.Data;

/*Autor: Cesar Estuardo Flores
 * Fecha: 28/05/2015
 * Comentario: Progrmación de Codigo de barras para producto
 */

namespace Cod_Bar
{
    public partial class wf_CodigoBarras : Form
    {
        private MySqlDataAdapter leer;
        private DataSet DS;

        csNegocio cbo = new csNegocio();
        ArrayList EnviaDatos = new ArrayList();

        string tsEmpresa;

        BarcodeLib.Barcode b = new BarcodeLib.Barcode();
        private int EANLen;

        private void llenarCboProduccion ()
        {
            cboCodProducto.Refresh();
            MySqlConnection conexion = BDcomun.ObtenerConexion();
            DataTable dt = new DataTable();

            string command = "SELECT cod_pro, cod_formu, cantidad_prod from tabm_produccion";
            MySqlDataAdapter da = new MySqlDataAdapter(command, conexion);
            da.Fill(dt);
            cboCodProducto.DataSource = dt;

            cboCodProducto.DisplayMember = "cod_pro";
            cboCodProducto.ValueMember = "cod_formu";
            cboCodProducto.ValueMember = "cantidad_prod";
            conexion.Close();
        }
        //Llenar Combobox Para consulta de Produccion
        private void ConsultaProduccion()
        {
            MySqlConnection connection = BDcomun.ObtenerConexion();
            string command = "SELECT tabm_produccion.cod_pro, cantidad_prod, tabm_formula.descrip_formu FROM tabm_produccion INNER JOIN tabm_formula ON tabm_produccion.cod_pro=tabm_formula.cod_formu where cod_pro='" + cboCodProducto.Text + "'";
           
            
            MySqlCommand comando = new MySqlCommand(command, connection);
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read() == true)
            {
               txtCodProducto.Text = leer["cod_pro"].ToString();
               txtNProd.Text = leer ["descrip_formu"].ToString();
               txtCaProd.Text = leer["cantidad_prod"].ToString();
            }
            else
            {
               txtCodProducto.Text = "";
               txtNProd.Text = "";
               txtCaProd.Text = "";
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConsultaProduccion();

            txtCodProducto.Enabled = true;
            txtNProd.Enabled = true;
            txtCaProd.Enabled = true;
        }

        private void wf_CodigoBarras_Load(object sender, EventArgs e)
        {
            EnviaDatos.Add(txtCodIdentificador);
            EnviaDatos.Add(txtCodProducto);
            EnviaDatos.Add(txtIngresoCode);
            EnviaDatos.Add(txtIngLote);

            navegador1.alDatosEntrada = EnviaDatos;
            navegador1.vIniciarNavegador();
            navegador1.btnModificar.Enabled = false;

            llenarCboProduccion();

            txtCodProducto.Enabled = false;
            txtNProd.Enabled = false;
            txtCaProd.Enabled = false;
            //btnGuardar.Enabled = false;
            //btnPrint.Enabled = false;
            //btnConsultar.Enabled = false;

        }
        //Inicializacion de Botones Codigo 8 y 13
        public wf_CodigoBarras()
        {
            InitializeComponent();
            rbtn8.Checked = true;
            this.txtIngresoCode.KeyPress+=new KeyPressEventHandler(txtIngresoCode_KeyPress);
            this.txtIngLote.KeyPress += new KeyPressEventHandler(txtIngDos_KeyPress);
        }

        public void vinicializar()
        {
            navegador1.btnEliminar.Enabled = false;
            navegador1.btnGuardar.Enabled = false;
            navegador1.btnModificar.Enabled = false;
            navegador1.btnNuevo.Enabled = false;
        }

        private void rbtn8_CheckedChanged_1(object sender, EventArgs e)
        {
            EANLen = 7;
            txtIngresoCode.Clear();
            txtIngresoCode.MaxLength = 7;
            txtIngresoCode.Focus();

            if (txtIngresoCode.Text.Length > 7)
                txtIngresoCode.Text = txtIngresoCode.Text.Remove(7);
        }

        private void rbtn13_CheckedChanged(object sender, EventArgs e)
        {
            txtIngresoCode.Clear();
            EANLen = 12;
            txtIngresoCode.MaxLength = 12;
            txtIngresoCode.Focus();
        }

        public void ConvertirEAN8()
        {
            string CodBarras;
            CodBarras = "";

            if (txtIngresoCode.Text.Trim().Length > 0)
            {
                int strL = EANLen - txtIngresoCode.Text.Trim().Length;
                string str = "";

                for (int i = 1; i <= strL; i++)
                {
                    str = str + "0";
                }
                CodBarras = txtIngresoCode.Text + str;
            }
            string strm = "";
            if (rbtn8.Checked == true)
                strm = EAN8(CodBarras) + AddOn(txtIngLote.Text.Trim());
            else
                strm = EAN13(CodBarras) + AddOn(txtIngLote.Text.Trim());

            txtCodigoBar.Text = strm;
        }
        //Conversion a codigo 8
        public string EAN8 (string chaine)
        {
            int i;
            double checksum;
            string CodBarras= "";
            checksum = 0;
            if (chaine.Length == 7)
            {
                for (i = 1; i <= 7; i++)
                {
                    int L1 = Convert.ToChar(chaine.Substring(i - 1, 1));
                    if ((L1 < 48) || (L1 > 57))
                    {
                        i = 0;
                        break;
                    }
                }
                if (i == 8)
                {
                    for (i = 7; i > 0; i = i - 2)
                    {
                        checksum = checksum + Convert.ToInt32(chaine.Substring(i - 1, 1));
                    }
                    checksum = checksum * 3;

                    for (i = 6; i > 0; i = i - 2)
                    {
                        checksum = checksum + Convert.ToInt32(chaine.Substring(i - 1, 1));
                    }
                    chaine = chaine + (10 - checksum % 10) % 10;

                    CodBarras = ":";

                    for (i = 1; i <= 4; i++)
                    {
                        CodBarras = CodBarras + Convert.ToChar(65 + Convert.ToInt32(chaine.Substring(i - 1, 1)));
                    }
                    CodBarras = CodBarras + "*";
                    for (i = 5; i <= 8; i++)
                    {
                        CodBarras = CodBarras + Convert.ToChar(97 + Convert.ToInt32(chaine.Substring(i - 1, 1)));
                    }
                    CodBarras = CodBarras + "+";
                }
            }
            return CodBarras;
        }

        public object EAN13(string chaine)
        {
            object functionReturnValue = null;
            int i;
            int checksum = 0;
            int first;
            string CodBarras;
            bool tableA;
            functionReturnValue = "";
            if (chaine.Length == 12)
            {
                for (i = 1; i <= 12; i++)
                {
                    int L1 = Convert.ToChar(chaine.Substring(i - 1, 1));
                    if (L1 < 48 || L1 > 57)
                    {
                        i = 0;
                        break;
                    }
                }
                if (i == 13)
                {
                    for (i = 12; i >= 1; i += -2)
                    {
                        checksum = checksum + Convert.ToInt32(chaine.Substring(i - 1, 1));
                    }
                    checksum = checksum * 3;
                    for (i = 11; i >= 1; i += -2)
                    {
                        checksum = checksum + Convert.ToInt32(chaine.Substring(i - 1, 1));
                    }
                    chaine = chaine + (10 - checksum % 10) % 10;
                    CodBarras = chaine.Substring(0, 1) + Convert.ToChar(65 + Convert.ToInt32((chaine.Substring(1, 1))));
                    first = Convert.ToInt32(chaine.Substring(0, 1));

                    for (i = 3; i <= 7; i++)
                    {
                        tableA = false;
                        switch (i)
                        {
                            case 3:
                                switch (first)
                                {
                                    case 0:
                                    case 1:
                                    case 2:
                                    case 3:
                                        tableA = true;
                                        break;
                                }
                                break;
                            case 4:
                                switch (first)
                                {
                                    case 0:
                                    case 4:
                                    case 7:
                                    case 8:
                                        tableA = true;
                                        break;
                                }
                                break;
                            case 5:
                                switch (first)
                                {
                                    case 0:
                                    case 1:
                                    case 4:
                                    case 5:
                                    case 9:
                                        tableA = true;
                                        break;
                                }
                                break;
                            case 6:
                                switch (first)
                                {
                                    case 0:
                                    case 2:
                                    case 5:
                                    case 6:
                                    case 7:
                                        tableA = true;
                                        break;
                                }
                                break;
                            case 7:
                                switch (first)
                                {
                                    case 0:
                                    case 3:
                                    case 6:
                                    case 8:
                                    case 9:
                                        tableA = true;
                                        break;
                                }
                                break;
                        }
                        if (tableA)
                        {
                            CodBarras = CodBarras + Convert.ToChar(65 + Convert.ToInt32(chaine.Substring(i - 1, 1)));
                        }
                        else
                        {
                            CodBarras = CodBarras + Convert.ToChar(75 + Convert.ToInt32(chaine.Substring(i - 1, 1)));
                        }
                    }
                    CodBarras = CodBarras + "*";
                    for (i = 8; i <= 13; i++)
                    {
                        CodBarras = CodBarras + Convert.ToChar(97 + Convert.ToInt32(chaine.Substring(i - 1, 1)));
                    }
                    CodBarras = CodBarras + "+";
                    functionReturnValue = CodBarras;
                }
            }
            return functionReturnValue;
        }

        public string AddOn(string chaine)
        {
            int i;
            int checksum = 0;
            string AddOnn = "";

            bool tableA;

            if (chaine.Length == 2 || chaine.Length == 5)
            {
                for (i = 1; i < chaine.Length; i++)
                {
                    int L1 = Convert.ToChar(chaine.Substring(i - 1, 1));

                    if (L1 < 48 || L1 > 57)
                    {
                        break;
                    }
                    if (chaine.Length == 2)
                    {
                        checksum = 10 + Convert.ToInt32(chaine) % 4;
                    }
                    else if (chaine.Length == 5)
                    {
                        for (i = 1; i == 5; i = i - 2)
                        {
                            checksum = checksum + Convert.ToInt32(chaine.Substring(i - 1, 1));
                        }
                        checksum = (checksum * 3 + Convert.ToInt32(chaine.Substring(2, 1)) * 9 + Convert.ToInt32(chaine.Substring(4, 1)) * 9) % 10;
                    }
                    AddOnn = "[";
                    for (i = 1; i <= chaine.Length; i++)
                    {
                        tableA = false;

                        switch (i)
                        {
                            case 1:
                                int[] str = { 4, 9, 10, 11 };
                                for (int j = 0; j < str.Length; j++)
                                {
                                    if (str[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;

                            case 2:
                                int[] str1 = { 1, 2, 3, 5, 6, 7, 10, 12 };
                                for (int j = 0; j < str1.Length; j++)
                                {
                                    if (str1[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;
                            case 3:
                                int[] str2 = { 0, 2, 3, 6, 7 };
                                for (int j = 0; j < str2.Length; j++)
                                {
                                    if (str2[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;
                            case 4:
                                int[] str3 = { 1, 3, 4, 8, 9 };
                                for (int j = 0; j < str3.Length; j++)
                                {
                                    if (str3[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;
                            case 5:
                                int[] str4 = { 0, 1, 2, 4, 5, 7 };
                                for (int j = 0; j < str4.Length; j++)
                                {
                                    if (str4[j] == checksum)
                                    {
                                        tableA = false;
                                        break;
                                    }
                                }
                                break;
                        }

                        if (tableA)
                            AddOnn = AddOnn + Convert.ToChar(65 + Convert.ToInt32(chaine.Substring(i - 1, 1)));
                        else
                            AddOnn = AddOnn + Convert.ToChar(75 + Convert.ToInt32(chaine.Substring(i - 1, 1)));

                        if ((chaine.Length == 2 && i == 1) || (chaine.Length == 5 && i < 5))
                            AddOnn = AddOnn + Convert.ToChar(92);
                    }
                }
            }
            return AddOnn;
        }

        private void txtIngresoCode_TextChanged(object sender, EventArgs e)
        {
            ConvertirEAN8();
        }

        private void txtIngDos_TextChanged(object sender, EventArgs e)
        {
            ConvertirEAN8();
        }

        private void txtIngresoCode_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtIngDos_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Metodo para guardar Codigo            
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp|GIF (*.gif)|*.gif|JPG (*.jpg)|*.jpg|PNG (*.png)|*.png|TIFF (*.tif)|*.tif";
            sfd.FilterIndex = 2;
            sfd.AddExtension = true;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                BarcodeLib.SaveTypes savetype = BarcodeLib.SaveTypes.UNSPECIFIED;
                switch (sfd.FilterIndex)
                {
                    case 1: /* BMP */  savetype = BarcodeLib.SaveTypes.BMP; break;
                    case 2: /* JPG */  savetype = BarcodeLib.SaveTypes.JPG; break;
                    case 3: /* PNG */  savetype = BarcodeLib.SaveTypes.PNG; break;
                    case 4: /* TIFF */ savetype = BarcodeLib.SaveTypes.TIFF; break;
                    default: break;
                }//switch
                b.SaveImage(sfd.FileName, savetype);
            }//if
         }

        private void btnPrint_Click(object sender, EventArgs e)
        {
        //Visualizando  un documento o Imprimirlo
            Vista_Codigo.Document = Imprimir_Codigo;
            Vista_Codigo.ShowDialog();
          //  Vista_Codigo.MdiParent();
            }

        private void txtCodigoBar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Imprimir_Codigo_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string captura = txtCaProd.Text;
            int i;
            for (i = 1; i <= 20; i++)
            {
                string text = txtCodigoBar.Text;
                string text3 = txtCodigoBar.Text;

                string text2 = text + text3;
                e.Graphics.DrawString(text2, new Font("Code EAN13", 48, FontStyle.Regular), Brushes.Black, 10, 10);
                //  string text = txtCodigoBar.Text;
                /*  System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < 10; i++)
                    {
                        sb.AppendLine(text.ToString());
                    }
                e.Graphics.DrawString(text, new  Font("Code EAN13", 48, FontStyle.Regular), Brushes.Black, 10, 10);
                 * */
            }
        }
  

        private void cboCodProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCodProducto.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void txtCEmpsa_TextChanged(object sender, EventArgs e)
        {
           
        }
    }

}
