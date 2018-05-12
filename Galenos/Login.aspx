<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Galenos.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="content grid">
        <div class="left_login">
            <img src="images/img_login.jpg" />
            <h3>This is Photoshop's version</h3>

            This is Photoshop's version  of Lorem Ipsum. Proin 
            gravida nibh vel velit auctor aliquet. Aenean sollicitudin, 
            lorem quis bibendum auctor, nisi elit consequat ipsum, nec sagittis sem 
            nibh id elit. Duis sed odio sit amet nibh vulputate cursus a sit amet mauris. 
            Morbi accumsan ipsum velit. Nam nec tellus a odio tincidunt auctor a ornare odio. 
            Sed non  mauris vitae erat consequat auctor eu in elit. Class aptent taciti sociosqu 
            egestas quam, ut aliquam massa nisl quis neque. Suspendisse in orci enim.
        </div>
        <div class="right_login">
            <h2>Ingreso Clientes</h2>
            <asp:Label ID="lblUsername" runat="server" Text="R.U.T (11.111.111-1)"></asp:Label><br />
            <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
            <asp:Label ID="lblPassword" runat="server" Text="Contraseña"></asp:Label><br />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:Button ID="btnLogin" runat="server" Text="Ingresar" OnClick="btnLogin_Click" />
            <asp:Label ID="lblMen" CssClass="mensaje_login" runat="server" Text="null"></asp:Label>
        </div>
        
    </div>
    
    <script>
        $(document).ready(function () {
            
            var exito = $('#ContentPlaceHolder1_lblMen').prop('innerHTML');
            if (exito=='false') {
                swal('', 'Usuario o contraseña incorrectos', 'error');
            } else if (exito == 'null') {
                //nada
            } else {
                window.location.replace('Inicio.aspx');
            }


        });
    </script>
</asp:Content>
