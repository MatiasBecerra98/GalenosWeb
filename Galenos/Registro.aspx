<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="Galenos.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMensajeInicial" runat="server" Text="Registro de Pacientes"></asp:Label>
    <br />
    <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
    <br />
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblApellido" runat="server" Text="Apellido"></asp:Label>
    <br />
    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblRut" runat="server" Text="Rut"></asp:Label>
    <br />
    <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblContrasenia" runat="server" Text="Contraseña"></asp:Label>
    <br />
    <asp:TextBox ID="txtContrasenia1" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="lblConfirmeContrasenia" runat="server" Text="Confirme Contraseña"></asp:Label>
    <br />
    <asp:TextBox ID="txtContrasenia2" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
    <br />
    <asp:Label ID="lblPrevision" runat="server" Text="Seleccione Previción"></asp:Label>
    <br />
    <asp:DropDownList ID="DropDownList1" runat="server">
        <asp:ListItem Selected="True" Value="0">Particular</asp:ListItem>
        <asp:ListItem Value="1">Fonasa</asp:ListItem>
        <asp:ListItem Value="2">Isapre</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="lblSeguro" runat="server" Text="Seguro Medico"></asp:Label>
    <br />
    <asp:RadioButton ID="rbSi" runat="server" GroupName="seguro" Text="Si" />
&nbsp;<asp:RadioButton ID="rbNo" runat="server" GroupName="seguro" Text="No" />
    <br />
    <asp:Button ID="btnRegistrar" runat="server" OnClick="btnRegistrar_Click" Text="Registrar" />
&nbsp;
    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" />
    <br />
    <br />
    <asp:Label ID="lblMen" runat="server"></asp:Label>
    <br />
</asp:Content>
