using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Flurl.Http;

namespace Galenos
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string rut = txtRut.Text;
            string pass = txtPassword.Text;
            var response = "http://192.168.43.210:3000/logear/"
                   .PostUrlEncodedAsync(new { rut = rut, password = pass })
                   .ReceiveString();
            string result = response.Result.ToString();
            if (result != "false")
            {
                Session["cliente"] = result;
            }
            lblMen.Text = response.Result.ToString();
        }
    }
}