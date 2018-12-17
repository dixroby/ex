<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="movimiento.aspx.cs" Inherits="ex.movimiento" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <form id="form1" runat="server">
        
            ingrese DNI&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:TextBox ID="txtDni" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" OnClick="Button1_Click" Text="verificar" />
            &nbsp;&nbsp;
        <br>
            numero de cuenta &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtNumeroCuenta" runat="server" Enabled="False"></asp:TextBox>
       
            <br />
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            depositar<br />
&nbsp;ingrese monto de deposito
            <asp:TextBox ID="Texmonto" runat="server"></asp:TextBox>

            &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lmonto" runat="server"></asp:Label>

            <br />
            <asp:Button ID="Button4" runat="server" Text="depositar" OnClick="Button4_Click" />
            
            <br />
            <asp:GridView ID="tdeposito" runat="server">
            </asp:GridView>
            <br />
            retirar<p>
            ingrese monto de retiro&nbsp;&nbsp;
            &nbsp;&nbsp;<asp:TextBox ID="txtRetiroo" runat="server"></asp:TextBox>
                &nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="retirar" />
        </p>
            <p>
                <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
            <p>
                <asp:GridView ID="tretiro" runat="server">
                </asp:GridView>
            </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
        </p>
    </form>
</asp:Content>
