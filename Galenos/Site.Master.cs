using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galenos
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cliente"] != null)
            {
                btnIngreso.Visible = false;
                btnRegistro.Visible = false;
                btnSalir.Visible = true;
                lblCliente.Text = (string)Session["cliente"];
            }else
            {
                btnSalir.Visible = false;
            }
        }

        protected void btnIngreso_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Remove("cliente");
            Response.Redirect("Inicio.aspx");
        }
    }
}