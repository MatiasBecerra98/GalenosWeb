using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Galenos
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensajeInicial.Text = "";
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:57785/Inicio.aspx");
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nom = txtNombre.Text;
            string apellido = txtApellido.Text;
            string pass1 = txtContrasenia1.Text;
            string pass2 = txtContrasenia2.Text;
            lblMensaje.Text = "";

            if(pass1 == pass2)
            {
                try
                {
                    var response = "http://192.168.43.210:3000/registrarUsuario/"
                        .PostUrlEncodedAsync(new { nombre = nom, apellido = apellido, pass = pass1 })
                        .ReceiveString();
                    string result = response.Result.ToString();
                    if (result != "false")
                    {
                        Session["cliente"] = result;
                    }
                    lblMen.Text = "Paciente Registrado.";
                }
                catch (Exception ex)
                {
                    lblMen.Text = "ERROR 404";
                    
                }
            }
            else
            {
                lblMensaje.Text = "Las contraseñas no son Identicas";
            }
            



            
        }
    }
}