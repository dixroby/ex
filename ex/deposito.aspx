<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="deposito.aspx.cs" Inherits="ex.deposito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <form id="form1" runat="server">
        <p>
            deposito</p>
        <p>
            ingrese dni
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            ingrese ingrese monto
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="depositar" />
        </p>
        <p>
            &nbsp;</p>
    </form>

</asp:Content>
