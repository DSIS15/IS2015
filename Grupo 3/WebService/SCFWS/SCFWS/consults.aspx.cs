using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Schema;


namespace SCFWS
{
    public partial class Consults : System.Web.UI.Page
    {
        WebServices WS = new WebServices();
        string sFilePath = string.Empty;
                
        protected void Page_Load(object sender, EventArgs e)
        {

        }              

        private string sSubirArchivo(FileUpload fuFileUpload)
        {
            string sMensaje = string.Empty;
            if (fuFileUpload.HasFile)
            {
                try
                {
                    sFilePath = Server.MapPath("~/") + "xmls/" + Path.GetFileName(fuFileUpload.FileName);
                    fuFileUpload.SaveAs(sFilePath);
                }
                catch (Exception ex)
                {
                    sMensaje = "Error al subir el archivo, ocurrió el siguiente error:  " + ex.Message;
                }
            }
            return sMensaje;
        }

        protected void btnCargarCuentasBancarias_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(fuCuentasBancarias.FileName.ToString())) && (!string.IsNullOrEmpty(txtCodEmpsa.Text)) && (!string.IsNullOrEmpty(ddlCodMoneda.SelectedValue.ToString())))
            {
                lblRespu.Text = sSubirArchivo(fuCuentasBancarias);
                lblRespu.Text = WS.sAgregarCuentasBancarias(sFilePath, txtCodEmpsa.Text, ddlCodMoneda.SelectedValue.ToString());
                lblRespu2.Text = string.Empty;
                txtCodEmpsa.Text = string.Empty;
                ddlCodMoneda.SelectedIndex = 0;
                txtCodEmpsa.Focus();
            }
        }

        protected void btnCargarMovimientosBancarios_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(fuMovimientosBancarios.FileName.ToString())) && (!string.IsNullOrEmpty(txtCodEmpsa2.Text)) && (!string.IsNullOrEmpty(ddlCodMoneda2.SelectedValue.ToString())))
            {
                lblRespu2.Text = sSubirArchivo(fuMovimientosBancarios);
                lblRespu2.Text = WS.sAgregarMovimientosBancarios(sFilePath, txtCodEmpsa2.Text, ddlCodMoneda2.SelectedValue.ToString());
                lblRespu.Text = string.Empty;
                txtCodEmpsa2.Text = string.Empty;
                ddlCodMoneda2.SelectedIndex = 0;
                txtCodEmpsa2.Focus();
            }
        }
    }
}